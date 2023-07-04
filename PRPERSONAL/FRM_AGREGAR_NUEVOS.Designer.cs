namespace PRPERSONAL
{
    partial class FRM_AGREGAR_NUEVOS
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
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Location = new System.Drawing.Point(274, 264);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(227, 66);
            this.BTNSALIR.TabIndex = 11;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = true;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNBUSCAR);
            this.groupBox1.Controls.Add(this.txtedad);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(261, 27);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(159, 35);
            this.BTNBUSCAR.TabIndex = 9;
            this.BTNBUSCAR.Text = "BUSCAR";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(113, 183);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(70, 22);
            this.txtedad.TabIndex = 8;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(113, 134);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(237, 22);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(113, 82);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(237, 22);
            this.txtnom.TabIndex = 4;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(113, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(70, 22);
            this.txtid.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "EDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "DIRECCIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(13, 265);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(227, 66);
            this.BTNGUARDAR.TabIndex = 10;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // FRM_AGREGAR_NUEVOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 345);
            this.ControlBox = false;
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSALIR);
            this.Name = "FRM_AGREGAR_NUEVOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AGREGAR_NUEVOS";
            this.Load += new System.EventHandler(this.FRM_AGREGAR_NUEVOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNGUARDAR;
    }
}