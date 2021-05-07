
namespace Kosta_Krapovski_191126
{
    partial class Додади_нов_ден
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
            this.txtDen = new System.Windows.Forms.TextBox();
            this.txtZarazeni = new System.Windows.Forms.TextBox();
            this.txtIzlecheni = new System.Windows.Forms.TextBox();
            this.cbMesec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(107, 67);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(167, 22);
            this.txtDen.TabIndex = 0;
            this.txtDen.Validating += new System.ComponentModel.CancelEventHandler(this.txtDen_Validating);
            // 
            // txtZarazeni
            // 
            this.txtZarazeni.Location = new System.Drawing.Point(107, 170);
            this.txtZarazeni.Name = "txtZarazeni";
            this.txtZarazeni.Size = new System.Drawing.Size(167, 22);
            this.txtZarazeni.TabIndex = 1;
            // 
            // txtIzlecheni
            // 
            this.txtIzlecheni.Location = new System.Drawing.Point(107, 218);
            this.txtIzlecheni.Name = "txtIzlecheni";
            this.txtIzlecheni.Size = new System.Drawing.Size(167, 22);
            this.txtIzlecheni.TabIndex = 2;
            // 
            // cbMesec
            // 
            this.cbMesec.FormattingEnabled = true;
            this.cbMesec.Items.AddRange(new object[] {
            "Јануари",
            "Февруари",
            "Март",
            "Април",
            "Мај",
            "Јуни",
            "Јули",
            "Август",
            "Септември",
            "Октомври",
            "Ноември",
            "Декември"});
            this.cbMesec.Location = new System.Drawing.Point(107, 117);
            this.cbMesec.Name = "cbMesec";
            this.cbMesec.Size = new System.Drawing.Size(167, 24);
            this.cbMesec.TabIndex = 3;
            this.cbMesec.Validating += new System.ComponentModel.CancelEventHandler(this.cbMesec_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ден";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Месец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Заразени";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Изечени";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(107, 286);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(94, 23);
            this.btnPotvrdi.TabIndex = 8;
            this.btnPotvrdi.Text = "Потврди";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Додади_нов_ден
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 364);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMesec);
            this.Controls.Add(this.txtIzlecheni);
            this.Controls.Add(this.txtZarazeni);
            this.Controls.Add(this.txtDen);
            this.Name = "Додади_нов_ден";
            this.Text = "Додади_нов_ден";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.TextBox txtZarazeni;
        private System.Windows.Forms.TextBox txtIzlecheni;
        private System.Windows.Forms.ComboBox cbMesec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}