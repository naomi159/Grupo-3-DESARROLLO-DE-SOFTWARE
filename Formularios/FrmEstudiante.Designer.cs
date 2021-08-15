
namespace LibFormularios
{
    partial class FrmEstudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.btnFiltrarEst = new System.Windows.Forms.Button();
            this.dgvEstudiante = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvEstudiante);
            this.panel2.Controls.Add(this.cbCondicion);
            this.panel2.Controls.Add(this.lblNombres);
            this.panel2.Controls.Add(this.lblCondicion);
            this.panel2.Controls.Add(this.lblCarrera);
            this.panel2.Controls.Add(this.lblAM);
            this.panel2.Controls.Add(this.lblAP);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.tbCarrera);
            this.panel2.Controls.Add(this.tbAM);
            this.panel2.Controls.Add(this.tbAP);
            this.panel2.Controls.Add(this.tbNombres);
            this.panel2.Controls.Add(this.tbCodigo);
            this.panel2.Size = new System.Drawing.Size(883, 474);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Text = "INFORMACIÓN ESTUDIANTE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.btnFiltrarEst);
            this.panel3.Location = new System.Drawing.Point(0, 523);
            this.panel3.Controls.SetChildIndex(this.btnFiltrarEst, 0);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(18, 40);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(226, 27);
            this.tbCodigo.TabIndex = 0;
            // 
            // tbNombres
            // 
            this.tbNombres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombres.Location = new System.Drawing.Point(18, 103);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(226, 27);
            this.tbNombres.TabIndex = 0;
            // 
            // tbAP
            // 
            this.tbAP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAP.Location = new System.Drawing.Point(20, 168);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(224, 27);
            this.tbAP.TabIndex = 0;
            // 
            // tbAM
            // 
            this.tbAM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAM.Location = new System.Drawing.Point(20, 235);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(224, 27);
            this.tbAM.TabIndex = 0;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarrera.Location = new System.Drawing.Point(20, 306);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(224, 27);
            this.tbCarrera.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAP.Location = new System.Drawing.Point(16, 143);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(132, 20);
            this.lblAP.TabIndex = 1;
            this.lblAP.Text = "Apellido paterno: ";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(17, 79);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(76, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAM.Location = new System.Drawing.Point(16, 207);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(132, 20);
            this.lblAM.TabIndex = 1;
            this.lblAM.Text = "Apellido materno:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(15, 278);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(145, 20);
            this.lblCarrera.TabIndex = 1;
            this.lblCarrera.Text = "Carrera profesional:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicion.Location = new System.Drawing.Point(17, 344);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(82, 20);
            this.lblCondicion.TabIndex = 1;
            this.lblCondicion.Text = "Condición:";
            // 
            // cbCondicion
            // 
            this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Items.AddRange(new object[] {
            "Normal",
            "En riesgo"});
            this.cbCondicion.Location = new System.Drawing.Point(20, 370);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(224, 28);
            this.cbCondicion.TabIndex = 3;
            // 
            // btnFiltrarEst
            // 
            this.btnFiltrarEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(68)))));
            this.btnFiltrarEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarEst.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarEst.Location = new System.Drawing.Point(557, 6);
            this.btnFiltrarEst.Name = "btnFiltrarEst";
            this.btnFiltrarEst.Size = new System.Drawing.Size(105, 28);
            this.btnFiltrarEst.TabIndex = 17;
            this.btnFiltrarEst.Text = "Filtrar";
            this.btnFiltrarEst.UseVisualStyleBackColor = false;
            this.btnFiltrarEst.Click += new System.EventHandler(this.btnFiltrarEst_Click);
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AllowCustomTheming = true;
            this.dgvEstudiante.AllowUserToAddRows = false;
            this.dgvEstudiante.AllowUserToDeleteRows = false;
            this.dgvEstudiante.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstudiante.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudiante.ColumnHeadersHeight = 40;
            this.dgvEstudiante.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEstudiante.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEstudiante.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiante.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvEstudiante.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstudiante.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEstudiante.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvEstudiante.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEstudiante.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEstudiante.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiante.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dgvEstudiante.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstudiante.CurrentTheme.Name = null;
            this.dgvEstudiante.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstudiante.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvEstudiante.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiante.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvEstudiante.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudiante.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstudiante.EnableHeadersVisualStyles = false;
            this.dgvEstudiante.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvEstudiante.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEstudiante.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEstudiante.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEstudiante.Location = new System.Drawing.Point(264, 22);
            this.dgvEstudiante.MultiSelect = false;
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersVisible = false;
            this.dgvEstudiante.RowTemplate.Height = 40;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(603, 434);
            this.dgvEstudiante.TabIndex = 23;
            this.dgvEstudiante.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 567);
            this.Name = "FrmEstudiante";
            this.Text = "Formulario estudiante";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Button btnFiltrarEst;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvEstudiante;
    }
}