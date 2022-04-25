
namespace Hatane_Yönetim_otomasyonu
{
    partial class frmdoktorgiris
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
            this.btngiriş = new System.Windows.Forms.Button();
            this.lnkuyeol = new System.Windows.Forms.LinkLabel();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngiriş
            // 
            this.btngiriş.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btngiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiriş.Location = new System.Drawing.Point(208, 175);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(212, 46);
            this.btngiriş.TabIndex = 13;
            this.btngiriş.Text = "Giriş Yap";
            this.btngiriş.UseVisualStyleBackColor = false;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // lnkuyeol
            // 
            this.lnkuyeol.AutoSize = true;
            this.lnkuyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkuyeol.LinkColor = System.Drawing.Color.Black;
            this.lnkuyeol.Location = new System.Drawing.Point(446, 102);
            this.lnkuyeol.Name = "lnkuyeol";
            this.lnkuyeol.Size = new System.Drawing.Size(101, 32);
            this.lnkuyeol.TabIndex = 12;
            this.lnkuyeol.TabStop = true;
            this.lnkuyeol.Text = "Üye Ol";
            this.lnkuyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkuyeol_LinkClicked);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(208, 121);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(212, 38);
            this.txtsifre.TabIndex = 11;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(208, 77);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(212, 38);
            this.msktc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(120, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // frmdoktorgiris
            // 
            this.AcceptButton = this.btngiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(568, 233);
            this.Controls.Add(this.btngiriş);
            this.Controls.Add(this.lnkuyeol);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdoktorgiris";
            this.Text = "Doktor Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.LinkLabel lnkuyeol;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}