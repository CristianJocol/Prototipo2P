
namespace CapaVista
{
    partial class Alumnos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alumnosDatos = new System.Windows.Forms.Button();
            this.dgv_alumnos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 107);
            this.panel1.TabIndex = 1;
            // 
            // btn_alumnosDatos
            // 
            this.btn_alumnosDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btn_alumnosDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btn_alumnosDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alumnosDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumnosDatos.Location = new System.Drawing.Point(345, 212);
            this.btn_alumnosDatos.Name = "btn_alumnosDatos";
            this.btn_alumnosDatos.Size = new System.Drawing.Size(147, 33);
            this.btn_alumnosDatos.TabIndex = 4;
            this.btn_alumnosDatos.Text = "Mostrar datos";
            this.btn_alumnosDatos.UseVisualStyleBackColor = false;
            this.btn_alumnosDatos.Click += new System.EventHandler(this.btn_alumnosDatos_Click);
            // 
            // dgv_alumnos
            // 
            this.dgv_alumnos.AllowUserToAddRows = false;
            this.dgv_alumnos.AllowUserToDeleteRows = false;
            this.dgv_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alumnos.Location = new System.Drawing.Point(108, 251);
            this.dgv_alumnos.Name = "dgv_alumnos";
            this.dgv_alumnos.ReadOnly = true;
            this.dgv_alumnos.Size = new System.Drawing.Size(600, 187);
            this.dgv_alumnos.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CapaVista.Properties.Resources.favicon_16x16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_alumnosDatos);
            this.Controls.Add(this.dgv_alumnos);
            this.Controls.Add(this.panel1);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_alumnosDatos;
        private System.Windows.Forms.DataGridView dgv_alumnos;
    }
}