
namespace proyecto_ñañi
{
    partial class insertar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cb_tiempo = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cb_estudio = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_limpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_edad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_agregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 534);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(161, 28);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Volver";
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
            this.materialLabel1.Location = new System.Drawing.Point(128, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Empresa";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Hint = "";
            this.txt_nombre.Location = new System.Drawing.Point(132, 127);
            this.txt_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.Size = new System.Drawing.Size(278, 28);
            this.txt_nombre.TabIndex = 4;
            this.txt_nombre.UseSystemPasswordChar = false;
            // 
            // txt_correo
            // 
            this.txt_correo.Depth = 0;
            this.txt_correo.Hint = "";
            this.txt_correo.Location = new System.Drawing.Point(132, 215);
            this.txt_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.Size = new System.Drawing.Size(278, 28);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(128, 173);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(165, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Correo electronico";
            // 
            // cb_tiempo
            // 
            this.cb_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tiempo.FormattingEnabled = true;
            this.cb_tiempo.Items.AddRange(new object[] {
            "Medio",
            "Completo"});
            this.cb_tiempo.Location = new System.Drawing.Point(132, 283);
            this.cb_tiempo.Name = "cb_tiempo";
            this.cb_tiempo.Size = new System.Drawing.Size(278, 28);
            this.cb_tiempo.TabIndex = 16;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(133, 256);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Tiempo";
            // 
            // cb_estudio
            // 
            this.cb_estudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estudio.FormattingEnabled = true;
            this.cb_estudio.Items.AddRange(new object[] {
            "Nula",
            "Primaria",
            "Secundaria",
            "Preparatoria",
            "Universidad",
            "Licenciatura"});
            this.cb_estudio.Location = new System.Drawing.Point(132, 415);
            this.cb_estudio.Name = "cb_estudio";
            this.cb_estudio.Size = new System.Drawing.Size(278, 28);
            this.cb_estudio.TabIndex = 14;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(133, 388);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(110, 24);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Escolaridad";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Depth = 0;
            this.btn_limpiar.Location = new System.Drawing.Point(398, 534);
            this.btn_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Primary = true;
            this.btn_limpiar.Size = new System.Drawing.Size(161, 28);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txt_edad
            // 
            this.txt_edad.Depth = 0;
            this.txt_edad.Hint = "";
            this.txt_edad.Location = new System.Drawing.Point(132, 357);
            this.txt_edad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.PasswordChar = '\0';
            this.txt_edad.SelectedText = "";
            this.txt_edad.SelectionLength = 0;
            this.txt_edad.SelectionStart = 0;
            this.txt_edad.Size = new System.Drawing.Size(278, 28);
            this.txt_edad.TabIndex = 19;
            this.txt_edad.UseSystemPasswordChar = false;
            this.txt_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edad_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(128, 330);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(53, 24);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Edad";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Depth = 0;
            this.btn_agregar.Location = new System.Drawing.Point(132, 464);
            this.btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Primary = true;
            this.btn_agregar.Size = new System.Drawing.Size(278, 45);
            this.btn_agregar.TabIndex = 20;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 574);
            this.ControlBox = false;
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cb_tiempo);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.cb_estudio);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "insertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertar propuestas de trabajo";
            this.Load += new System.EventHandler(this.insertar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cb_tiempo;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox cb_estudio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btn_limpiar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_edad;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btn_agregar;
    }
}