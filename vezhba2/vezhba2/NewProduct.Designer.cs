
namespace vezhba2
{
    partial class NewProduct
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
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(13, 32);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(320, 22);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(12, 92);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.Size = new System.Drawing.Size(320, 22);
            this.txtKategorija.TabIndex = 1;
            this.txtKategorija.Validating += new System.ComponentModel.CancelEventHandler(this.txtKategorija_Validating);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(12, 154);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(160, 22);
            this.txtCena.TabIndex = 2;
            this.txtCena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCena_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena";
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(235, 204);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(98, 29);
            this.btnDodadi.TabIndex = 6;
            this.btnDodadi.Text = "Dodadi";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.Location = new System.Drawing.Point(131, 204);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(98, 29);
            this.btnOtkazhi.TabIndex = 7;
            this.btnOtkazhi.Text = "Otkazhi";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 245);
            this.Controls.Add(this.btnOtkazhi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtKategorija);
            this.Controls.Add(this.txtIme);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.ErrorProvider error;
    }
}