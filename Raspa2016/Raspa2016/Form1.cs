using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;


namespace Raspa2016
{
    public partial class Form1 : Form
    {
        public Cupon cCupon;  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            using (var cmd = new SqlCommand("InsertarTickets", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@cantidad", 10);
                p1.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@leyenda", "SEGUI PARTICIPANDO");
                p2.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p2);

                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("conection ok");
                }

                var ruta = ConfigurationManager.AppSettings["PF"];
                var archivo = ConfigurationManager.AppSettings["NF"];

                con.Close();

                //CreaPdf(table);
                //datatable_to_ps(table, ruta, archivo);
                //dataset_to_file_txt(table, @"c:\tabla"); 
                //CrearPDF1(table);
                //dataset_to_file_PS(table, @"c:\tablaPS");
                GeneraPS(table);

                //prueba Git

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataset_to_file_txt(DataTable dt, String path)
        {
           String[] texto;
           texto = new String[dt.Rows.Count + 1 ];
          //Rellenamos el detalle del fichero
           String linea;
           for (int i = 0; i < dt.Rows.Count; i++)
           {
              linea = String.Empty;
              for (int j = 0; j < dt.Columns.Count; j++)
              {
                 linea += dt.Rows[i][j].ToString() + ",";
              }
              texto[i] = linea.Remove(linea.Length-1, 1);
           }
           File.WriteAllLines(path + ".txt", texto);
           
        }
        private void dataset_to_file_PS(DataTable dt, String path)
        {
            String[] texto;
            texto = new String[dt.Rows.Count + 1];

            String linea; //= PostCript.encabezado; ;


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                linea = String.Empty;
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    linea += i  +" " + j + " MV f1 " + "[(" + dt.Rows[i][j].ToString() + ") /c P" + "\r\n";
                    
                }
                texto[i] = linea;

            }
            File.WriteAllLines(path + ".txt", texto);

        }
        private void datatable_to_ps(DataTable dt, String path, String archivo)
        {
            var CadenaDataTable = "";
            CadenaDataTable = PostCript.encabezado;

            int Xinicial = 115;
            int Yinicial = 765;


            int desplazaX = 5;
            int desplazaY = 15;

            foreach (DataRow row in dt.Rows)
            {
                CadenaDataTable += "10 " + "10 " + "MV f1 " + "[(" + row[0] + ") /c P" + "\r\n" +
                                   "10 " + "20 " + "MV f1 " + "[(" + row[1] + ") /c P" + "\r\n" +
                                   "10 " + "30 " + "MV f1 " + "[(" + row[2] + ") /c P" + "\r\n";

            }

            StreamWriter file = new StreamWriter(path + archivo, true);
            file.WriteLine(CadenaDataTable);
            file.Close();
        }


        private void GeneraPS(DataTable dt)
        {
            var CadenaDataTable = "";
            CadenaDataTable = PostCript.encabezado;
            int Xinicial = 115;
            int Yinicial = 765;
            int Yinicial1 = 615;
            int desplazaX = 150;
            int desplazaY = -250;
            int Fpagina = 2;//filas por paginas 3 ojo pongo 2 xq tiene que ser base 0
            int Cpagian = 3;//columnas por paginas 4 ojo pongo 3 xq tiene que ser base 0
            int i=0;//filas
            int j=0;//colunmas

            //int indice=dt.Rows.IndexOf(row);
            // var a= dt.Rows.Count;
            
            foreach (DataRow row in dt.Rows)
            {
                int y  = Yinicial  + (i * desplazaY);
                int x  = Xinicial  + (j * desplazaX);
                int y1 = Yinicial1 + (i * desplazaY);

                CadenaDataTable += x + " " + y + " MV f1 " + "[(" + row[0] + ") /c P" + "\r\n"+
                                    x +" "+ y1 + " MV f1 " + "[(" + row[1] + ") /c P" + "\r\n";

                if (j < Cpagian)
                {
                    j++;
                }
                else
                {
                    j = 0;
                    i++;
                }

                

            }
            StreamWriter file = new StreamWriter(@"C:\PS1.ps", true);
            file.WriteLine(CadenaDataTable);
            file.Close();
        }



    }
}
