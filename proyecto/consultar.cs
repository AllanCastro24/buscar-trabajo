using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace proyecto_ñañi
{
    public partial class consultar : MaterialSkin.Controls.MaterialForm
    {
        public consultar()
        {
            InitializeComponent();
        }

        private void consultar_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightGreen900, Accent.Green700, TextShade.WHITE);
            dg_datos.DataSource = ConvertToDataTable();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            admin volver = new admin();
            volver.Show();
            this.Close();
        }
        public DataTable ConvertToDataTable()
        {
            String[] columnas = new String[6];
            columnas[0] = "Clave";
            columnas[1] = "Empresa";
            columnas[2] = "Correo";
            columnas[3] = "Tiempo";
            columnas[4] = "Edad";
            columnas[5] = "Escolaridad";
            DataTable tbl = new DataTable();
            //Se crea variable llamada: lector, para abrir el archivo csv donde están almacenadas los datos de los alumnos.
            var lector = new StreamReader(File.OpenRead(@"C:\archivo\empleos.csv"));
            for (int col = 0; col < 6; col++)
                tbl.Columns.Add(new DataColumn("Columna " + (columnas[col]).ToString()));
            //En el ciclo while, recorre todas las lineas del archivo

            while (!lector.EndOfStream)
            {
                //Guarda el contenido de cada linea
                var line = lector.ReadLine();
                //Nombre de empresa, edad, tiempo y correo
                var cols = line.Split(',');

                DataRow dr = tbl.NewRow();
                for (int cIndex = 0; cIndex < 6; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                tbl.Rows.Add(dr);
            }
            lector.Close();
            return tbl;
        }
    }
}
