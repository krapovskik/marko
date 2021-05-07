
namespace vezhba6
{
    partial class Konferencija
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.nudGodina = new System.Windows.Forms.NumericUpDown();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGodina)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(381, 22);
            this.txtIme.TabIndex = 0;
            // 
            // nudGodina
            // 
            this.nudGodina.Location = new System.Drawing.Point(12, 98);
            this.nudGodina.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudGodina.Minimum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.nudGodina.Name = "nudGodina";
            this.nudGodina.Size = new System.Drawing.Size(381, 22);
            this.nudGodina.TabIndex = 1;
            this.nudGodina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGodina.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(299, 162);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(93, 27);
            this.btnDodadi.TabIndex = 2;
            this.btnDodadi.Text = "Dodadi";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.Location = new System.Drawing.Point(200, 162);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(93, 27);
            this.btnOtkazhi.TabIndex = 3;
            this.btnOtkazhi.Text = "Otkazhi";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina";
            // 
            // Konferencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOtkazhi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.nudGodina);
            this.Controls.Add(this.txtIme);
            this.Name = "Konferencija";
            this.Text = "Konferencija";
            ((System.ComponentModel.ISupportInitialize)(this.nudGodina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.NumericUpDown nudGodina;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}