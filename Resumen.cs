private void ExportarResumenAPDF()
{
    DateTime fechaDesde = dtpFechaDesde.Value.Date;
    DateTime fechaHasta = dtpFechaHasta.Value.Date;
    try
    {
        using (SqlConnection conn = conexionSQL.ObtenerConexion())
        {
            if (conn == null) return;

            // --- Consultas para Resumen General ---
            string queryTotalPrestado = "SELECT ISNULL(SUM(MontoTotal), 0) FROM Prestamos WHERE FechaPrestamo BETWEEN @FechaDesde AND @FechaHasta";
            string queryTotalIntereses = "SELECT ISNULL(SUM(TotalAPagar - MontoTotal), 0) FROM Prestamos WHERE FechaPrestamo BETWEEN @FechaDesde AND @FechaHasta";
            string queryTotalCuotas = "SELECT ISNULL(SUM(MontoPago), 0) FROM Pagos WHERE FechaPago BETWEEN @FechaDesde AND @FechaHasta";
            string queryCountPrestamos = "SELECT COUNT(*) FROM Prestamos WHERE FechaPrestamo BETWEEN @FechaDesde AND @FechaHasta";

            SqlCommand cmd = new SqlCommand(queryTotalPrestado, conn);
            cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            decimal totalPrestado = Convert.ToDecimal(cmd.ExecuteScalar());

            cmd = new SqlCommand(queryTotalIntereses, conn);
            cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            decimal totalIntereses = Convert.ToDecimal(cmd.ExecuteScalar());

            cmd = new SqlCommand(queryTotalCuotas, conn);
            cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            decimal totalCuotas = Convert.ToDecimal(cmd.ExecuteScalar());

            cmd = new SqlCommand(queryCountPrestamos, conn);
            cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            int countPrestamos = Convert.ToInt32(cmd.ExecuteScalar());

            // --- Consulta para Resumen Mensual ---
            string queryMensual = @"
                SELECT 
                    YEAR(FechaPrestamo) AS Anio,
                    MONTH(FechaPrestamo) AS Mes,
                    COUNT(*) AS CantidadPrestamos,
                    SUM(MontoTotal) AS TotalPrestado,
                    SUM(TotalAPagar - MontoTotal) AS InteresesGenerados
                FROM Prestamos
                WHERE FechaPrestamo BETWEEN @FechaDesde AND @FechaHasta
                GROUP BY YEAR(FechaPrestamo), MONTH(FechaPrestamo)
                ORDER BY YEAR(FechaPrestamo), MONTH(FechaPrestamo)";
            SqlCommand cmdMensual = new SqlCommand(queryMensual, conn);
            cmdMensual.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            cmdMensual.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            SqlDataAdapter adaptMensual = new SqlDataAdapter(cmdMensual);
            DataTable dtMensual = new DataTable();
            adaptMensual.Fill(dtMensual);

            // --- Consulta para Detalle de Préstamos ---
            string queryDetalle = @"
                SELECT 
                    PrestamoID,
                    TipoPrestamo,
                    (SELECT Nombre FROM Clientes WHERE ClienteID = Prestamos.ClienteID) AS Cliente,
                    (SELECT Nombre FROM Empleados WHERE EmpleadoID = Prestamos.EmpleadoID) AS Empleado,
                    MontoTotal,
                    SaldoPendiente,
                    FechaPrestamo,
                    FechaVencimiento,
                    TotalAPagar,
                    ValorCuota,
                    CantidadCuotas,
                    CASE 
                        WHEN SaldoPendiente <= 0 THEN 'Pagado'
                        WHEN GETDATE() > FechaVencimiento THEN 'Vencido'
                        ELSE 'Activo'
                    END AS Estado
                FROM Prestamos
                WHERE FechaPrestamo BETWEEN @FechaDesde AND @FechaHasta
                ORDER BY FechaPrestamo DESC";
            SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn);
            cmdDetalle.Parameters.AddWithValue("@FechaDesde", fechaDesde);
            cmdDetalle.Parameters.AddWithValue("@FechaHasta", fechaHasta);
            SqlDataAdapter adaptDetalle = new SqlDataAdapter(cmdDetalle);
            DataTable dtDetalle = new DataTable();
            adaptDetalle.Fill(dtDetalle);

            // --- Crear PDF ---
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = "ResumenPrestamos.pdf"
            };
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate(), 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();

            // Título General
            Paragraph header = new Paragraph("Reporte General de Préstamos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22))
            {
                Alignment = Element.ALIGN_CENTER
            };
            doc.Add(header);
            doc.Add(new Paragraph($"Período: {fechaDesde:dd/MM/yyyy}  -  {fechaHasta:dd/MM/yyyy}\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 12)));

            // --- Sección 1: Resumen General ---
            Paragraph resumenGeneralTitle = new Paragraph("1. Resumen General", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16))
            {
                SpacingAfter = 10
            };
            doc.Add(resumenGeneralTitle);

            PdfPTable tableGeneral = new PdfPTable(2)
            {
                WidthPercentage = 50,
                HorizontalAlignment = Element.ALIGN_LEFT
            };
            tableGeneral.SetWidths(new float[] { 2, 3 });
            tableGeneral.SpacingAfter = 20;

            // Agregar filas de métricas
            tableGeneral.AddCell(new PdfPCell(new Phrase("Total Prestado:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { Border = 0 });
            tableGeneral.AddCell(new PdfPCell(new Phrase($"{totalPrestado:C}", FontFactory.GetFont(FontFactory.HELVETICA, 12))) { Border = 0 });
            tableGeneral.AddCell(new PdfPCell(new Phrase("Intereses Generados:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { Border = 0 });
            tableGeneral.AddCell(new PdfPCell(new Phrase($"{totalIntereses:C}", FontFactory.GetFont(FontFactory.HELVETICA, 12))) { Border = 0 });
            tableGeneral.AddCell(new PdfPCell(new Phrase("Cuotas Cobradas:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { Border = 0 });
            tableGeneral.AddCell(new PdfPCell(new Phrase($"{totalCuotas:C}", FontFactory.GetFont(FontFactory.HELVETICA, 12))) { Border = 0 });
            tableGeneral.AddCell(new PdfPCell(new Phrase("Total Préstamos:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { Border = 0 });
            tableGeneral.AddCell(new PdfPCell(new Phrase($"{countPrestamos}", FontFactory.GetFont(FontFactory.HELVETICA, 12))) { Border = 0 });

            doc.Add(tableGeneral);

            // --- Sección 2: Resumen Mensual ---
            Paragraph resumenMensualTitle = new Paragraph("2. Resumen Mensual", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16))
            {
                SpacingAfter = 10
            };
            doc.Add(resumenMensualTitle);

            PdfPTable tableMensual = new PdfPTable(5)
            {
                WidthPercentage = 90,
                HorizontalAlignment = Element.ALIGN_CENTER
            };
            tableMensual.SetWidths(new float[] { 1, 1, 1, 1, 1 });
            // Encabezados
            tableMensual.AddCell(new PdfPCell(new Phrase("Año", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableMensual.AddCell(new PdfPCell(new Phrase("Mes", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableMensual.AddCell(new PdfPCell(new Phrase("Préstamos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableMensual.AddCell(new PdfPCell(new Phrase("Total Prestado", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableMensual.AddCell(new PdfPCell(new Phrase("Intereses Generados", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });

            foreach (DataRow row in dtMensual.Rows)
            {
                tableMensual.AddCell(new PdfPCell(new Phrase(row["Anio"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 12))));
                tableMensual.AddCell(new PdfPCell(new Phrase(row["Mes"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 12))));
                tableMensual.AddCell(new PdfPCell(new Phrase(row["CantidadPrestamos"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 12))));
                tableMensual.AddCell(new PdfPCell(new Phrase(string.Format("{0:C}", row["TotalPrestado"]), FontFactory.GetFont(FontFactory.HELVETICA, 12))));
                tableMensual.AddCell(new PdfPCell(new Phrase(string.Format("{0:C}", row["InteresesGenerados"]), FontFactory.GetFont(FontFactory.HELVETICA, 12))));
            }
            tableMensual.SpacingAfter = 20;
            doc.Add(tableMensual);

            // --- Sección 3: Detalle de Préstamos ---
            Paragraph detalleTitle = new Paragraph("3. Detalle de Préstamos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16))
            {
                SpacingAfter = 10
            };
            doc.Add(detalleTitle);

            PdfPTable tableDetalle = new PdfPTable(9)
            {
                WidthPercentage = 100,
                HorizontalAlignment = Element.ALIGN_CENTER
            };
            tableDetalle.SetWidths(new float[] { 1, 1, 2, 2, 1, 1, 1, 1, 1 });
            // Encabezados
            tableDetalle.AddCell(new PdfPCell(new Phrase("Código", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Tipo", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Cliente", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Empleado", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Monto Total", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Saldo", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Inicio", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Vencimiento", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });
            tableDetalle.AddCell(new PdfPCell(new Phrase("Estado", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))) { BackgroundColor = BaseColor.LIGHT_GRAY });

            foreach (DataRow row in dtDetalle.Rows)
            {
                tableDetalle.AddCell(new PdfPCell(new Phrase(row["PrestamoID"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(row["TipoPrestamo"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(row["Cliente"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(row["Empleado"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(string.Format("{0:C}", row["MontoTotal"]), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(string.Format("{0:C}", row["SaldoPendiente"]), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["FechaPrestamo"]).ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(Convert.ToDateTime(row["FechaVencimiento"]).ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
                tableDetalle.AddCell(new PdfPCell(new Phrase(row["Estado"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 9))));
            }
            tableDetalle.SpacingAfter = 20;
            doc.Add(tableDetalle);

            // Cerrar documento y writer
            doc.Close();
            writer.Close();

            MessageBox.Show("PDF exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}