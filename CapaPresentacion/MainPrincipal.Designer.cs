
namespace CapaPresentacion
{
    partial class MainPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSitioDeInteres = new System.Windows.Forms.Button();
            this.btnCiudad = new System.Windows.Forms.Button();
            this.btnSector = new System.Windows.Forms.Button();
            this.btnPropietario = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSitioDeInteres);
            this.panel1.Controls.Add(this.btnCiudad);
            this.panel1.Controls.Add(this.btnSector);
            this.panel1.Controls.Add(this.btnPropietario);
            this.panel1.Controls.Add(this.btnCita);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnBanco);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 514);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSitioDeInteres
            // 
            this.btnSitioDeInteres.Location = new System.Drawing.Point(482, 409);
            this.btnSitioDeInteres.Name = "btnSitioDeInteres";
            this.btnSitioDeInteres.Size = new System.Drawing.Size(217, 76);
            this.btnSitioDeInteres.TabIndex = 10;
            this.btnSitioDeInteres.Text = "SITIOS DE INTERES";
            this.btnSitioDeInteres.UseVisualStyleBackColor = true;
            this.btnSitioDeInteres.Click += new System.EventHandler(this.btnSitioDeInteres_Click);
            // 
            // btnCiudad
            // 
            this.btnCiudad.Location = new System.Drawing.Point(139, 409);
            this.btnCiudad.Name = "btnCiudad";
            this.btnCiudad.Size = new System.Drawing.Size(217, 76);
            this.btnCiudad.TabIndex = 9;
            this.btnCiudad.Text = "CIUDAD";
            this.btnCiudad.UseVisualStyleBackColor = true;
            this.btnCiudad.Click += new System.EventHandler(this.btnCiudad_Click);
            // 
            // btnSector
            // 
            this.btnSector.Location = new System.Drawing.Point(482, 311);
            this.btnSector.Name = "btnSector";
            this.btnSector.Size = new System.Drawing.Size(217, 76);
            this.btnSector.TabIndex = 8;
            this.btnSector.Text = "SECTOR";
            this.btnSector.UseVisualStyleBackColor = true;
            this.btnSector.Click += new System.EventHandler(this.btnSector_Click);
            // 
            // btnPropietario
            // 
            this.btnPropietario.Location = new System.Drawing.Point(139, 311);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(217, 76);
            this.btnPropietario.TabIndex = 7;
            this.btnPropietario.Text = "PROPIETARIO";
            this.btnPropietario.UseVisualStyleBackColor = true;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            // 
            // btnCita
            // 
            this.btnCita.Location = new System.Drawing.Point(482, 206);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(217, 76);
            this.btnCita.TabIndex = 6;
            this.btnCita.Text = "CITA";
            this.btnCita.UseVisualStyleBackColor = true;
            this.btnCita.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(482, 106);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(217, 76);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "USUARIO";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 76);
            this.button4.TabIndex = 4;
            this.button4.Text = "CLIENTE ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBanco
            // 
            this.btnBanco.Location = new System.Drawing.Point(139, 206);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(217, 76);
            this.btnBanco.TabIndex = 1;
            this.btnBanco.Text = "BANCO";
            this.btnBanco.UseVisualStyleBackColor = true;
            this.btnBanco.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(264, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ PRINCIPAL";
            // 
            // MainPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 512);
            this.Controls.Add(this.panel1);
            this.Name = "MainPrincipal";
            this.Text = "Menú Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPropietario;
        private System.Windows.Forms.Button btnSector;
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnSitioDeInteres;
        private System.Windows.Forms.Button btnCiudad;
    }
}

