
namespace LibFormularios
{
    partial class FrmFiltroEstudiante
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
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCondicion
            // 
            this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Items.AddRange(new object[] {
            "Normal",
            "En riesgo"});
            this.cbCondicion.Location = new System.Drawing.Point(118, 145);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(100, 21);
            this.cbCondicion.TabIndex = 15;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(14, 41);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 9;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(14, 145);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(57, 13);
            this.lblCondicion.TabIndex = 10;
            this.lblCondicion.Text = "Condición:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(14, 119);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(98, 13);
            this.lblCarrera.TabIndex = 11;
            this.lblCarrera.Text = "Carrera profesional:";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Location = new System.Drawing.Point(14, 93);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(88, 13);
            this.lblAM.TabIndex = 12;
            this.lblAM.Text = "Apellido materno:";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(14, 64);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(89, 13);
            this.lblAP.TabIndex = 13;
            this.lblAP.Text = "Apellido paterno: ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Codigo:";
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(118, 116);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(100, 20);
            this.tbCarrera.TabIndex = 4;
            // 
            // tbAM
            // 
            this.tbAM.Location = new System.Drawing.Point(118, 90);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(100, 20);
            this.tbAM.TabIndex = 5;
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(118, 64);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(100, 20);
            this.tbAP.TabIndex = 6;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(118, 38);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(100, 20);
            this.tbNombres.TabIndex = 7;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(118, 12);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(138, 189);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 93;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(27, 189);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 92;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmFiltroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 238);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbCondicion);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblAM);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.tbCarrera);
            this.Controls.Add(this.tbAM);
            this.Controls.Add(this.tbAP);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.tbCodigo);
            this.Name = "FrmFiltroEstudiante";
            this.Text = "FrmFiltroEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}