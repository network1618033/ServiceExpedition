/*
    Programmeur:        Jonathan Zogona
    Date:               12/12/2019
    But:                Créer une application qui gère un service d'expédition

    Solution:           ServiceExpedition.sln
    Projet:             ServiceExpedition.csproj
    Classe:             ExpeditionForm.cs
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ExpeditionR;
using Geographie;
using System.IO;

using gle = ServiceExpedition.ExpeditionGen;
using ce = ServiceExpedition.ExpeditionGen.ErrorMessages;

namespace ServiceExpedition
{
    /// <summary>
    /// Saisie d'une transaction d'expédition d'un colis aux États-Unis ou au Canada
    /// </summary>
    /// <remarks>Tous droits réservés: Comeau Zogona Inc. 2019</remarks>
    public partial class ExpeditionForm : Form
    {
        #region Constructeur

        /// <summary>
        /// Constructeur pour ExpeditionForm
        /// </summary>
        public ExpeditionForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Champs privés

        Expedition oExpedition;

        #endregion

        #region Initialisation: Erreurs, Zones et Poids
        
        private void ExpeditionForm_Load(object sender, EventArgs e)
        {
            gle.InitMessages();

            try
            {
                oExpedition = new Expedition();                

                poidsComboBox.Items.AddRange(oExpedition.GetPoids());
                zoneComboBox.Items.AddRange(oExpedition.GetZones());

                poidsComboBox.SelectedIndex = 0;
                zoneComboBox.SelectedIndex = 0;

                Monde oMonde = new Monde();

                provincesComboBox.Items.AddRange(oMonde.GetRegions((Monde.CodePays)0));
                provincesComboBox.SelectedIndex = 0;

            }
            catch (FileNotFoundException fileEx)
            {
                MessageBox.Show(fileEx.Message);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show(formatEx.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMInitCombobox] + Environment.NewLine +  ex.Message);
            }
        }

        #endregion

        #region Déterminer et afficher le prix du service de livraison selon la catégorie de poids et de la zone de livraison

        private void poidsZoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (zoneComboBox.SelectedIndex != -1 && poidsComboBox.SelectedIndex != -1)
                    prixLabel.Text = oExpedition.GetPrix(poidsComboBox.SelectedIndex, zoneComboBox.SelectedIndex).ToString("C2");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMindeterminee] + Environment.NewLine + ex.Message);
            }
        }

        #endregion
        
        #region Méthodes privées générales

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceExpeditionAboutBox oAboutBox;
                oAboutBox = new ServiceExpeditionAboutBox();
                oAboutBox.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMindeterminee] + Environment.NewLine + ex.Message);
            }
        }

        #endregion

        #region Enregstrer données du formulaire dans un fichier

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                oExpedition.Enregistrer(nomMaskedTextBox.Text,
                    adresseMaskedTextBox.Text,villeMaskedTextBox.Text,provincesComboBox.SelectedItem.ToString(),
                    codePostalMaskedTextBox.Text,telephoneMaskedTextBox.Text,
                    poidsComboBox.SelectedItem.ToString(),zoneComboBox.SelectedItem.ToString(),
                    Decimal.Parse(prixLabel.Text.Trim(), System.Globalization.NumberStyles.Currency),
                    DateTime.Parse(dateExpeditionMaskedTextBox.Text));

                paiementDuLabel.Text = oExpedition.DatePaiementDue.ToLongDateString();
            }
            catch(ArgumentOutOfRangeException argOOREx)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMEnregistrer] + Environment.NewLine + argOOREx.Message);
            }
            catch(ArgumentNullException argNullEx)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMEnregistrer] + Environment.NewLine + argNullEx.Message);
            }
            catch(ArgumentException argEx)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMEnregistrer] + Environment.NewLine + argEx.Message);
            }
            catch(DirectoryNotFoundException dirEx)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMEnregistrer] + Environment.NewLine + dirEx.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(gle.EMMessages[(int)ce.EMEnregistrer] + Environment.NewLine + ex.Message);
            }
        }

        #endregion

        #region Evenement Enter des MaskedTextBox

        private void MaskedTextBoxEnter(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).SelectAll();
        }

        #endregion

        #region Evenement validating de la date d'expedition

        private void dateExpeditionMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            DateTime valideDateDateTime;
            if(DateTime.TryParse((sender as MaskedTextBox).Text, out valideDateDateTime))
            {
                (sender as MaskedTextBox).Text = valideDateDateTime.ToLongDateString();
            }
            else
            {
                (sender as MaskedTextBox).Text = DateTime.Today.ToLongDateString();
            }            
        }

        #endregion

        #region Impression des données dans un fichier texte

        private void impressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                oExpedition.ImprimerTransactions(this.CompanyName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
