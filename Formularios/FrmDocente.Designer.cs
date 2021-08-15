namespace LibFormularios
{
    partial class FrmDocente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tbRegimen = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrarEst = new System.Windows.Forms.Button();
            this.DgvDocente = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvDocente);
            this.panel2.Controls.Add(this.tbCodigo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbCarrera);
            this.panel2.Controls.Add(this.tbRegimen);
            this.panel2.Controls.Add(this.tbClase);
            this.panel2.Controls.Add(this.tbCategoria);
            this.panel2.Controls.Add(this.tbAM);
            this.panel2.Controls.Add(this.tbAP);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Size = new System.Drawing.Size(883, 474);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Text = "INFORMACIÓN DOCENTE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFiltrarEst);
            this.panel3.Location = new System.Drawing.Point(0, 523);
            this.panel3.Controls.SetChildIndex(this.btnFiltrarEst, 0);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(363, 0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(155, 28);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(191, 0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(155, 28);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(19, 0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(155, 28);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(535, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(155, 28);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // tbRegimen
            // 
            this.tbRegimen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegimen.Location = new System.Drawing.Point(102, 402);
            this.tbRegimen.Name = "tbRegimen";
            this.tbRegimen.Size = new System.Drawing.Size(135, 27);
            this.tbRegimen.TabIndex = 73;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoria.Location = new System.Drawing.Point(102, 354);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(135, 27);
            this.tbCategoria.TabIndex = 72;
            // 
            // tbAM
            // 
            this.tbAM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAM.Location = new System.Drawing.Point(20, 201);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(217, 27);
            this.tbAM.TabIndex = 67;
            // 
            // tbAP
            // 
            this.tbAP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAP.Location = new System.Drawing.Point(17, 146);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(220, 27);
            this.tbAP.TabIndex = 66;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(17, 90);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(220, 27);
            this.tbNombre.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Regimen :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Categoria :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "A. Materno :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "A. Paterno :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Clase:";
            // 
            // tbClase
            // 
            this.tbClase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClase.Location = new System.Drawing.Point(71, 302);
            this.tbClase.Name = "tbClase";
            this.tbClase.Size = new System.Drawing.Size(166, 27);
            this.tbClase.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Carrera :";
            // 
            // tbCarrera
            // 
            this.tbCarrera.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarrera.Location = new System.Drawing.Point(90, 248);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(147, 27);
            this.tbCarrera.TabIndex = 73;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(17, 33);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(220, 27);
            this.tbCodigo.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Codigo :";
            // 
            // btnFiltrarEst
            // 
            this.btnFiltrarEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(68)))));
            this.btnFiltrarEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarEst.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarEst.Location = new System.Drawing.Point(556, 7);
            this.btnFiltrarEst.Name = "btnFiltrarEst";
            this.btnFiltrarEst.Size = new System.Drawing.Size(105, 28);
            this.btnFiltrarEst.TabIndex = 77;
            this.btnFiltrarEst.Text = "Filtrar";
            this.btnFiltrarEst.UseVisualStyleBackColor = false;
            this.btnFiltrarEst.Click += new System.EventHandler(this.btnFiltrarEst_Click);
            // 
            // DgvDocente
            // 
            this.DgvDocente.AllowCustomTheming = true;
            this.DgvDocente.AllowUserToAddRows = false;
            this.DgvDocente.AllowUserToDeleteRows = false;
            this.DgvDocente.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDocente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDocente.ColumnHeadersHeight = 40;
            this.DgvDocente.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDocente.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDocente.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvDocente.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DgvDocente.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgvDocente.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DgvDocente.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.DgvDocente.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DgvDocente.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DgvDocente.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvDocente.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DgvDocente.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgvDocente.CurrentTheme.Name = null;
            this.DgvDocente.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDocente.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.DgvDocente.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvDocente.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DgvDocente.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDocente.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDocente.EnableHeadersVisualStyles = false;
            this.DgvDocente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.DgvDocente.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.DgvDocente.HeaderBgColor = System.Drawing.Color.Empty;
            this.DgvDocente.HeaderForeColor = System.Drawing.Color.White;
            this.DgvDocente.Location = new System.Drawing.Point(259, 16);
            this.DgvDocente.MultiSelect = false;
            this.DgvDocente.Name = "DgvDocente";
            this.DgvDocente.ReadOnly = true;
            this.DgvDocente.RowHeadersVisible = false;
            this.DgvDocente.RowTemplate.Height = 40;
            this.DgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDocente.Size = new System.Drawing.Size(603, 434);
            this.DgvDocente.TabIndex = 76;
            this.DgvDocente.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(883, 567);
            this.Name = "FrmDocente";
            this.Text = "FrmDocente";
            this.Load += new System.EventHandler(this.FrmDocente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox tbRegimen;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrarEst;
        public Bunifu.UI.WinForms.BunifuDataGridView DgvDocente;
    }
}