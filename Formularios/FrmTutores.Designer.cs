
namespace LibFormularios
{
    partial class FrmTutores
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
            this.lb_Semestre = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvTutores = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Semestre
            // 
            this.lb_Semestre.AutoSize = true;
            this.lb_Semestre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Semestre.ForeColor = System.Drawing.Color.Maroon;
            this.lb_Semestre.Location = new System.Drawing.Point(13, 9);
            this.lb_Semestre.Name = "lb_Semestre";
            this.lb_Semestre.Size = new System.Drawing.Size(143, 25);
            this.lb_Semestre.TabIndex = 78;
            this.lb_Semestre.Text = "Lista de tutores";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(736, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 30);
            this.btnCerrar.TabIndex = 79;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowCustomTheming = true;
            this.dgvTutores.AllowUserToAddRows = false;
            this.dgvTutores.AllowUserToDeleteRows = false;
            this.dgvTutores.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvTutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTutores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTutores.ColumnHeadersHeight = 40;
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.BackColor = System.Drawing.Color.Maroon;
            this.dgvTutores.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvTutores.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvTutores.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTutores.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvTutores.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.Name = null;
            this.dgvTutores.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTutores.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTutores.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTutores.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvTutores.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvTutores.HeaderBackColor = System.Drawing.Color.Maroon;
            this.dgvTutores.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTutores.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTutores.Location = new System.Drawing.Point(18, 50);
            this.dgvTutores.MultiSelect = false;
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            this.dgvTutores.RowHeadersVisible = false;
            this.dgvTutores.RowTemplate.Height = 40;
            this.dgvTutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutores.Size = new System.Drawing.Size(830, 415);
            this.dgvTutores.TabIndex = 80;
            this.dgvTutores.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // FrmTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(869, 486);
            this.Controls.Add(this.dgvTutores);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lb_Semestre);
            this.Name = "FrmTutores";
            this.Text = "FrmTutores";
            this.Load += new System.EventHandler(this.FrmTutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Semestre;
        private System.Windows.Forms.Button btnCerrar;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTutores;
    }
}