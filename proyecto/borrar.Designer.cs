
namespace proyecto_ñañi
{
    partial class borrar
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
            this.btn_borrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cb_datos = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_datos
            // 
            this.dg_datos.AllowUserToAddRows = false;
            this.dg_datos.AllowUserToDeleteRows = false;
            this.dg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_datos.Location = new System.Drawing.Point(31, 259);
            this.dg_datos.Name = "dg_datos";
            this.dg_datos.RowHeadersWidth = 51;
            this.dg_datos.RowTemplate.Height = 24;
            this.dg_datos.Size = new System.Drawing.Size(1151, 289);
            this.dg_datos.TabIndex = 1;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(31, 573);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(161, 28);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Volver";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Depth = 0;
            this.btn_borrar.Location = new System.Drawing.Point(372, 216);
            this.btn_borrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Primary = true;
            this.btn_borrar.Size = new System.Drawing.Size(465, 28);
            this.btn_borrar.TabIndex = 5;
            this.btn_borrar.Text = "eliminar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // cb_datos
            // 
            this.cb_datos.FormattingEnabled = true;
            this.cb_datos.Location = new System.Drawing.Point(372, 162);
            this.cb_datos.Name = "cb_datos";
            this.cb_datos.Size = new System.Drawing.Size(465, 24);
            this.cb_datos.TabIndex = 6;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(450, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(322, 29);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Ingrese un valor a eliminar";
            // 
            // borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 648);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cb_datos);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.dg_datos);
            this.Name = "borrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar un registro";
            this.Load += new System.EventHandler(this.borrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_datos;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_borrar;
        private System.Windows.Forms.ComboBox cb_datos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}