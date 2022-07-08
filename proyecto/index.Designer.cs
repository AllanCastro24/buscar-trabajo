
namespace proyecto_ñañi
{
    partial class index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cb_mostrar_pass = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(107, 507);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(315, 46);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Buscar trabajo (Sin conexión)";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(193, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Inicio de sesión";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(103, 171);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Usuario";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(103, 261);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Contraseña";
            // 
            // txt_user
            // 
            this.txt_user.Depth = 0;
            this.txt_user.Hint = "";
            this.txt_user.Location = new System.Drawing.Point(107, 218);
            this.txt_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.SelectedText = "";
            this.txt_user.SelectionLength = 0;
            this.txt_user.SelectionStart = 0;
            this.txt_user.Size = new System.Drawing.Size(315, 28);
            this.txt_user.TabIndex = 4;
            this.txt_user.UseSystemPasswordChar = false;
            // 
            // txt_pass
            // 
            this.txt_pass.Depth = 0;
            this.txt_pass.Hint = "";
            this.txt_pass.Location = new System.Drawing.Point(107, 302);
            this.txt_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.Size = new System.Drawing.Size(315, 28);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Depth = 0;
            this.btn_login.Location = new System.Drawing.Point(170, 445);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(187, 46);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Iniciar sesión";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cb_mostrar_pass
            // 
            this.cb_mostrar_pass.AutoSize = true;
            this.cb_mostrar_pass.Depth = 0;
            this.cb_mostrar_pass.Font = new System.Drawing.Font("Roboto", 10F);
            this.cb_mostrar_pass.Location = new System.Drawing.Point(107, 365);
            this.cb_mostrar_pass.Margin = new System.Windows.Forms.Padding(0);
            this.cb_mostrar_pass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_mostrar_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_mostrar_pass.Name = "cb_mostrar_pass";
            this.cb_mostrar_pass.Ripple = true;
            this.cb_mostrar_pass.Size = new System.Drawing.Size(182, 30);
            this.cb_mostrar_pass.TabIndex = 7;
            this.cb_mostrar_pass.Text = "Mostrar contraseña";
            this.cb_mostrar_pass.UseVisualStyleBackColor = true;
            this.cb_mostrar_pass.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(509, 30);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(31, 29);
            this.materialRaisedButton2.TabIndex = 8;
            this.materialRaisedButton2.Text = "X";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 577);
            this.ControlBox = false;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.cb_mostrar_pass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolsa de trabajo";
            this.Load += new System.EventHandler(this.index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_user;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_pass;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
        private MaterialSkin.Controls.MaterialCheckBox cb_mostrar_pass;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}

