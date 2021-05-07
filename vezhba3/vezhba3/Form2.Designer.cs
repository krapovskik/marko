
namespace vezhba3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.nudVozrast = new System.Windows.Forms.NumericUpDown();
            this.cbPrvVozach = new System.Windows.Forms.CheckBox();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudVozrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(13, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(328, 22);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // nudVozrast
            // 
            this.nudVozrast.Location = new System.Drawing.Point(13, 87);
            this.nudVozrast.Name = "nudVozrast";
            this.nudVozrast.Size = new System.Drawing.Size(120, 22);
            this.nudVozrast.TabIndex = 1;
            this.nudVozrast.Validating += new System.ComponentModel.CancelEventHandler(this.nudVozrast_Validating);
            // 
            // cbPrvVozach
            // 
            this.cbPrvVozach.AutoSize = true;
            this.cbPrvVozach.Location = new System.Drawing.Point(140, 87);
            this.cbPrvVozach.Name = "cbPrvVozach";
            this.cbPrvVozach.Size = new System.Drawing.Size(100, 21);
            this.cbPrvVozach.TabIndex = 2;
            this.cbPrvVozach.Text = "Prv vozach";
            this.cbPrvVozach.UseVisualStyleBackColor = true;
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.Location = new System.Drawing.Point(13, 115);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(160, 36);
            this.btnOtkazhi.TabIndex = 3;
            this.btnOtkazhi.Text = "Otkazhi";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(179, 114);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(162, 36);
            this.btnDodadi.TabIndex = 4;
            this.btnDodadi.Text = "Dodadi";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vozrast";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 164);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.btnOtkazhi);
            this.Controls.Add(this.cbPrvVozach);
            this.Controls.Add(this.nudVozrast);
            this.Controls.Add(this.txtIme);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudVozrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.NumericUpDown nudVozrast;
        private System.Windows.Forms.CheckBox cbPrvVozach;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}