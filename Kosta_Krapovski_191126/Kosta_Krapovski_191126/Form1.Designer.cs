
namespace Kosta_Krapovski_191126
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
            this.lbDenovi = new System.Windows.Forms.ListBox();
            this.btnDodadiDen = new System.Windows.Forms.Button();
            this.btnIzbrishiDen = new System.Windows.Forms.Button();
            this.txtNLica = new System.Windows.Forms.TextBox();
            this.txtILica = new System.Windows.Forms.TextBox();
            this.txtMaxZarazeni = new System.Windows.Forms.TextBox();
            this.cbZakluchiDen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDenovi
            // 
            this.lbDenovi.FormattingEnabled = true;
            this.lbDenovi.ItemHeight = 16;
            this.lbDenovi.Location = new System.Drawing.Point(13, 13);
            this.lbDenovi.Name = "lbDenovi";
            this.lbDenovi.Size = new System.Drawing.Size(214, 420);
            this.lbDenovi.TabIndex = 0;
            this.lbDenovi.SelectedIndexChanged += new System.EventHandler(this.lbDenovi_SelectedIndexChanged);
            // 
            // btnDodadiDen
            // 
            this.btnDodadiDen.Location = new System.Drawing.Point(298, 188);
            this.btnDodadiDen.Name = "btnDodadiDen";
            this.btnDodadiDen.Size = new System.Drawing.Size(134, 29);
            this.btnDodadiDen.TabIndex = 1;
            this.btnDodadiDen.Text = "Додади ден";
            this.btnDodadiDen.UseVisualStyleBackColor = true;
            this.btnDodadiDen.Click += new System.EventHandler(this.btnDodadiDen_Click);
            // 
            // btnIzbrishiDen
            // 
            this.btnIzbrishiDen.Location = new System.Drawing.Point(298, 248);
            this.btnIzbrishiDen.Name = "btnIzbrishiDen";
            this.btnIzbrishiDen.Size = new System.Drawing.Size(134, 29);
            this.btnIzbrishiDen.TabIndex = 2;
            this.btnIzbrishiDen.Text = "Избриши ден";
            this.btnIzbrishiDen.UseVisualStyleBackColor = true;
            this.btnIzbrishiDen.Click += new System.EventHandler(this.btnIzbrishiDen_Click);
            // 
            // txtNLica
            // 
            this.txtNLica.Location = new System.Drawing.Point(496, 65);
            this.txtNLica.Name = "txtNLica";
            this.txtNLica.Size = new System.Drawing.Size(132, 22);
            this.txtNLica.TabIndex = 3;
            // 
            // txtILica
            // 
            this.txtILica.Location = new System.Drawing.Point(496, 134);
            this.txtILica.Name = "txtILica";
            this.txtILica.Size = new System.Drawing.Size(132, 22);
            this.txtILica.TabIndex = 4;
            // 
            // txtMaxZarazeni
            // 
            this.txtMaxZarazeni.Location = new System.Drawing.Point(496, 274);
            this.txtMaxZarazeni.Name = "txtMaxZarazeni";
            this.txtMaxZarazeni.Size = new System.Drawing.Size(132, 22);
            this.txtMaxZarazeni.TabIndex = 5;
            // 
            // cbZakluchiDen
            // 
            this.cbZakluchiDen.AutoSize = true;
            this.cbZakluchiDen.Location = new System.Drawing.Point(496, 188);
            this.cbZakluchiDen.Name = "cbZakluchiDen";
            this.cbZakluchiDen.Size = new System.Drawing.Size(113, 21);
            this.cbZakluchiDen.TabIndex = 6;
            this.cbZakluchiDen.Text = "Заклучи ден";
            this.cbZakluchiDen.UseVisualStyleBackColor = true;
            this.cbZakluchiDen.CheckedChanged += new System.EventHandler(this.cbZakluchiDen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Новозаразени лица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Излечени лица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ден со најмногу новозаразени";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbZakluchiDen);
            this.Controls.Add(this.txtMaxZarazeni);
            this.Controls.Add(this.txtILica);
            this.Controls.Add(this.txtNLica);
            this.Controls.Add(this.btnIzbrishiDen);
            this.Controls.Add(this.btnDodadiDen);
            this.Controls.Add(this.lbDenovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDenovi;
        private System.Windows.Forms.Button btnDodadiDen;
        private System.Windows.Forms.Button btnIzbrishiDen;
        private System.Windows.Forms.TextBox txtNLica;
        private System.Windows.Forms.TextBox txtILica;
        private System.Windows.Forms.TextBox txtMaxZarazeni;
        private System.Windows.Forms.CheckBox cbZakluchiDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

