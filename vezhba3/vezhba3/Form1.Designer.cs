
namespace vezhba3
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
            this.btnIzbrishiVozach = new System.Windows.Forms.Button();
            this.btnDodadiVozach = new System.Windows.Forms.Button();
            this.lbVozachi = new System.Windows.Forms.ListBox();
            this.Krugovi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBestLap = new System.Windows.Forms.TextBox();
            this.nudVreme = new System.Windows.Forms.NumericUpDown();
            this.nudSek = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.btnDodadiKrug = new System.Windows.Forms.Button();
            this.lbKrugovi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.Krugovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrishiVozach);
            this.groupBox1.Controls.Add(this.btnDodadiVozach);
            this.groupBox1.Controls.Add(this.lbVozachi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozachi";
            // 
            // btnIzbrishiVozach
            // 
            this.btnIzbrishiVozach.Location = new System.Drawing.Point(6, 379);
            this.btnIzbrishiVozach.Name = "btnIzbrishiVozach";
            this.btnIzbrishiVozach.Size = new System.Drawing.Size(351, 36);
            this.btnIzbrishiVozach.TabIndex = 2;
            this.btnIzbrishiVozach.Text = "Izbrishi vozach";
            this.btnIzbrishiVozach.UseVisualStyleBackColor = true;
            this.btnIzbrishiVozach.Click += new System.EventHandler(this.btnIzbrishiVozach_Click);
            // 
            // btnDodadiVozach
            // 
            this.btnDodadiVozach.Location = new System.Drawing.Point(7, 337);
            this.btnDodadiVozach.Name = "btnDodadiVozach";
            this.btnDodadiVozach.Size = new System.Drawing.Size(351, 36);
            this.btnDodadiVozach.TabIndex = 1;
            this.btnDodadiVozach.Text = "Dodadi vozach";
            this.btnDodadiVozach.UseVisualStyleBackColor = true;
            this.btnDodadiVozach.Click += new System.EventHandler(this.btnDodadiVozach_Click);
            // 
            // lbVozachi
            // 
            this.lbVozachi.FormattingEnabled = true;
            this.lbVozachi.ItemHeight = 16;
            this.lbVozachi.Location = new System.Drawing.Point(7, 22);
            this.lbVozachi.Name = "lbVozachi";
            this.lbVozachi.Size = new System.Drawing.Size(351, 308);
            this.lbVozachi.TabIndex = 0;
            this.lbVozachi.SelectedIndexChanged += new System.EventHandler(this.lbVozachi_SelectedIndexChanged);
            // 
            // Krugovi
            // 
            this.Krugovi.Controls.Add(this.label4);
            this.Krugovi.Controls.Add(this.label3);
            this.Krugovi.Controls.Add(this.label2);
            this.Krugovi.Controls.Add(this.label1);
            this.Krugovi.Controls.Add(this.txtBestLap);
            this.Krugovi.Controls.Add(this.nudVreme);
            this.Krugovi.Controls.Add(this.nudSek);
            this.Krugovi.Controls.Add(this.nudMin);
            this.Krugovi.Controls.Add(this.btnDodadiKrug);
            this.Krugovi.Controls.Add(this.lbKrugovi);
            this.Krugovi.Location = new System.Drawing.Point(383, 13);
            this.Krugovi.Name = "Krugovi";
            this.Krugovi.Size = new System.Drawing.Size(405, 425);
            this.Krugovi.TabIndex = 1;
            this.Krugovi.TabStop = false;
            this.Krugovi.Text = "Krugovi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vreme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Najdobar krug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sekundi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Minuti";
            // 
            // txtBestLap
            // 
            this.txtBestLap.Enabled = false;
            this.txtBestLap.Location = new System.Drawing.Point(6, 337);
            this.txtBestLap.Name = "txtBestLap";
            this.txtBestLap.Size = new System.Drawing.Size(393, 22);
            this.txtBestLap.TabIndex = 7;
            // 
            // nudVreme
            // 
            this.nudVreme.Location = new System.Drawing.Point(7, 379);
            this.nudVreme.Maximum = new decimal(new int[] {
            84600,
            0,
            0,
            0});
            this.nudVreme.Name = "nudVreme";
            this.nudVreme.Size = new System.Drawing.Size(102, 22);
            this.nudVreme.TabIndex = 6;
            this.nudVreme.ValueChanged += new System.EventHandler(this.nudVreme_ValueChanged);
            // 
            // nudSek
            // 
            this.nudSek.Location = new System.Drawing.Point(118, 272);
            this.nudSek.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSek.Name = "nudSek";
            this.nudSek.Size = new System.Drawing.Size(102, 22);
            this.nudSek.TabIndex = 5;
            this.nudSek.ValueChanged += new System.EventHandler(this.nudSek_ValueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(6, 272);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(102, 22);
            this.nudMin.TabIndex = 4;
            // 
            // btnDodadiKrug
            // 
            this.btnDodadiKrug.Location = new System.Drawing.Point(226, 272);
            this.btnDodadiKrug.Name = "btnDodadiKrug";
            this.btnDodadiKrug.Size = new System.Drawing.Size(173, 36);
            this.btnDodadiKrug.TabIndex = 3;
            this.btnDodadiKrug.Text = "Dodadi krug";
            this.btnDodadiKrug.UseVisualStyleBackColor = true;
            this.btnDodadiKrug.Click += new System.EventHandler(this.btnDodadiKrug_Click);
            // 
            // lbKrugovi
            // 
            this.lbKrugovi.FormattingEnabled = true;
            this.lbKrugovi.ItemHeight = 16;
            this.lbKrugovi.Location = new System.Drawing.Point(6, 22);
            this.lbKrugovi.Name = "lbKrugovi";
            this.lbKrugovi.Size = new System.Drawing.Size(393, 228);
            this.lbKrugovi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Krugovi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.Krugovi.ResumeLayout(false);
            this.Krugovi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrishiVozach;
        private System.Windows.Forms.Button btnDodadiVozach;
        private System.Windows.Forms.ListBox lbVozachi;
        private System.Windows.Forms.GroupBox Krugovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBestLap;
        private System.Windows.Forms.NumericUpDown nudVreme;
        private System.Windows.Forms.NumericUpDown nudSek;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Button btnDodadiKrug;
        private System.Windows.Forms.ListBox lbKrugovi;
    }
}

