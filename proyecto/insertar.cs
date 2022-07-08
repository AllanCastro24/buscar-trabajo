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
    public partial class insertar : MaterialSkin.Controls.MaterialForm
    {
        public insertar()
        {
            InitializeComponent();
        }

        private void insertar_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightGreen900, Accent.Green700, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            admin volver = new admin();
            volver.Show();
            this.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            txt_correo.Clear();
            txt_edad.Clear();
            txt_nombre.Clear();

            cb_estudio.Text = "";
            cb_tiempo.Text = "";
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

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "" && txt_edad.Text != "" && txt_correo.Text != "" && cb_tiempo.Text != "" && cb_estudio.Text != "")
            {
                //Primero leer la cantidad de datos
                var total_datos = File.ReadLines(@"C:\archivo\empleos.csv").Count();
                string texto = total_datos+1+","+txt_nombre.Text + "," + txt_correo.Text + "," + cb_tiempo.Text + ","+txt_edad.Text + "," + cb_estudio.Text;

                using (StreamWriter file = new StreamWriter(@"C:\archivo\empleos.csv", true))
                {
                    file.WriteLine(texto); //se agrega información al documento

                    file.Close();
                    MessageBox.Show("Agregado con exito!", "Mensaje del sistema");
                    btn_limpiar.PerformClick();
                }
                
            }
            else
            {
                MessageBox.Show("Aun falta datos por llenar..", "Mensaje del sistema");
            }
        }
    }
}
