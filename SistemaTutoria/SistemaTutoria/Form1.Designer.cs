﻿
namespace SistemaTutoria
{
    partial class Crud
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
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuAlumnos = new System.Windows.Forms.Button();
            this.btnMenuTutores = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.panelMenuBar.Controls.Add(this.panel1);
            this.panelMenuBar.Controls.Add(this.label4);
            this.panelMenuBar.Controls.Add(this.pictureBox1);
            this.panelMenuBar.Controls.Add(this.btnMenuAlumnos);
            this.panelMenuBar.Controls.Add(this.btnMenuTutores);
            this.panelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(200, 700);
            this.panelMenuBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(74, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 1);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "UNSAAC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.pictureBox1.BackgroundImage = global::SistemaTutoria.Properties.Resources.logosmall;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuAlumnos
            // 
            this.btnMenuAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMenuAlumnos.FlatAppearance.BorderSize = 0;
            this.btnMenuAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMenuAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMenuAlumnos.Image = global::SistemaTutoria.Properties.Resources.icons8_colegial_en_un_escritorio_32;
            this.btnMenuAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAlumnos.Location = new System.Drawing.Point(0, 220);
            this.btnMenuAlumnos.Name = "btnMenuAlumnos";
            this.btnMenuAlumnos.Size = new System.Drawing.Size(200, 40);
            this.btnMenuAlumnos.TabIndex = 0;
            this.btnMenuAlumnos.Text = "     Alumnos";
            this.btnMenuAlumnos.UseVisualStyleBackColor = true;
            this.btnMenuAlumnos.Click += new System.EventHandler(this.btnMenuAlumnos_Click);
            // 
            // btnMenuTutores
            // 
            this.btnMenuTutores.FlatAppearance.BorderSize = 0;
            this.btnMenuTutores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMenuTutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMenuTutores.Image = global::SistemaTutoria.Properties.Resources.icons8_profesor_32;
            this.btnMenuTutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTutores.Location = new System.Drawing.Point(0, 180);
            this.btnMenuTutores.Name = "btnMenuTutores";
            this.btnMenuTutores.Size = new System.Drawing.Size(200, 40);
            this.btnMenuTutores.TabIndex = 0;
            this.btnMenuTutores.Text = "    Tutores";
            this.btnMenuTutores.UseVisualStyleBackColor = true;
            this.btnMenuTutores.Click += new System.EventHandler(this.btnMenuTutores_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(230, 50);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(940, 620);
            this.panel.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(195)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::SistemaTutoria.Properties.Resources.icons8_macos_minimizar_31;
            this.btnMinimize.Location = new System.Drawing.Point(1120, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::SistemaTutoria.Properties.Resources.icons8_macos_cerrar_31;
            this.btnClose.Location = new System.Drawing.Point(1155, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 650);
            this.panel2.TabIndex = 3;
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Crud";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "miapp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Crud_MouseDown);
            this.panelMenuBar.ResumeLayout(false);
            this.panelMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.Button btnMenuTutores;
        private System.Windows.Forms.Button btnMenuAlumnos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

