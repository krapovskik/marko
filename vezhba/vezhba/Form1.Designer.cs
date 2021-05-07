
namespace vezhba
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
            this.lbAerodromi = new System.Windows.Forms.ListBox();
            this.lbDestinacie = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtAvgDistance = new System.Windows.Forms.TextBox();
            this.labe3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAerodromi
            // 
            this.lbAerodromi.FormattingEnabled = true;
            this.lbAerodromi.ItemHeight = 16;
            this.lbAerodromi.Location = new System.Drawing.Point(43, 35);
            this.lbAerodromi.Name = "lbAerodromi";
            this.lbAerodromi.Size = new System.Drawing.Size(217, 260);
            this.lbAerodromi.TabIndex = 0;
            this.lbAerodromi.SelectedIndexChanged += new System.EventHandler(this.lbAerodromi_SelectedIndexChanged);
            // 
            // lbDestinacie
            // 
            this.lbDestinacie.FormattingEnabled = true;
            this.lbDestinacie.ItemHeight = 16;
            this.lbDestinacie.Location = new System.Drawing.Point(320, 35);
            this.lbDestinacie.Name = "lbDestinacie";
            this.lbDestinacie.Size = new System.Drawing.Size(228, 260);
            this.lbDestinacie.TabIndex = 2;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(43, 322);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(217, 26);
            this.btnAddAirport.TabIndex = 3;
            this.btnAddAirport.Text = "Dodadi aerodrom";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(43, 367);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(217, 26);
            this.btnDeleteAirport.TabIndex = 4;
            this.btnDeleteAirport.Text = "Izbrishi aerodrom";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(43, 416);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(217, 26);
            this.btnAddDestination.TabIndex = 5;
            this.btnAddDestination.Text = "Dodadi destinacija";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(320, 321);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(69, 17);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Destinacii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Najskapa destinacija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prosechna dolzhina na destinaciite";
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Enabled = false;
            this.txtMaxPrice.Location = new System.Drawing.Point(323, 371);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(225, 22);
            this.txtMaxPrice.TabIndex = 9;
            // 
            // txtAvgDistance
            // 
            this.txtAvgDistance.Enabled = false;
            this.txtAvgDistance.Location = new System.Drawing.Point(323, 420);
            this.txtAvgDistance.Name = "txtAvgDistance";
            this.txtAvgDistance.Size = new System.Drawing.Size(225, 22);
            this.txtAvgDistance.TabIndex = 10;
            this.txtAvgDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labe3
            // 
            this.labe3.AutoSize = true;
            this.labe3.Location = new System.Drawing.Point(43, 12);
            this.labe3.Name = "labe3";
            this.labe3.Size = new System.Drawing.Size(73, 17);
            this.labe3.TabIndex = 11;
            this.labe3.Text = "Aerodromi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Destinacii";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labe3);
            this.Controls.Add(this.txtAvgDistance);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lbDestinacie);
            this.Controls.Add(this.lbAerodromi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAerodromi;
        private System.Windows.Forms.ListBox lbDestinacie;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtAvgDistance;
        private System.Windows.Forms.Label labe3;
        private System.Windows.Forms.Label label4;
    }
}

