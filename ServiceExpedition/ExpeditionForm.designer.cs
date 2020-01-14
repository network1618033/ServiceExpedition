namespace ServiceExpedition
{
    partial class ExpeditionForm
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
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ExpeditionMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierEnregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.prixLabel = new System.Windows.Forms.Label();
            this.prixLLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.nomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.paiementDuLLabel = new System.Windows.Forms.Label();
            this.paiementDuLabel = new System.Windows.Forms.Label();
            this.dateExpeditionLabel = new System.Windows.Forms.Label();
            this.adresseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.zoneLabel = new System.Windows.Forms.Label();
            this.villeLabel = new System.Windows.Forms.Label();
            this.villeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.poidsComboBox = new System.Windows.Forms.ComboBox();
            this.destinataireGroupBox = new System.Windows.Forms.GroupBox();
            this.provincesComboBox = new System.Windows.Forms.ComboBox();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.codePostalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.poidsLabel = new System.Windows.Forms.Label();
            this.colisGroupBox = new System.Windows.Forms.GroupBox();
            this.dateExpeditionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpeditionMenuStrip.SuspendLayout();
            this.destinataireGroupBox.SuspendLayout();
            this.colisGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(337, 188);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(205, 22);
            this.telephoneMaskedTextBox.TabIndex = 11;
            this.telephoneMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBoxEnter);
            // 
            // ExpeditionMenuStrip
            // 
            this.ExpeditionMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ExpeditionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.ExpeditionMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ExpeditionMenuStrip.Name = "ExpeditionMenuStrip";
            this.ExpeditionMenuStrip.Size = new System.Drawing.Size(576, 28);
            this.ExpeditionMenuStrip.TabIndex = 2;
            this.ExpeditionMenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierEnregistrerToolStripMenuItem,
            this.impressionToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // fichierEnregistrerToolStripMenuItem
            // 
            this.fichierEnregistrerToolStripMenuItem.Name = "fichierEnregistrerToolStripMenuItem";
            this.fichierEnregistrerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fichierEnregistrerToolStripMenuItem.Text = "Enregistrer";
            this.fichierEnregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.aProposDeToolStripMenuItem.Text = "À propos de...";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(222, 191);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(84, 17);
            this.telephoneLabel.TabIndex = 10;
            this.telephoneLabel.Text = "&Téléphone :";
            // 
            // prixLabel
            // 
            this.prixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prixLabel.Location = new System.Drawing.Point(315, 57);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(216, 31);
            this.prixLabel.TabIndex = 5;
            this.prixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(366, 28);
            this.prixLLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(31, 17);
            this.prixLLabel.TabIndex = 4;
            this.prixLLabel.Text = "Prix";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(6, 42);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(45, 17);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "&Nom :";
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(182, 57);
            this.zoneComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(112, 24);
            this.zoneComboBox.TabIndex = 3;
            this.zoneComboBox.SelectedIndexChanged += new System.EventHandler(this.poidsZoneComboBox_SelectedIndexChanged);
            // 
            // nomMaskedTextBox
            // 
            this.nomMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomMaskedTextBox.Location = new System.Drawing.Point(135, 42);
            this.nomMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomMaskedTextBox.Name = "nomMaskedTextBox";
            this.nomMaskedTextBox.Size = new System.Drawing.Size(407, 22);
            this.nomMaskedTextBox.TabIndex = 1;
            this.nomMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBoxEnter);
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(6, 76);
            this.adresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(68, 17);
            this.adresseLabel.TabIndex = 2;
            this.adresseLabel.Text = "&Adresse :";
            // 
            // paiementDuLLabel
            // 
            this.paiementDuLLabel.AutoSize = true;
            this.paiementDuLLabel.Location = new System.Drawing.Point(7, 158);
            this.paiementDuLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paiementDuLLabel.Name = "paiementDuLLabel";
            this.paiementDuLLabel.Size = new System.Drawing.Size(114, 17);
            this.paiementDuLLabel.TabIndex = 8;
            this.paiementDuLLabel.Text = "Paiement dû le : ";
            // 
            // paiementDuLabel
            // 
            this.paiementDuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paiementDuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paiementDuLabel.Location = new System.Drawing.Point(182, 153);
            this.paiementDuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paiementDuLabel.Name = "paiementDuLabel";
            this.paiementDuLabel.Size = new System.Drawing.Size(222, 31);
            this.paiementDuLabel.TabIndex = 9;
            // 
            // dateExpeditionLabel
            // 
            this.dateExpeditionLabel.AutoSize = true;
            this.dateExpeditionLabel.Location = new System.Drawing.Point(6, 111);
            this.dateExpeditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateExpeditionLabel.Name = "dateExpeditionLabel";
            this.dateExpeditionLabel.Size = new System.Drawing.Size(129, 17);
            this.dateExpeditionLabel.TabIndex = 6;
            this.dateExpeditionLabel.Text = "Da&te d\'expédition : ";
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(135, 76);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(407, 22);
            this.adresseMaskedTextBox.TabIndex = 3;
            this.adresseMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBoxEnter);
            // 
            // zoneLabel
            // 
            this.zoneLabel.AutoSize = true;
            this.zoneLabel.Location = new System.Drawing.Point(178, 28);
            this.zoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.zoneLabel.Name = "zoneLabel";
            this.zoneLabel.Size = new System.Drawing.Size(41, 17);
            this.zoneLabel.TabIndex = 2;
            this.zoneLabel.Text = "&Zone";
            // 
            // villeLabel
            // 
            this.villeLabel.AutoSize = true;
            this.villeLabel.Location = new System.Drawing.Point(6, 113);
            this.villeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Size = new System.Drawing.Size(42, 17);
            this.villeLabel.TabIndex = 4;
            this.villeLabel.Text = "&Ville :";
            // 
            // villeMaskedTextBox
            // 
            this.villeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.villeMaskedTextBox.Location = new System.Drawing.Point(135, 113);
            this.villeMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.villeMaskedTextBox.Name = "villeMaskedTextBox";
            this.villeMaskedTextBox.Size = new System.Drawing.Size(407, 22);
            this.villeMaskedTextBox.TabIndex = 5;
            this.villeMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBoxEnter);
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Location = new System.Drawing.Point(6, 148);
            this.provinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(63, 17);
            this.provinceLabel.TabIndex = 6;
            this.provinceLabel.Text = "&Province";
            // 
            // poidsComboBox
            // 
            this.poidsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poidsComboBox.FormattingEnabled = true;
            this.poidsComboBox.Location = new System.Drawing.Point(7, 57);
            this.poidsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.poidsComboBox.Name = "poidsComboBox";
            this.poidsComboBox.Size = new System.Drawing.Size(151, 24);
            this.poidsComboBox.TabIndex = 1;
            this.poidsComboBox.SelectedIndexChanged += new System.EventHandler(this.poidsZoneComboBox_SelectedIndexChanged);
            // 
            // destinataireGroupBox
            // 
            this.destinataireGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinataireGroupBox.Controls.Add(this.telephoneLabel);
            this.destinataireGroupBox.Controls.Add(this.telephoneMaskedTextBox);
            this.destinataireGroupBox.Controls.Add(this.nomLabel);
            this.destinataireGroupBox.Controls.Add(this.nomMaskedTextBox);
            this.destinataireGroupBox.Controls.Add(this.adresseLabel);
            this.destinataireGroupBox.Controls.Add(this.adresseMaskedTextBox);
            this.destinataireGroupBox.Controls.Add(this.villeLabel);
            this.destinataireGroupBox.Controls.Add(this.villeMaskedTextBox);
            this.destinataireGroupBox.Controls.Add(this.provinceLabel);
            this.destinataireGroupBox.Controls.Add(this.provincesComboBox);
            this.destinataireGroupBox.Controls.Add(this.codePostalLabel);
            this.destinataireGroupBox.Controls.Add(this.codePostalMaskedTextBox);
            this.destinataireGroupBox.Location = new System.Drawing.Point(13, 49);
            this.destinataireGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.destinataireGroupBox.Name = "destinataireGroupBox";
            this.destinataireGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.destinataireGroupBox.Size = new System.Drawing.Size(550, 234);
            this.destinataireGroupBox.TabIndex = 0;
            this.destinataireGroupBox.TabStop = false;
            this.destinataireGroupBox.Text = "Destinataire";
            // 
            // provincesComboBox
            // 
            this.provincesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.provincesComboBox.FormattingEnabled = true;
            this.provincesComboBox.Location = new System.Drawing.Point(135, 148);
            this.provincesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.provincesComboBox.Name = "provincesComboBox";
            this.provincesComboBox.Size = new System.Drawing.Size(407, 24);
            this.provincesComboBox.TabIndex = 7;
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(6, 188);
            this.codePostalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(92, 17);
            this.codePostalLabel.TabIndex = 8;
            this.codePostalLabel.Text = "&Code Postal :";
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(135, 188);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(79, 22);
            this.codePostalMaskedTextBox.TabIndex = 9;
            this.codePostalMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBoxEnter);
            // 
            // poidsLabel
            // 
            this.poidsLabel.Location = new System.Drawing.Point(4, 26);
            this.poidsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.poidsLabel.Name = "poidsLabel";
            this.poidsLabel.Size = new System.Drawing.Size(79, 24);
            this.poidsLabel.TabIndex = 0;
            this.poidsLabel.Text = "&Poids";
            // 
            // colisGroupBox
            // 
            this.colisGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colisGroupBox.Controls.Add(this.poidsLabel);
            this.colisGroupBox.Controls.Add(this.poidsComboBox);
            this.colisGroupBox.Controls.Add(this.zoneLabel);
            this.colisGroupBox.Controls.Add(this.zoneComboBox);
            this.colisGroupBox.Controls.Add(this.prixLLabel);
            this.colisGroupBox.Controls.Add(this.prixLabel);
            this.colisGroupBox.Controls.Add(this.paiementDuLLabel);
            this.colisGroupBox.Controls.Add(this.paiementDuLabel);
            this.colisGroupBox.Controls.Add(this.dateExpeditionLabel);
            this.colisGroupBox.Controls.Add(this.dateExpeditionMaskedTextBox);
            this.colisGroupBox.Location = new System.Drawing.Point(15, 287);
            this.colisGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.colisGroupBox.Name = "colisGroupBox";
            this.colisGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.colisGroupBox.Size = new System.Drawing.Size(548, 219);
            this.colisGroupBox.TabIndex = 1;
            this.colisGroupBox.TabStop = false;
            this.colisGroupBox.Text = "Colis";
            // 
            // dateExpeditionMaskedTextBox
            // 
            this.dateExpeditionMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateExpeditionMaskedTextBox.Location = new System.Drawing.Point(182, 111);
            this.dateExpeditionMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateExpeditionMaskedTextBox.Name = "dateExpeditionMaskedTextBox";
            this.dateExpeditionMaskedTextBox.Size = new System.Drawing.Size(222, 22);
            this.dateExpeditionMaskedTextBox.TabIndex = 7;
            this.dateExpeditionMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dateExpeditionMaskedTextBox.Enter += new System.EventHandler(this.MaskedTextBoxEnter);
            this.dateExpeditionMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dateExpeditionMaskedTextBox_Validating);
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.impressionToolStripMenuItem.Text = "Impression";
            this.impressionToolStripMenuItem.Click += new System.EventHandler(this.impressionToolStripMenuItem_Click);
            // 
            // ExpeditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 512);
            this.Controls.Add(this.ExpeditionMenuStrip);
            this.Controls.Add(this.destinataireGroupBox);
            this.Controls.Add(this.colisGroupBox);
            this.Name = "ExpeditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service de l\'expédition";
            this.Load += new System.EventHandler(this.ExpeditionForm_Load);
            this.ExpeditionMenuStrip.ResumeLayout(false);
            this.ExpeditionMenuStrip.PerformLayout();
            this.destinataireGroupBox.ResumeLayout(false);
            this.destinataireGroupBox.PerformLayout();
            this.colisGroupBox.ResumeLayout(false);
            this.colisGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.MenuStrip ExpeditionMenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        internal System.Windows.Forms.Label telephoneLabel;
        internal System.Windows.Forms.Label prixLabel;
        internal System.Windows.Forms.Label prixLLabel;
        internal System.Windows.Forms.Label nomLabel;
        internal System.Windows.Forms.ComboBox zoneComboBox;
        internal System.Windows.Forms.MaskedTextBox nomMaskedTextBox;
        internal System.Windows.Forms.Label adresseLabel;
        internal System.Windows.Forms.Label paiementDuLLabel;
        internal System.Windows.Forms.Label paiementDuLabel;
        internal System.Windows.Forms.Label dateExpeditionLabel;
        internal System.Windows.Forms.MaskedTextBox adresseMaskedTextBox;
        internal System.Windows.Forms.Label zoneLabel;
        internal System.Windows.Forms.Label villeLabel;
        internal System.Windows.Forms.MaskedTextBox villeMaskedTextBox;
        internal System.Windows.Forms.Label provinceLabel;
        internal System.Windows.Forms.ComboBox poidsComboBox;
        internal System.Windows.Forms.GroupBox destinataireGroupBox;
        internal System.Windows.Forms.ComboBox provincesComboBox;
        internal System.Windows.Forms.Label codePostalLabel;
        internal System.Windows.Forms.MaskedTextBox codePostalMaskedTextBox;
        internal System.Windows.Forms.Label poidsLabel;
        internal System.Windows.Forms.GroupBox colisGroupBox;
        internal System.Windows.Forms.MaskedTextBox dateExpeditionMaskedTextBox;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierEnregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
    }
}

