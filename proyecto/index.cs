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
    public partial class index : MaterialSkin.Controls.MaterialForm
    {
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightGreen900, Accent.Green700, TextShade.WHITE);

            //Crear la carpeta y el directorio que se necesita
            if (!Directory.Exists(@"C:\archivo"))
            {
                Directory.CreateDirectory(@"C:\archivo");
            }

            if (!File.Exists(@"C:\archivo\empleos.csv"))
            {
                File.Create(@"C:\archivo\empleos.csv").Close();
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            buscar_trabajo entrar = new buscar_trabajo();
            entrar.Show();
            this.Hide();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrar_pass.Checked) { 
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text == "Laurita" && txt_pass.Text == "12345") {
                MessageBox.Show("Bienvenido " + txt_user.Text, "Mensaje del sistema");
                admin entrar = new admin();
                entrar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña está incorrecto o no ha ingresado aun  algún usuario o contraseña", "Mensaje del sistema");
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
