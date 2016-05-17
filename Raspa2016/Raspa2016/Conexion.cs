using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raspa2016
{
    public class Conexion
    {
        private void CreaPdf(DataTable T)
        {
            //    var document = new Document(PageSize.A4, 50, 50, 25, 25);

            //    // Crea un Nuevo objeto PdfWriter, especificando la salida 
            //    var output = new FileStream(@"C:\prueba1.pdf", FileMode.Create);
            //    var writer = PdfWriter.GetInstance(document, output);
            //    // Abre el document para escritura
            //    document.Open();
            //    var Titulo = FontFactory.GetFont("Arial", 18);//("Arial", 18, Font.Bold);
            //    var Subtitulo = FontFactory.GetFont("Arial", 14);//, Font.BOLD);
            //    var tablabold = FontFactory.GetFont("Arial", 12);//, Font.BOLD);
            //    var msjfinal = FontFactory.GetFont("Arial", 10);//, Font.ITALIC);
            //    var contenido = FontFactory.GetFont("Arial", 12);//, Font.NORMAL);

            //    ////document.Add(new Paragraph("CUPONES", Titulo));
            //    // Agrega elementos al Pdf 
            //    var orderInfoTable = new PdfPTable(6);
            //    orderInfoTable.HorizontalAlignment = 0;
            //    orderInfoTable.SpacingBefore = 10;
            //    orderInfoTable.SpacingAfter = 10;
            //    orderInfoTable.DefaultCell.Border = 0;
            //    //orderInfoTable.SetWidths(new int[] {1});//.SetWidths(new int[]{1,4});//(new int[] { 1, 4 });




            //    foreach (DataRow row in T.Rows)
            //    {
            //        orderInfoTable.AddCell(row[0].ToString());

            //    }

            //    document.Add(orderInfoTable);
            //    // Cierra el documento y guarda el archivo al canal de salida 
            //    document.Close();
            //}
            //private void CrearPDF1(DataTable T1)
            //{
            //    PdfPCell Cell_Ficha = null;
            //    var docu = new Document(PageSize.A4, 50, 50, 25, 25);
            //    var output = new FileStream(@"C:\prueba2.pdf", FileMode.Create);
            //    var writer = PdfWriter.GetInstance(docu, output);

            //    var T_Ficha = new PdfPTable(1);

            //    docu.Open();

            //    foreach (DataRow r in T1.Rows)
            //    {
            //        //Etiqueta
            //        var Letra = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, 1, BaseColor.BLACK);
            //        Cell_Ficha = new PdfPCell(new Phrase(r[0].ToString() + r[1].ToString(), Letra));
            //        //Cell_Ficha.Colspan = Convert.ToInt32(r[2].ToString());
            //        Cell_Ficha.VerticalAlignment = Element.ALIGN_BOTTOM; //Es Vertical, estaba usando Horizontal
            //        Cell_Ficha.UseAscender = false;
            //        T_Ficha.AddCell(Cell_Ficha);
            //    }


            //    docu.Add(T_Ficha);
            //    docu.Close();
            //}
            //}
        }
    }
}