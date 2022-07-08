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
    public partial class buscar_trabajo : MaterialSkin.Controls.MaterialForm
    {
        public buscar_trabajo()
        {
            InitializeComponent();
        }

        private void buscar_trabajo_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightGreen900, Accent.Green700, TextShade.WHITE);
            dg_datos.DataSource = ConvertToDataTable();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            index volver = new index();
            volver.Show();
            this.Close();
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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

            return tbl;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            dg_datos.Columns.Clear();
            
            dg_datos.DataSource = ConvertToDataTable();

            txt_edad.Clear();
            txt_nombre.Clear();
            txt_correo.Clear();

            cb_estudio.Text = "";
            cb_tiempo.Text = "";
            MessageBox.Show("Se limpio con exito", "Mensaje del sistema");
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (txt_correo.Text != "" && txt_edad.Text != "" && txt_nombre.Text != "" && cb_estudio.Text != "" && cb_tiempo.Text != "")
            {
                for (int x = 0; x < dg_datos.Rows.Count; x++)
                {
                    //Recorrer datagrid y buscar trabajos adecuados
                    
                }
            }
            else
            {
                MessageBox.Show("Aun faltan datos por llenar","Mensaje del sistema");
            }
        }
    }
}
