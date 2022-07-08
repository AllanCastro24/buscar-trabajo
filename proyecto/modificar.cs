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
    public partial class modificar : MaterialSkin.Controls.MaterialForm
    {
        public modificar()
        {
            InitializeComponent();
        }

        private void modificar_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightGreen900, Accent.Green700, TextShade.WHITE);

            dg_datos.DataSource = ConvertToDataTable();
            
            string[,] conjunto = new string[dg_datos.Rows.Count, dg_datos.Columns.Count];

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
            //Llenar el combobox
            for (int i = 0; i < dg_datos.Rows.Count; i++)
            {
                if (conjunto[i, 0] != "")
                {
                    cb_datos.Items.Add(conjunto[i, 0] + " - " + conjunto[i, 1]);
                }
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
            lector.Close();
            return tbl;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            admin volver = new admin();
            volver.Show();
            this.Close();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            string[,] conjunto = new string[dg_datos.Rows.Count, dg_datos.Columns.Count];
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
            if (cb_datos.Text != "" )
            {
                int id = Int16.Parse(cb_datos.Text.Substring(0, 1));
                if (conjunto[id-1, 0] != "")
                {
                    //Llenar datos
                    txt_nombre.Text = conjunto[id - 1, 1];
                    txt_edad.Text = conjunto[id - 1, 4];
                    txt_correo.Text = conjunto[id - 1, 2];
                    cb_estudio.Text = conjunto[id - 1, 5];
                    cb_tiempo.Text = conjunto[id - 1, 3];
                }
            }
            else
            {
                MessageBox.Show("No seleccionó un registro", "Mensaje del sistema");
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //Exportamos de nuevo el datagrid
            string[,] conjunto = new string[dg_datos.Rows.Count, dg_datos.Columns.Count];
            //string[,] conjunto_modificado = new string[dg_datos.Rows.Count, dg_datos.Columns.Count];
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

            int id = Int16.Parse(cb_datos.Text.Substring(0, 1));

            conjunto[id - 1, 1] = txt_nombre.Text;
            conjunto[id - 1, 4] = txt_edad.Text;
            conjunto[id - 1, 2] = txt_correo.Text;
            conjunto[id - 1, 5] = cb_estudio.Text;
            conjunto[id - 1, 3] = cb_tiempo.Text;

            //Borrar archivo txt
            File.Delete(@"C:\archivo\empleos.csv");

            //Crear nuevo archivo y guardar la matriz
            File.Create(@"C:\archivo\empleos.csv").Close();

            // Insertar en el csv
            for (int i = 0; i < dg_datos.Rows.Count; i++)
            {
                File.AppendAllText(@"C:\archivo\empleos.csv", conjunto[i, 0] + "," + conjunto[i, 1] + "," + conjunto[i, 2] + "," + conjunto[i, 3] + "," + conjunto[i, 4] + "," + conjunto[i, 5] + "\n");
            }
            MessageBox.Show("Registro modificado con exito", "Mensaje del sistema");
            dg_datos.DataSource = ConvertToDataTable();
            cb_datos.Items.Clear();
            cb_datos.Text = "";
            for (int i = 0; i < dg_datos.Rows.Count; i++)
            {
                if (conjunto[i, 0] != "")
                {
                    cb_datos.Items.Add(conjunto[i, 0] + " - " + conjunto[i, 1]);
                }
            }

            //Limpiar forms
            cb_datos.Text = "";
            cb_estudio.Text = "";
            cb_tiempo.Text = "";
            txt_correo.Text = "";
            txt_edad.Text = "";
            txt_nombre.Text = "";
        }
    }
}
