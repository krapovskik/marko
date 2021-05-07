
namespace vezhba2
{
    partial class Form1
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
            this.lbProdukti = new System.Windows.Forms.ListBox();
            this.lbKoshnicha = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.btnDodadiKosnica = new System.Windows.Forms.Button();
            this.btnIzbrishiKosnica = new System.Windows.Forms.Button();
            this.btnDodadiProdukt = new System.Windows.Forms.Button();
            this.btnIzbrishiProdukt = new System.Windows.Forms.Button();
            this.btnIzprazniLista = new System.Windows.Forms.Button();
            this.btnIzprazniKoshnica = new System.Windows.Forms.Button();
            this.nudKolichina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolichina)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdukti
            // 
            this.lbProdukti.FormattingEnabled = true;
            this.lbProdukti.ItemHeight = 16;
            this.lbProdukti.Location = new System.Drawing.Point(12, 23);
            this.lbProdukti.Name = "lbProdukti";
            this.lbProdukti.Size = new System.Drawing.Size(242, 356);
            this.lbProdukti.TabIndex = 0;
            this.lbProdukti.SelectedIndexChanged += new System.EventHandler(this.lbProdukti_SelectedIndexChanged);
            // 
            // lbKoshnicha
            // 
            this.lbKoshnicha.FormattingEnabled = true;
            this.lbKoshnicha.ItemHeight = 16;
            this.lbKoshnicha.Location = new System.Drawing.Point(524, 23);
            this.lbKoshnicha.Name = "lbKoshnicha";
            this.lbKoshnicha.Size = new System.Drawing.Size(264, 324);
            this.lbKoshnicha.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtKategorija);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(260, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detali na produkt";
            // 
            // txtIme
            // 
            this.txtIme.Enabled = false;
            this.txtIme.Location = new System.Drawing.Point(6, 49);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(246, 22);
            this.txtIme.TabIndex = 0;
            // 
            // txtKategorija
            // 
            this.txtKategorija.Enabled = false;
            this.txtKategorija.Location = new System.Drawing.Point(7, 107);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(245, 22);
            this.txtKategorija.TabIndex = 1;
            // 
            // txtCena
            // 
            this.txtCena.Enabled = false;
            this.txtCena.Location = new System.Drawing.Point(6, 172);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(135, 22);
            this.txtCena.TabIndex = 2;
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista produkti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Koshnica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vkupno:";
            // 
            // txtVkupno
            // 
            this.txtVkupno.Enabled = false;
            this.txtVkupno.Location = new System.Drawing.Point(589, 357);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.Size = new System.Drawing.Size(199, 22);
            this.txtVkupno.TabIndex = 6;
            // 
            // btnDodadiKosnica
            // 
            this.btnDodadiKosnica.Location = new System.Drawing.Point(261, 242);
            this.btnDodadiKosnica.Name = "btnDodadiKosnica";
            this.btnDodadiKosnica.Size = new System.Drawing.Size(162, 26);
            this.btnDodadiKosnica.TabIndex = 9;
            this.btnDodadiKosnica.Text = "Dodadi vo koshnica>>";
            this.btnDodadiKosnica.UseVisualStyleBackColor = true;
            this.btnDodadiKosnica.Click += new System.EventHandler(this.btnDodadiKosnica_Click);
            // 
            // btnIzbrishiKosnica
            // 
            this.btnIzbrishiKosnica.Location = new System.Drawing.Point(261, 278);
            this.btnIzbrishiKosnica.Name = "btnIzbrishiKosnica";
            this.btnIzbrishiKosnica.Size = new System.Drawing.Size(257, 26);
            this.btnIzbrishiKosnica.TabIndex = 10;
            this.btnIzbrishiKosnica.Text = "Izbrishi od koshnica";
            this.btnIzbrishiKosnica.UseVisualStyleBackColor = true;
            this.btnIzbrishiKosnica.Click += new System.EventHandler(this.btnIzbrishiKosnica_Click);
            // 
            // btnDodadiProdukt
            // 
            this.btnDodadiProdukt.Location = new System.Drawing.Point(261, 313);
            this.btnDodadiProdukt.Name = "btnDodadiProdukt";
            this.btnDodadiProdukt.Size = new System.Drawing.Size(257, 26);
            this.btnDodadiProdukt.TabIndex = 11;
            this.btnDodadiProdukt.Text = "Dodadi nov produkt";
            this.btnDodadiProdukt.UseVisualStyleBackColor = true;
            this.btnDodadiProdukt.Click += new System.EventHandler(this.btnDodadiProdukt_Click);
            // 
            // btnIzbrishiProdukt
            // 
            this.btnIzbrishiProdukt.Location = new System.Drawing.Point(260, 353);
            this.btnIzbrishiProdukt.Name = "btnIzbrishiProdukt";
            this.btnIzbrishiProdukt.Size = new System.Drawing.Size(257, 26);
            this.btnIzbrishiProdukt.TabIndex = 12;
            this.btnIzbrishiProdukt.Text = "Izbrishi Produkt";
            this.btnIzbrishiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrishiProdukt.Click += new System.EventHandler(this.btnIzbrishiProdukt_Click);
            // 
            // btnIzprazniLista
            // 
            this.btnIzprazniLista.Location = new System.Drawing.Point(12, 394);
            this.btnIzprazniLista.Name = "btnIzprazniLista";
            this.btnIzprazniLista.Size = new System.Drawing.Size(242, 26);
            this.btnIzprazniLista.TabIndex = 13;
            this.btnIzprazniLista.Text = "Izprazni ja listata na produkti?";
            this.btnIzprazniLista.UseVisualStyleBackColor = true;
            this.btnIzprazniLista.Click += new System.EventHandler(this.btnIzprazniLista_Click);
            // 
            // btnIzprazniKoshnica
            // 
            this.btnIzprazniKoshnica.Location = new System.Drawing.Point(524, 394);
            this.btnIzprazniKoshnica.Name = "btnIzprazniKoshnica";
            this.btnIzprazniKoshnica.Size = new System.Drawing.Size(257, 26);
            this.btnIzprazniKoshnica.TabIndex = 14;
            this.btnIzprazniKoshnica.Text = "Izprazni ja koshnicata?";
            this.btnIzprazniKoshnica.UseVisualStyleBackColor = true;
            this.btnIzprazniKoshnica.Click += new System.EventHandler(this.btnIzprazniKoshnica_Click);
            // 
            // nudKolichina
            // 
            this.nudKolichina.Location = new System.Drawing.Point(430, 246);
            this.nudKolichina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolichina.Name = "nudKolichina";
            this.nudKolichina.Size = new System.Drawing.Size(82, 22);
            this.nudKolichina.TabIndex = 15;
            this.nudKolichina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.nudKolichina);
            this.Controls.Add(this.btnIzprazniKoshnica);
            this.Controls.Add(this.btnIzprazniLista);
            this.Controls.Add(this.btnIzbrishiProdukt);
            this.Controls.Add(this.btnDodadiProdukt);
            this.Controls.Add(this.btnIzbrishiKosnica);
            this.Controls.Add(this.btnDodadiKosnica);
            this.Controls.Add(this.txtVkupno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKoshnicha);
            this.Controls.Add(this.lbProdukti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolichina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProdukti;
        private System.Windows.Forms.ListBox lbKoshnicha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Button btnDodadiKosnica;
        private System.Windows.Forms.Button btnIzbrishiKosnica;
        private System.Windows.Forms.Button btnDodadiProdukt;
        private System.Windows.Forms.Button btnIzbrishiProdukt;
        private System.Windows.Forms.Button btnIzprazniLista;
        private System.Windows.Forms.Button btnIzprazniKoshnica;
        private System.Windows.Forms.NumericUpDown nudKolichina;
    }
}

