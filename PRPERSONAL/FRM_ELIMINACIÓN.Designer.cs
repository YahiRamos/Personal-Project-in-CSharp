namespace PRPERSONAL
{
    partial class FRM_ELIMINACIÓN
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Location = new System.Drawing.Point(221, 207);
            this.BTNSALIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(154, 48);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(366, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(227, 15);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(119, 43);
            this.BTNBUSCAR.TabIndex = 9;
            this.BTNBUSCAR.Text = "BUSCAR Y ELIMINAR";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(85, 149);
            this.txtedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(54, 20);
            this.txtedad.TabIndex = 8;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(85, 109);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(179, 20);
            this.txtdireccion.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(85, 67);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(179, 20);
            this.txtnom.TabIndex = 4;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(85, 27);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(54, 20);
            this.txtid.TabIndex = 2;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EDAD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DIRECCIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // FRM_ELIMINACIÓN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 264);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSALIR);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_ELIMINACIÓN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ELIMINACIÓN";
            this.Load += new System.EventHandler(this.FRM_ELIMINACIÓN_Load);
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
    }
}