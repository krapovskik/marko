
namespace vezhba6
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
            this.lbKonferecii = new System.Windows.Forms.ListBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnIzbrishi = new System.Windows.Forms.Button();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGodina);
            this.groupBox1.Controls.Add(this.btnIzbrishi);
            this.groupBox1.Controls.Add(this.btnDodadi);
            this.groupBox1.Controls.Add(this.lbKonferecii);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konferencii";
            // 
            // lbKonferecii
            // 
            this.lbKonferecii.FormattingEnabled = true;
            this.lbKonferecii.ItemHeight = 16;
            this.lbKonferecii.Location = new System.Drawing.Point(6, 21);
            this.lbKonferecii.Name = "lbKonferecii";
            this.lbKonferecii.Size = new System.Drawing.Size(288, 292);
            this.lbKonferecii.TabIndex = 0;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(6, 365);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(288, 27);
            this.btnDodadi.TabIndex = 1;
            this.btnDodadi.Text = "Dodadi konferencija";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnIzbrishi
            // 
            this.btnIzbrishi.Location = new System.Drawing.Point(6, 398);
            this.btnIzbrishi.Name = "btnIzbrishi";
            this.btnIzbrishi.Size = new System.Drawing.Size(288, 27);
            this.btnIzbrishi.TabIndex = 2;
            this.btnIzbrishi.Text = "Izbrishi konferencija";
            this.btnIzbrishi.UseVisualStyleBackColor = true;
            this.btnIzbrishi.Click += new System.EventHandler(this.btnIzbrishi_Click);
            // 
            // cbGodina
            // 
            this.cbGodina.DisplayMember = "0";
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Location = new System.Drawing.Point(6, 335);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(288, 24);
            this.cbGodina.TabIndex = 3;
            this.cbGodina.SelectedIndexChanged += new System.EventHandler(this.cbGodina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Godina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 466);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.Button btnIzbrishi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.ListBox lbKonferecii;
    }
}

