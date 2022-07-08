using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace proyecto_ñañi
{
    public partial class admin : MaterialSkin.Controls.MaterialForm
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue900, Primary.LightGreen900, Accent.Green700, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            index volver = new index();
            volver.Show();
            this.Close();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            consultar volver = new consultar();
            volver.Show();
            this.Hide();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            insertar entrar = new insertar();
            entrar.Show();
            this.Hide();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            modificar entrar = new modificar();
            entrar.Show();
            this.Hide();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            borrar entrar = new borrar();
            entrar.Show();
            this.Hide();
        }
    }
}
