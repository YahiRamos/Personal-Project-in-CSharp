namespace PRPERSONAL
{
    partial class VIDEOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIDEOS));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnreproducir = new System.Windows.Forms.Button();
            this.btnpausar = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.lblruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTNSALIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1074, 654);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(13, 673);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(167, 46);
            this.btncargar.TabIndex = 1;
            this.btncargar.Text = "CARGAR";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnreproducir
            // 
            this.btnreproducir.Location = new System.Drawing.Point(215, 673);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(167, 46);
            this.btnreproducir.TabIndex = 2;
            this.btnreproducir.Text = "REPRODUCIR";
            this.btnreproducir.UseVisualStyleBackColor = true;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // btnpausar
            // 
            this.btnpausar.Location = new System.Drawing.Point(423, 673);
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.Size = new System.Drawing.Size(167, 46);
            this.btnpausar.TabIndex = 3;
            this.btnpausar.Text = "PAUSAR";
            this.btnpausar.UseVisualStyleBackColor = true;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // btnparar
            // 
            this.btnparar.Location = new System.Drawing.Point(641, 673);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(167, 46);
            this.btnparar.TabIndex = 4;
            this.btnparar.Text = "PARAR";
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblruta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblruta.Location = new System.Drawing.Point(12, 739);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(37, 13);
            this.lblruta.TabIndex = 5;
            this.lblruta.Text = "RUTA";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Location = new System.Drawing.Point(907, 728);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(179, 39);
            this.BTNSALIR.TabIndex = 6;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = true;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // VIDEOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1098, 779);
            this.ControlBox = false;
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnpausar);
            this.Controls.Add(this.btnreproducir);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "VIDEOS";
            this.Text = "VIDEOS";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnreproducir;
        private System.Windows.Forms.Button btnpausar;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BTNSALIR;
    }
}