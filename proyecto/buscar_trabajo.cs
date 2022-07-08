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
                if (line != ",,,,,") { 
                    var cols = line.Split(',');

                    DataRow dr = tbl.NewRow();
                    for (int cIndex = 0; cIndex < 6; cIndex++)
                    {
                        dr[cIndex] = cols[cIndex];
                    }

                    tbl.Rows.Add(dr);
                }
            }
            lector.Close();
            return tbl;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            dg_datos.DataSource = "";
            dg_datos.Columns.Clear();
            //dg_datos.Rows.Clear();
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
                //Exportamos de nuevo el datagrid
                string[,] conjunto = new string[dg_datos.Rows.Count, dg_datos.Columns.Count];
                string[,] conjunto_modificado = new string[dg_datos.Rows.Count, dg_datos.Columns.Count];
                foreach (DataGridViewRow row in dg_datos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cel in row.Cells)
                        {
                            conjunto[cel.RowIndex, cel.ColumnIndex] = cel.Value.ToString();
                        }
                    }
                }

                //Buscar empleos
                for (int i = 0; i < dg_datos.Rows.Count; i++)
                {
                    if (conjunto[i, 4] != "")
                    {
                        if (Int16.Parse(txt_edad.Text) >= Int16.Parse(conjunto[i, 4]) && cb_tiempo.Text == conjunto[i, 3] && cb_estudio.Text == conjunto[i, 5])
                        {
                            conjunto_modificado[i, 0] = conjunto[i, 0];
                            conjunto_modificado[i, 1] = conjunto[i, 1];
                            conjunto_modificado[i, 4] = conjunto[i, 4];
                            conjunto_modificado[i, 2] = conjunto[i, 2];
                            conjunto_modificado[i, 5] = conjunto[i, 5];
                            conjunto_modificado[i, 3] = conjunto[i, 3];
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                }

                //Borrar archivo txt
                File.Delete(@"C:\archivo\empleos_filtrado.csv");

                //Crear nuevo archivo y guardar la matriz
                File.Create(@"C:\archivo\empleos_filtrado.csv").Close();

                // Insertar en el csv
                for (int i = 0; i < dg_datos.Rows.Count; i++)
                {
                    File.AppendAllText(@"C:\archivo\empleos_filtrado.csv", conjunto_modificado[i, 0] + "," + conjunto_modificado[i, 1] + "," + conjunto_modificado[i, 2] + "," + conjunto_modificado[i, 3] + "," + conjunto_modificado[i, 4] + "," + conjunto_modificado[i, 5] + "\n");
                }
                MessageBox.Show("Gracias por confiar en nosotros" + txt_nombre.Text, "Mensaje del sistema");
                //Limpiar Datagrid
                dg_datos.DataSource = "";
                dg_datos.Columns.Clear();
                //dg_datos.Rows.Clear();
                dg_datos.DataSource = CargarTrabajos();

                //Limpiar forms
                cb_estudio.Text = "";
                cb_tiempo.Text = "";
                txt_correo.Text = "";
                txt_edad.Text = "";
                txt_nombre.Text = "";
            }
            else
            {
                MessageBox.Show("Aun faltan datos por llenar","Mensaje del sistema");
            }
        }

        public DataTable CargarTrabajos()
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
            var lector = new StreamReader(File.OpenRead(@"C:\archivo\empleos_filtrado.csv"));
            for (int col = 0; col < 6; col++)
                tbl.Columns.Add(new DataColumn("Columna " + (columnas[col]).ToString()));
            //En el ciclo while, recorre todas las lineas del archivo

            while (!lector.EndOfStream)
            {
                //Guarda el contenido de cada linea
                var line = lector.ReadLine();
                //Nombre de empresa, edad, tiempo y correo
                if (line != ",,,,,")
                {
                    var cols = line.Split(',');

                    DataRow dr = tbl.NewRow();
                    for (int cIndex = 0; cIndex < 6; cIndex++)
                    {
                        dr[cIndex] = cols[cIndex];
                    }

                    tbl.Rows.Add(dr);
                }
            }
            lector.Close();
            return tbl;
        }
    }
}
