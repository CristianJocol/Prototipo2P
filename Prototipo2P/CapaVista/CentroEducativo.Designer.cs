
namespace CapaVista
{
    partial class CentroEducativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentroEducativo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_docentes = new System.Windows.Forms.Button();
            this.btn_Alumnos = new System.Windows.Forms.Button();
            this.Fondo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 516);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.btn_docentes);
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 82);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.btn_Alumnos);
            this.panel3.Location = new System.Drawing.Point(6, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 79);
            this.panel3.TabIndex = 1;
            // 
            // btn_docentes
            // 
            this.btn_docentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_docentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docentes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docentes.ForeColor = System.Drawing.Color.White;
            this.btn_docentes.Location = new System.Drawing.Point(3, 3);
            this.btn_docentes.Name = "btn_docentes";
            this.btn_docentes.Size = new System.Drawing.Size(313, 76);
            this.btn_docentes.TabIndex = 0;
            this.btn_docentes.Text = "Docentes";
            this.btn_docentes.UseVisualStyleBackColor = false;
            this.btn_docentes.Click += new System.EventHandler(this.btn_docentes_Click);
            // 
            // btn_Alumnos
            // 
            this.btn_Alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alumnos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alumnos.ForeColor = System.Drawing.Color.White;
            this.btn_Alumnos.Location = new System.Drawing.Point(3, 3);
            this.btn_Alumnos.Name = "btn_Alumnos";
            this.btn_Alumnos.Size = new System.Drawing.Size(313, 73);
            this.btn_Alumnos.TabIndex = 0;
            this.btn_Alumnos.Text = "Alumnos";
            this.btn_Alumnos.UseVisualStyleBackColor = false;
            this.btn_Alumnos.Click += new System.EventHandler(this.btn_Alumnos_Click);
            // 
            // Fondo
            // 
            this.Fondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.Fondo.Image = ((System.Drawing.Image)(resources.GetObject("Fondo.Image")));
            this.Fondo.InitialImage = null;
            this.Fondo.Location = new System.Drawing.Point(363, 20);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(500, 508);
            this.Fondo.TabIndex = 3;
            this.Fondo.TabStop = false;
            // 
            // CentroEducativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(885, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fondo);
            this.Name = "CentroEducativo";
            this.Text = "CentroEducativo-Cristian Jocol-09011917747";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Fondo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Alumnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_docentes;
    }
}