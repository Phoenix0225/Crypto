
namespace Crypto
{
    partial class Crypto
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crypto));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMethodeCryptage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCleCryptage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTxtCryptage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTxtCrypte = new System.Windows.Forms.TextBox();
            this.btCrypter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Crypto.Properties.Resources.Crypto;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(214, 214);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Méthode d\'encryption :";
            // 
            // cbMethodeCryptage
            // 
            this.cbMethodeCryptage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethodeCryptage.FormattingEnabled = true;
            this.cbMethodeCryptage.Items.AddRange(new object[] {
            "1 - Cryptage AES simple",
            "2 - Cryptage AES RijndaelManaged",
            "3 -  Hashage SHA-2",
            "4 - Cryptage DES"});
            this.cbMethodeCryptage.Location = new System.Drawing.Point(398, 20);
            this.cbMethodeCryptage.Name = "cbMethodeCryptage";
            this.cbMethodeCryptage.Size = new System.Drawing.Size(263, 25);
            this.cbMethodeCryptage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crypto 1.3.0       Copyright Francis Blanchette ©  2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clé de cryptage :";
            // 
            // tbCleCryptage
            // 
            this.tbCleCryptage.Enabled = false;
            this.tbCleCryptage.Location = new System.Drawing.Point(398, 60);
            this.tbCleCryptage.Name = "tbCleCryptage";
            this.tbCleCryptage.Size = new System.Drawing.Size(520, 25);
            this.tbCleCryptage.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Texte à crypter :";
            // 
            // tbTxtCryptage
            // 
            this.tbTxtCryptage.Location = new System.Drawing.Point(398, 107);
            this.tbTxtCryptage.Multiline = true;
            this.tbTxtCryptage.Name = "tbTxtCryptage";
            this.tbTxtCryptage.Size = new System.Drawing.Size(520, 58);
            this.tbTxtCryptage.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Texte crypté :";
            // 
            // tbTxtCrypte
            // 
            this.tbTxtCrypte.Location = new System.Drawing.Point(398, 186);
            this.tbTxtCrypte.Multiline = true;
            this.tbTxtCrypte.Name = "tbTxtCrypte";
            this.tbTxtCrypte.Size = new System.Drawing.Size(520, 151);
            this.tbTxtCrypte.TabIndex = 9;
            // 
            // btCrypter
            // 
            this.btCrypter.BackColor = System.Drawing.Color.Gainsboro;
            this.btCrypter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrypter.Location = new System.Drawing.Point(12, 243);
            this.btCrypter.Name = "btCrypter";
            this.btCrypter.Size = new System.Drawing.Size(214, 37);
            this.btCrypter.TabIndex = 10;
            this.btCrypter.Text = "Crypter";
            this.btCrypter.UseVisualStyleBackColor = false;
            this.btCrypter.Click += new System.EventHandler(this.BtCrypter_Click);
            // 
            // Crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 346);
            this.Controls.Add(this.btCrypter);
            this.Controls.Add(this.tbTxtCrypte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTxtCryptage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCleCryptage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMethodeCryptage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Crypto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto | Encryption de données";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMethodeCryptage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCleCryptage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTxtCryptage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTxtCrypte;
        private System.Windows.Forms.Button btCrypter;
    }
}

