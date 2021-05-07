
namespace vezhba5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.nudPotroshuvachka = new System.Windows.Forms.NumericUpDown();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.btnDodadiAvtomobil = new System.Windows.Forms.Button();
            this.btnIzbrishiAvtomobil = new System.Windows.Forms.Button();
            this.lbMarki = new System.Windows.Forms.ListBox();
            this.btnDodadiMarka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAvtomobili = new System.Windows.Forms.ListBox();
            this.txtPotroshuvachka = new System.Windows.Forms.TextBox();
            this.txtNajekonomichen = new System.Windows.Forms.TextBox();
            this.txtNajskap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotroshuvachka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIzbrishiAvtomobil);
            this.groupBox1.Controls.Add(this.btnDodadiAvtomobil);
            this.groupBox1.Controls.Add(this.nudCena);
            this.groupBox1.Controls.Add(this.nudPotroshuvachka);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.cbMarka);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nov Avtomobil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNajskap);
            this.groupBox2.Controls.Add(this.txtNajekonomichen);
            this.groupBox2.Controls.Add(this.txtPotroshuvachka);
            this.groupBox2.Controls.Add(this.lbAvtomobili);
            this.groupBox2.Location = new System.Drawing.Point(347, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 502);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista na avtomobili";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDodadiMarka);
            this.groupBox3.Controls.Add(this.lbMarki);
            this.groupBox3.Location = new System.Drawing.Point(13, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Marki na avtomobili";
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(7, 41);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(314, 24);
            this.cbMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(6, 87);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(315, 22);
            this.txtModel.TabIndex = 1;
            // 
            // nudPotroshuvachka
            // 
            this.nudPotroshuvachka.Location = new System.Drawing.Point(6, 141);
            this.nudPotroshuvachka.Name = "nudPotroshuvachka";
            this.nudPotroshuvachka.Size = new System.Drawing.Size(120, 22);
            this.nudPotroshuvachka.TabIndex = 2;
            // 
            // nudCena
            // 
            this.nudCena.Location = new System.Drawing.Point(6, 186);
            this.nudCena.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(120, 22);
            this.nudCena.TabIndex = 3;
            // 
            // btnDodadiAvtomobil
            // 
            this.btnDodadiAvtomobil.Location = new System.Drawing.Point(7, 214);
            this.btnDodadiAvtomobil.Name = "btnDodadiAvtomobil";
            this.btnDodadiAvtomobil.Size = new System.Drawing.Size(178, 27);
            this.btnDodadiAvtomobil.TabIndex = 4;
            this.btnDodadiAvtomobil.Text = "Dodadi avtomobil";
            this.btnDodadiAvtomobil.UseVisualStyleBackColor = true;
            this.btnDodadiAvtomobil.Click += new System.EventHandler(this.btnDodadiAvtomobil_Click);
            // 
            // btnIzbrishiAvtomobil
            // 
            this.btnIzbrishiAvtomobil.Location = new System.Drawing.Point(191, 214);
            this.btnIzbrishiAvtomobil.Name = "btnIzbrishiAvtomobil";
            this.btnIzbrishiAvtomobil.Size = new System.Drawing.Size(130, 27);
            this.btnIzbrishiAvtomobil.TabIndex = 5;
            this.btnIzbrishiAvtomobil.Text = "Izbrishi Avtomobil";
            this.btnIzbrishiAvtomobil.UseVisualStyleBackColor = true;
            this.btnIzbrishiAvtomobil.Click += new System.EventHandler(this.btnIzbrishiAvtomobil_Click);
            // 
            // lbMarki
            // 
            this.lbMarki.FormattingEnabled = true;
            this.lbMarki.ItemHeight = 16;
            this.lbMarki.Location = new System.Drawing.Point(7, 22);
            this.lbMarki.Name = "lbMarki";
            this.lbMarki.Size = new System.Drawing.Size(313, 164);
            this.lbMarki.TabIndex = 0;
            // 
            // btnDodadiMarka
            // 
            this.btnDodadiMarka.Location = new System.Drawing.Point(182, 192);
            this.btnDodadiMarka.Name = "btnDodadiMarka";
            this.btnDodadiMarka.Size = new System.Drawing.Size(138, 35);
            this.btnDodadiMarka.TabIndex = 1;
            this.btnDodadiMarka.Text = "Dodadi nova marka";
            this.btnDodadiMarka.UseVisualStyleBackColor = true;
            this.btnDodadiMarka.Click += new System.EventHandler(this.btnDodadiMarka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Potroshuvachka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cena";
            // 
            // lbAvtomobili
            // 
            this.lbAvtomobili.FormattingEnabled = true;
            this.lbAvtomobili.ItemHeight = 16;
            this.lbAvtomobili.Location = new System.Drawing.Point(7, 22);
            this.lbAvtomobili.Name = "lbAvtomobili";
            this.lbAvtomobili.Size = new System.Drawing.Size(353, 340);
            this.lbAvtomobili.TabIndex = 0;
            // 
            // txtPotroshuvachka
            // 
            this.txtPotroshuvachka.Enabled = false;
            this.txtPotroshuvachka.Location = new System.Drawing.Point(200, 377);
            this.txtPotroshuvachka.Name = "txtPotroshuvachka";
            this.txtPotroshuvachka.Size = new System.Drawing.Size(160, 22);
            this.txtPotroshuvachka.TabIndex = 1;
            // 
            // txtNajekonomichen
            // 
            this.txtNajekonomichen.Enabled = false;
            this.txtNajekonomichen.Location = new System.Drawing.Point(7, 423);
            this.txtNajekonomichen.Name = "txtNajekonomichen";
            this.txtNajekonomichen.Size = new System.Drawing.Size(353, 22);
            this.txtNajekonomichen.TabIndex = 2;
            // 
            // txtNajskap
            // 
            this.txtNajskap.Enabled = false;
            this.txtNajskap.Location = new System.Drawing.Point(6, 474);
            this.txtNajskap.Name = "txtNajskap";
            this.txtNajskap.Size = new System.Drawing.Size(353, 22);
            this.txtNajskap.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prosechna potroshuvachka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Najekonomichen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Najskap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPotroshuvachka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrishiAvtomobil;
        private System.Windows.Forms.Button btnDodadiAvtomobil;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.NumericUpDown nudPotroshuvachka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNajskap;
        private System.Windows.Forms.TextBox txtNajekonomichen;
        private System.Windows.Forms.TextBox txtPotroshuvachka;
        private System.Windows.Forms.ListBox lbAvtomobili;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDodadiMarka;
        private System.Windows.Forms.ListBox lbMarki;
    }
}

