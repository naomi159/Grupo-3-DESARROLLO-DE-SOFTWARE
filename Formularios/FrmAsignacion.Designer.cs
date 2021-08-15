
namespace LibFormularios
{
    partial class FrmAsignacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_CodDocente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPasar2 = new System.Windows.Forms.Button();
            this.lb_Semestre = new System.Windows.Forms.Label();
            this.txt_Semestre = new System.Windows.Forms.TextBox();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerTutores = new System.Windows.Forms.Button();
            this.dgvEstudiantes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dgvTutorias = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CodDocente
            // 
            this.txt_CodDocente.Location = new System.Drawing.Point(174, 21);
            this.txt_CodDocente.Name = "txt_CodDocente";
            this.txt_CodDocente.Size = new System.Drawing.Size(100, 20);
            this.txt_CodDocente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CodDocente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estudiantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estudiantes en tutorias";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(68)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.Location = new System.Drawing.Point(745, 450);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(81, 28);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnPasar2
            // 
            this.btnPasar2.Location = new System.Drawing.Point(407, 237);
            this.btnPasar2.Name = "btnPasar2";
            this.btnPasar2.Size = new System.Drawing.Size(58, 23);
            this.btnPasar2.TabIndex = 3;
            this.btnPasar2.Text = "-->";
            this.btnPasar2.UseVisualStyleBackColor = true;
            this.btnPasar2.Click += new System.EventHandler(this.BtnPasar2_Click_1);
            // 
            // lb_Semestre
            // 
            this.lb_Semestre.AutoSize = true;
            this.lb_Semestre.Location = new System.Drawing.Point(335, 24);
            this.lb_Semestre.Name = "lb_Semestre";
            this.lb_Semestre.Size = new System.Drawing.Size(51, 13);
            this.lb_Semestre.TabIndex = 4;
            this.lb_Semestre.Text = "Semestre";
            // 
            // txt_Semestre
            // 
            this.txt_Semestre.Location = new System.Drawing.Point(407, 21);
            this.txt_Semestre.Name = "txt_Semestre";
            this.txt_Semestre.Size = new System.Drawing.Size(100, 20);
            this.txt_Semestre.TabIndex = 5;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(707, 18);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_Fecha.TabIndex = 6;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(607, 21);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lb_Fecha.TabIndex = 7;
            this.lb_Fecha.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(638, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVerTutores
            // 
            this.btnVerTutores.Location = new System.Drawing.Point(37, 453);
            this.btnVerTutores.Name = "btnVerTutores";
            this.btnVerTutores.Size = new System.Drawing.Size(121, 23);
            this.btnVerTutores.TabIndex = 8;
            this.btnVerTutores.Text = "Ver lista de tutores";
            this.btnVerTutores.UseVisualStyleBackColor = true;
            this.btnVerTutores.Click += new System.EventHandler(this.btnVerTutores_Click);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowCustomTheming = true;
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudiantes.ColumnHeadersHeight = 40;
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.BackColor = System.Drawing.Color.Maroon;
            this.dgvEstudiantes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.Name = null;
            this.dgvEstudiantes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEstudiantes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvEstudiantes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvEstudiantes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstudiantes.EnableHeadersVisualStyles = false;
            this.dgvEstudiantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvEstudiantes.HeaderBackColor = System.Drawing.Color.Maroon;
            this.dgvEstudiantes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEstudiantes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.Location = new System.Drawing.Point(24, 83);
            this.dgvEstudiantes.MultiSelect = false;
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersVisible = false;
            this.dgvEstudiantes.RowTemplate.Height = 40;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(377, 338);
            this.dgvEstudiantes.TabIndex = 23;
            this.dgvEstudiantes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // dgvTutorias
            // 
            this.dgvTutorias.AllowCustomTheming = true;
            this.dgvTutorias.AllowUserToAddRows = false;
            this.dgvTutorias.AllowUserToDeleteRows = false;
            this.dgvTutorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvTutorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTutorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTutorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTutorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTutorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTutorias.ColumnHeadersHeight = 40;
            this.dgvTutorias.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTutorias.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTutorias.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTutorias.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvTutorias.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutorias.CurrentTheme.BackColor = System.Drawing.Color.Maroon;
            this.dgvTutorias.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvTutorias.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvTutorias.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTutorias.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTutorias.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvTutorias.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutorias.CurrentTheme.Name = null;
            this.dgvTutorias.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTutorias.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTutorias.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTutorias.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvTutorias.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutorias.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTutorias.EnableHeadersVisualStyles = false;
            this.dgvTutorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvTutorias.HeaderBackColor = System.Drawing.Color.Maroon;
            this.dgvTutorias.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTutorias.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTutorias.Location = new System.Drawing.Point(471, 83);
            this.dgvTutorias.MultiSelect = false;
            this.dgvTutorias.Name = "dgvTutorias";
            this.dgvTutorias.ReadOnly = true;
            this.dgvTutorias.RowHeadersVisible = false;
            this.dgvTutorias.RowTemplate.Height = 40;
            this.dgvTutorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutorias.Size = new System.Drawing.Size(381, 338);
            this.dgvTutorias.TabIndex = 24;
            this.dgvTutorias.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // FrmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.dgvTutorias);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.btnVerTutores);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.txt_Semestre);
            this.Controls.Add(this.lb_Semestre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnPasar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CodDocente);
            this.Name = "FrmAsignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de tutores";
            this.Load += new System.EventHandler(this.FrmAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_CodDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnPasar2;
        private System.Windows.Forms.Label lb_Semestre;
        private System.Windows.Forms.TextBox txt_Semestre;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerTutores;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEstudiantes;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTutorias;
    }
}

