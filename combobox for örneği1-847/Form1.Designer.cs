namespace combobox_for_örneği1_847
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
            this.cmbCiftSayilar = new System.Windows.Forms.ComboBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbCiftSayilar
            // 
            this.cmbCiftSayilar.FormattingEnabled = true;
            this.cmbCiftSayilar.Location = new System.Drawing.Point(23, 311);
            this.cmbCiftSayilar.Name = "cmbCiftSayilar";
            this.cmbCiftSayilar.Size = new System.Drawing.Size(131, 21);
            this.cmbCiftSayilar.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(23, 247);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(131, 43);
            this.btnAktar.TabIndex = 1;
            this.btnAktar.Text = "çift sayıları aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnSayilar_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(23, 27);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(131, 199);
            this.lbSayilar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.cmbCiftSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiftSayilar;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

