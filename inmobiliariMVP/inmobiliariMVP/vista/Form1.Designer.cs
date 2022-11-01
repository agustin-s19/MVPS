namespace inmobiliariMVP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tipoPiso = new System.Windows.Forms.RadioButton();
            this.tipoLocal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viejoTxt = new System.Windows.Forms.RadioButton();
            this.nuevoTxt = new System.Windows.Forms.RadioButton();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.metrosTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPiso = new System.Windows.Forms.TextBox();
            this.cantVentanas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.finalPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoPiso
            // 
            this.tipoPiso.AutoSize = true;
            this.tipoPiso.Location = new System.Drawing.Point(40, 32);
            this.tipoPiso.Name = "tipoPiso";
            this.tipoPiso.Size = new System.Drawing.Size(47, 19);
            this.tipoPiso.TabIndex = 0;
            this.tipoPiso.TabStop = true;
            this.tipoPiso.Text = "Piso";
            this.tipoPiso.UseVisualStyleBackColor = true;
            this.tipoPiso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tipoLocal
            // 
            this.tipoLocal.AutoSize = true;
            this.tipoLocal.Location = new System.Drawing.Point(40, 57);
            this.tipoLocal.Name = "tipoLocal";
            this.tipoLocal.Size = new System.Drawing.Size(53, 19);
            this.tipoLocal.TabIndex = 1;
            this.tipoLocal.TabStop = true;
            this.tipoLocal.Text = "Local";
            this.tipoLocal.UseVisualStyleBackColor = true;
            this.tipoLocal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoPiso);
            this.groupBox1.Controls.Add(this.tipoLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "COTIZADOR DE INMUEBLES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viejoTxt);
            this.groupBox2.Controls.Add(this.nuevoTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // viejoTxt
            // 
            this.viejoTxt.AutoSize = true;
            this.viejoTxt.Location = new System.Drawing.Point(40, 62);
            this.viejoTxt.Name = "viejoTxt";
            this.viejoTxt.Size = new System.Drawing.Size(105, 19);
            this.viejoTxt.TabIndex = 6;
            this.viejoTxt.TabStop = true;
            this.viejoTxt.Text = "Segunda Mano";
            this.viejoTxt.UseVisualStyleBackColor = true;
            this.viejoTxt.CheckedChanged += new System.EventHandler(this.viejoTxt_CheckedChanged);
            // 
            // nuevoTxt
            // 
            this.nuevoTxt.AutoSize = true;
            this.nuevoTxt.Location = new System.Drawing.Point(40, 37);
            this.nuevoTxt.Name = "nuevoTxt";
            this.nuevoTxt.Size = new System.Drawing.Size(60, 19);
            this.nuevoTxt.TabIndex = 5;
            this.nuevoTxt.TabStop = true;
            this.nuevoTxt.Text = "Nuevo";
            this.nuevoTxt.UseVisualStyleBackColor = true;
            this.nuevoTxt.CheckedChanged += new System.EventHandler(this.nuevoTxt_CheckedChanged);
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(297, 80);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(178, 23);
            this.direccionTxt.TabIndex = 5;
            // 
            // metrosTxt
            // 
            this.metrosTxt.Location = new System.Drawing.Point(297, 145);
            this.metrosTxt.Name = "metrosTxt";
            this.metrosTxt.Size = new System.Drawing.Size(178, 23);
            this.metrosTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero mt2";
            // 
            // numPiso
            // 
            this.numPiso.Enabled = false;
            this.numPiso.Location = new System.Drawing.Point(297, 213);
            this.numPiso.Name = "numPiso";
            this.numPiso.Size = new System.Drawing.Size(178, 23);
            this.numPiso.TabIndex = 9;
            // 
            // cantVentanas
            // 
            this.cantVentanas.Enabled = false;
            this.cantVentanas.Location = new System.Drawing.Point(298, 278);
            this.cantVentanas.Name = "cantVentanas";
            this.cantVentanas.Size = new System.Drawing.Size(178, 23);
            this.cantVentanas.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero de Piso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad de ventanas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Resultado de la cotizacion:";
            // 
            // finalPrice
            // 
            this.finalPrice.AutoSize = true;
            this.finalPrice.Location = new System.Drawing.Point(207, 369);
            this.finalPrice.Name = "finalPrice";
            this.finalPrice.Size = new System.Drawing.Size(38, 15);
            this.finalPrice.TabIndex = 14;
            this.finalPrice.Text = "label7";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(343, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantVentanas);
            this.Controls.Add(this.numPiso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metrosTxt);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "COTIZADOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton tipoPiso;
        private RadioButton tipoLocal;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton viejoTxt;
        private RadioButton nuevoTxt;
        private TextBox direccionTxt;
        private TextBox metrosTxt;
        private Label label2;
        private Label label3;
        private TextBox numPiso;
        private TextBox cantVentanas;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label finalPrice;
        private Button button1;
    }
}