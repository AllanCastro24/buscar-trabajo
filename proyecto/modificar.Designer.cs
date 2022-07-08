
namespace proyecto_ñañi
{
    partial class modificar
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
            this.dg_datos = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cb_datos = new System.Windows.Forms.ComboBox();
            this.btn_cargar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cb_tiempo = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_edad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cb_estudio = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_datos
            // 
            this.dg_datos.AllowUserToAddRows = false;
            this.dg_datos.AllowUserToDeleteRows = false;
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Location = new System.Drawing.Point(31, 427);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.RowHeadersWidth = 51;
            this.dg_datos.RowTemplate.Height = 24;
            this.dg_datos.Size = new System.Drawing.Size(1163, 164);
            this.dg_datos.TabIndex = 0;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(31, 608);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(161, 28);
            this.materialRaisedButton1.TabIndex = 3;
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
            this.materialLabel1.Location = new System.Drawing.Point(450, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(250, 24);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Seleccione valor a modificar";
            // 
            // cb_datos
            // 
            this.cb_datos.FormattingEnabled = true;
            this.cb_datos.Location = new System.Drawing.Point(343, 138);
            this.cb_datos.Name = "cb_datos";
            this.cb_datos.Size = new System.Drawing.Size(465, 24);
            this.cb_datos.TabIndex = 9;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Depth = 0;
            this.btn_cargar.Location = new System.Drawing.Point(814, 135);
            this.btn_cargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Primary = true;
            this.btn_cargar.Size = new System.Drawing.Size(124, 28);
            this.btn_cargar.TabIndex = 10;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(868, 208);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(66, 24);
            this.materialLabel6.TabIndex = 24;
            this.materialLabel6.Text = "Correo";
            // 
            // txt_correo
            // 
            this.txt_correo.Depth = 0;
            this.txt_correo.Hint = "";
            this.txt_correo.Location = new System.Drawing.Point(867, 243);
            this.txt_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.SelectedText = "";
            this.txt_correo.SelectionLength = 0;
            this.txt_correo.SelectionStart = 0;
            this.txt_correo.Size = new System.Drawing.Size(327, 28);
            this.txt_correo.TabIndex = 23;
            this.txt_correo.UseSystemPasswordChar = false;
            // 
            // cb_tiempo
            // 
            this.cb_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tiempo.FormattingEnabled = true;
            this.cb_tiempo.Items.AddRange(new object[] {
            "Medio",
            "Completo"});
            this.cb_tiempo.Location = new System.Drawing.Point(456, 312);
            this.cb_tiempo.Name = "cb_tiempo";
            this.cb_tiempo.Size = new System.Drawing.Size(327, 28);
            this.cb_tiempo.TabIndex = 22;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(457, 285);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 24);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Tiempo";
            // 
            // txt_edad
            // 
            this.txt_edad.Depth = 0;
            this.txt_edad.Hint = "";
            this.txt_edad.Location = new System.Drawing.Point(456, 243);
            this.txt_edad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.PasswordChar = '\0';
            this.txt_edad.SelectedText = "";
            this.txt_edad.SelectionLength = 0;
            this.txt_edad.SelectionStart = 0;
            this.txt_edad.Size = new System.Drawing.Size(327, 28);
            this.txt_edad.TabIndex = 20;
            this.txt_edad.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(452, 216);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(53, 24);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Edad";
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
            this.cb_estudio.Location = new System.Drawing.Point(24, 312);
            this.cb_estudio.Name = "cb_estudio";
            this.cb_estudio.Size = new System.Drawing.Size(327, 28);
            this.cb_estudio.TabIndex = 18;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 285);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(110, 24);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Escolaridad";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 208);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(255, 30);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Nombre de la empresa";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Hint = "";
            this.txt_nombre.Location = new System.Drawing.Point(24, 243);
            this.txt_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.Size = new System.Drawing.Size(327, 28);
            this.txt_nombre.TabIndex = 15;
            this.txt_nombre.UseSystemPasswordChar = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.Location = new System.Drawing.Point(499, 380);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Primary = true;
            this.btn_actualizar.Size = new System.Drawing.Size(224, 28);
            this.btn_actualizar.TabIndex = 25;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 648);
            this.ControlBox = false;
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.cb_tiempo);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.cb_estudio);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.cb_datos);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.dg_datos);
            this.Name = "modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar un registro";
            this.Load += new System.EventHandler(this.modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_datos;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cb_datos;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cargar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_correo;
        private System.Windows.Forms.ComboBox cb_tiempo;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_edad;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cb_estudio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombre;
        private MaterialSkin.Controls.MaterialRaisedButton btn_actualizar;
    }
}