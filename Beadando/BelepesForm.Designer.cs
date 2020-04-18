namespace Beadando
{
    partial class BelepesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BelepesFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.felhasznaloTb = new System.Windows.Forms.TextBox();
            this.jelszoTb = new System.Windows.Forms.TextBox();
            this.belepesBtn = new System.Windows.Forms.Button();
            this.cbRegisztral = new System.Windows.Forms.CheckBox();
            this.tbJelszUjra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btRegisztracio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // felhasznaloTb
            // 
            this.felhasznaloTb.Location = new System.Drawing.Point(39, 64);
            this.felhasznaloTb.Name = "felhasznaloTb";
            this.felhasznaloTb.Size = new System.Drawing.Size(100, 22);
            this.felhasznaloTb.TabIndex = 2;
            // 
            // jelszoTb
            // 
            this.jelszoTb.Location = new System.Drawing.Point(254, 64);
            this.jelszoTb.Name = "jelszoTb";
            this.jelszoTb.Size = new System.Drawing.Size(100, 22);
            this.jelszoTb.TabIndex = 3;
            this.jelszoTb.UseSystemPasswordChar = true;
            // 
            // belepesBtn
            // 
            this.belepesBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.belepesBtn.Location = new System.Drawing.Point(372, 140);
            this.belepesBtn.Name = "belepesBtn";
            this.belepesBtn.Size = new System.Drawing.Size(100, 27);
            this.belepesBtn.TabIndex = 4;
            this.belepesBtn.Text = "Belépés!";
            this.belepesBtn.UseVisualStyleBackColor = true;
            this.belepesBtn.Click += new System.EventHandler(this.belepesBtn_Click);
            // 
            // cbRegisztral
            // 
            this.cbRegisztral.AutoSize = true;
            this.cbRegisztral.Location = new System.Drawing.Point(39, 107);
            this.cbRegisztral.Name = "cbRegisztral";
            this.cbRegisztral.Size = new System.Drawing.Size(108, 21);
            this.cbRegisztral.TabIndex = 5;
            this.cbRegisztral.Text = "Regisztráció";
            this.cbRegisztral.UseVisualStyleBackColor = true;
            this.cbRegisztral.CheckedChanged += new System.EventHandler(this.cbRegisztral_CheckedChanged);
            // 
            // tbJelszUjra
            // 
            this.tbJelszUjra.Location = new System.Drawing.Point(254, 140);
            this.tbJelszUjra.Name = "tbJelszUjra";
            this.tbJelszUjra.Size = new System.Drawing.Size(100, 22);
            this.tbJelszUjra.TabIndex = 7;
            this.tbJelszUjra.UseSystemPasswordChar = true;
            this.tbJelszUjra.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jelszó újra:";
            this.label3.Visible = false;
            // 
            // btRegisztracio
            // 
            this.btRegisztracio.Location = new System.Drawing.Point(372, 173);
            this.btRegisztracio.Name = "btRegisztracio";
            this.btRegisztracio.Size = new System.Drawing.Size(100, 27);
            this.btRegisztracio.TabIndex = 8;
            this.btRegisztracio.Text = "Regisztrál!";
            this.btRegisztracio.UseVisualStyleBackColor = true;
            this.btRegisztracio.Visible = false;
            this.btRegisztracio.Click += new System.EventHandler(this.btRegisztracio_Click);
            // 
            // BelepesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(484, 230);
            this.Controls.Add(this.btRegisztracio);
            this.Controls.Add(this.tbJelszUjra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRegisztral);
            this.Controls.Add(this.belepesBtn);
            this.Controls.Add(this.jelszoTb);
            this.Controls.Add(this.felhasznaloTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BelepesFrm";
            this.Text = "Berry";
            this.Load += new System.EventHandler(this.BelepesFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox felhasznaloTb;
        private System.Windows.Forms.TextBox jelszoTb;
        private System.Windows.Forms.Button belepesBtn;
        private System.Windows.Forms.CheckBox cbRegisztral;
        private System.Windows.Forms.TextBox tbJelszUjra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRegisztracio;
    }
}

