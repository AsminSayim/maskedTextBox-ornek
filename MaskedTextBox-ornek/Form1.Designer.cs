namespace MaskedTextBox_ornek
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
            this.lblTc = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskTc = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskDTarih = new System.Windows.Forms.MaskedTextBox();
            this.maskKart = new System.Windows.Forms.MaskedTextBox();
            this.maskİp = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(44, 41);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(92, 25);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "T.C. No";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(45, 77);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(91, 25);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kart Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP Adres";
            // 
            // maskTc
            // 
            this.maskTc.Location = new System.Drawing.Point(177, 46);
            this.maskTc.Name = "maskTc";
            this.maskTc.Size = new System.Drawing.Size(146, 20);
            this.maskTc.TabIndex = 5;
            // 
            // maskTelefon
            // 
            this.maskTelefon.Location = new System.Drawing.Point(177, 83);
            this.maskTelefon.Name = "maskTelefon";
            this.maskTelefon.Size = new System.Drawing.Size(146, 20);
            this.maskTelefon.TabIndex = 6;
            // 
            // maskDTarih
            // 
            this.maskDTarih.Location = new System.Drawing.Point(177, 125);
            this.maskDTarih.Name = "maskDTarih";
            this.maskDTarih.Size = new System.Drawing.Size(146, 20);
            this.maskDTarih.TabIndex = 7;
            // 
            // maskKart
            // 
            this.maskKart.Location = new System.Drawing.Point(177, 169);
            this.maskKart.Name = "maskKart";
            this.maskKart.Size = new System.Drawing.Size(146, 20);
            this.maskKart.TabIndex = 8;
            // 
            // maskİp
            // 
            this.maskİp.Location = new System.Drawing.Point(177, 205);
            this.maskİp.Name = "maskİp";
            this.maskİp.Size = new System.Drawing.Size(146, 20);
            this.maskİp.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 350);
            this.Controls.Add(this.maskİp);
            this.Controls.Add(this.maskKart);
            this.Controls.Add(this.maskDTarih);
            this.Controls.Add(this.maskTelefon);
            this.Controls.Add(this.maskTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskTc;
        private System.Windows.Forms.MaskedTextBox maskTelefon;
        private System.Windows.Forms.MaskedTextBox maskDTarih;
        private System.Windows.Forms.MaskedTextBox maskKart;
        private System.Windows.Forms.MaskedTextBox maskİp;
    }
}

