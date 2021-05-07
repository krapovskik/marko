
namespace vezhba4
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
            this.lblIspiti = new System.Windows.Forms.ListBox();
            this.btnDodadiIspit = new System.Windows.Forms.Button();
            this.btnIzbrishiIspit = new System.Windows.Forms.Button();
            this.txtZad1 = new System.Windows.Forms.TextBox();
            this.btnZad1 = new System.Windows.Forms.Button();
            this.nudZad1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudZad2 = new System.Windows.Forms.NumericUpDown();
            this.btnZad2 = new System.Windows.Forms.Button();
            this.txtZad2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZad1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZad2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrishiIspit);
            this.groupBox1.Controls.Add(this.btnDodadiIspit);
            this.groupBox1.Controls.Add(this.lblIspiti);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ispiti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudZad1);
            this.groupBox2.Controls.Add(this.btnZad1);
            this.groupBox2.Controls.Add(this.txtZad1);
            this.groupBox2.Location = new System.Drawing.Point(309, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zadacha1";
            // 
            // lblIspiti
            // 
            this.lblIspiti.FormattingEnabled = true;
            this.lblIspiti.ItemHeight = 16;
            this.lblIspiti.Location = new System.Drawing.Point(7, 22);
            this.lblIspiti.Name = "lblIspiti";
            this.lblIspiti.Size = new System.Drawing.Size(277, 356);
            this.lblIspiti.TabIndex = 0;
            this.lblIspiti.SelectedIndexChanged += new System.EventHandler(this.lblIspiti_SelectedIndexChanged);
            // 
            // btnDodadiIspit
            // 
            this.btnDodadiIspit.Location = new System.Drawing.Point(7, 384);
            this.btnDodadiIspit.Name = "btnDodadiIspit";
            this.btnDodadiIspit.Size = new System.Drawing.Size(277, 33);
            this.btnDodadiIspit.TabIndex = 1;
            this.btnDodadiIspit.Text = "Dodadi ispit";
            this.btnDodadiIspit.UseVisualStyleBackColor = true;
            this.btnDodadiIspit.Click += new System.EventHandler(this.btnDodadiIspit_Click);
            // 
            // btnIzbrishiIspit
            // 
            this.btnIzbrishiIspit.Location = new System.Drawing.Point(7, 423);
            this.btnIzbrishiIspit.Name = "btnIzbrishiIspit";
            this.btnIzbrishiIspit.Size = new System.Drawing.Size(277, 33);
            this.btnIzbrishiIspit.TabIndex = 3;
            this.btnIzbrishiIspit.Text = "Izbrishi ispit";
            this.btnIzbrishiIspit.UseVisualStyleBackColor = true;
            this.btnIzbrishiIspit.Click += new System.EventHandler(this.btnIzbrishiIspit_Click);
            // 
            // txtZad1
            // 
            this.txtZad1.Location = new System.Drawing.Point(6, 43);
            this.txtZad1.Multiline = true;
            this.txtZad1.Name = "txtZad1";
            this.txtZad1.Size = new System.Drawing.Size(290, 85);
            this.txtZad1.TabIndex = 0;
            // 
            // btnZad1
            // 
            this.btnZad1.Location = new System.Drawing.Point(196, 190);
            this.btnZad1.Name = "btnZad1";
            this.btnZad1.Size = new System.Drawing.Size(101, 33);
            this.btnZad1.TabIndex = 4;
            this.btnZad1.Text = "Zachuvaj";
            this.btnZad1.UseVisualStyleBackColor = true;
            this.btnZad1.Click += new System.EventHandler(this.btnZad1_Click);
            // 
            // nudZad1
            // 
            this.nudZad1.Location = new System.Drawing.Point(6, 151);
            this.nudZad1.Name = "nudZad1";
            this.nudZad1.Size = new System.Drawing.Size(120, 22);
            this.nudZad1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nudZad2);
            this.groupBox3.Controls.Add(this.btnZad2);
            this.groupBox3.Controls.Add(this.txtZad2);
            this.groupBox3.Location = new System.Drawing.Point(309, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 227);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zadacha2";
            // 
            // nudZad2
            // 
            this.nudZad2.Location = new System.Drawing.Point(6, 149);
            this.nudZad2.Name = "nudZad2";
            this.nudZad2.Size = new System.Drawing.Size(120, 22);
            this.nudZad2.TabIndex = 5;
            // 
            // btnZad2
            // 
            this.btnZad2.Location = new System.Drawing.Point(196, 188);
            this.btnZad2.Name = "btnZad2";
            this.btnZad2.Size = new System.Drawing.Size(101, 33);
            this.btnZad2.TabIndex = 4;
            this.btnZad2.Text = "Zachuvaj";
            this.btnZad2.UseVisualStyleBackColor = true;
            this.btnZad2.Click += new System.EventHandler(this.btnZad2_Click);
            // 
            // txtZad2
            // 
            this.txtZad2.Location = new System.Drawing.Point(6, 43);
            this.txtZad2.Multiline = true;
            this.txtZad2.Name = "txtZad2";
            this.txtZad2.Size = new System.Drawing.Size(290, 85);
            this.txtZad2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Poeni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Poeni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZad1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrishiIspit;
        private System.Windows.Forms.Button btnDodadiIspit;
        private System.Windows.Forms.ListBox lblIspiti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudZad1;
        private System.Windows.Forms.Button btnZad1;
        private System.Windows.Forms.TextBox txtZad1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudZad2;
        private System.Windows.Forms.Button btnZad2;
        private System.Windows.Forms.TextBox txtZad2;
    }
}

