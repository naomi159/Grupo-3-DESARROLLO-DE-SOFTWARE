
namespace Formularios
{
    partial class frmListaTutorias
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
            this.lblTituloFormTurorias = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormTurorias
            // 
            this.lblTituloFormTurorias.AutoSize = true;
            this.lblTituloFormTurorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormTurorias.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloFormTurorias.Location = new System.Drawing.Point(23, 58);
            this.lblTituloFormTurorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloFormTurorias.Name = "lblTituloFormTurorias";
            this.lblTituloFormTurorias.Size = new System.Drawing.Size(241, 26);
            this.lblTituloFormTurorias.TabIndex = 1;
            this.lblTituloFormTurorias.Text = "LISTA DE TUTORÍAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(28, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 258);
            this.dataGridView1.TabIndex = 2;
            // 
            // btGuardar
            // 
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btGuardar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btGuardar.Location = new System.Drawing.Point(28, 445);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(124, 27);
            this.btGuardar.TabIndex = 17;
            this.btGuardar.Text = "Ver";
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btCerrar.Location = new System.Drawing.Point(317, 445);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(124, 27);
            this.btCerrar.TabIndex = 18;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBuscar.Location = new System.Drawing.Point(298, 111);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(118, 21);
            this.tbBuscar.TabIndex = 19;
            this.tbBuscar.Text = "Buscar...";
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = global::Formularios.Properties.Resources.loupe;
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.Location = new System.Drawing.Point(414, 111);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(27, 22);
            this.btBuscar.TabIndex = 20;
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // frmListaTutorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 497);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTituloFormTurorias);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListaTutorias";
            this.Text = "frmListaTutorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloFormTurorias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBuscar;
    }
}