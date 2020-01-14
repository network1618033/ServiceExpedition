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
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;
using System.IO;

using ece = ExpeditionR.Expedition.ECErreurs;

namespace ExpeditionR
{

    /// <summary>
    /// Objet métier : Expédition d'un colis d'un colis
    /// </summary>
    /// <remarks>Tous droits réservés Zogona Inc 2019</remarks>
    public class Expedition
    {
        #region Champs privés

        // Information prix et combobox
        private string[] tPoidsString;
        private string[] tZonesString;
        private Decimal[,] tPrixDecimal;

        // Information de la transaction

        private long idLong;
        private decimal prixDecimal;
        private string nomString;
        private string addresseString;
        private string villeString;
        private string provinceString;
        private string codePostalString;
        private string numeroTelephoneString;
        private string poidsString;
        private string zoneString;
        private DateTime dateExpeditionDateTime;
        private DateTime datePaiementDueDateTime;

        private const char delimiteur = ';';

        // Messages d'erreurs
        private string[] ECEMessages = new string[20];
        private System.Globalization.CultureInfo enCaCultureInfo = new System.Globalization.CultureInfo("en-Ca");

        #endregion

        #region Enumerations

        public enum ECErreurs
        {
            ECENomObligatoire,
            ECEAdresseObligatoire,
            ECEVilleObligatoire,
            ECEProvinceObligatoire,
            ECECodePostalObligatoire,
            ECETelephoneObligatoire,
            ECEPoidsObligatoire,
            ECEZoneObligatoire,
            ECEGetPrixZoneInvalide,
            ECEGetPrixPoidsInvalide,
            ECEPrixInvalide,
            ECEPrixCoincidePas,
            ECEDateInvalide,
            ECEFormatCPInvalide,
            ECEFormatTelephoneInvalide,
            ECEErreurFormatNombre,
            ECEErreurFichierIntrouvable,
            ECEErreurDossierIntrouvable,
            ECExpeditionIncomplete,
            ECEInattendu
        }

        #endregion

        #region Regex

        Regex telephoneRgx = new Regex("^[01]?[- .]?(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$");
        Regex codePostalRgx = new Regex("^([ABCEGHJKLMNPRSTVXY]\\d[ABCEGHJKLMNPRSTVWXYZ])\\ {0,1}(\\d[ABCEGHJKLMNPRSTVWXYZ]\\d)$");

        #endregion

        #region Propriétés

        /// <summary>
        /// Numéro unique d'une transaction
        /// </summary>
        ///<remarks>Généré de facon automatique(lecture seule)</remarks>
        public long Id
        {
            get
            {
                return idLong;
            }
        }

        /// <summary>
        /// Nom du destinataire
        /// </summary>
        public string Nom
        {
            get
            {
                return nomString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        nomString = value;
                    }
                    else
                        throw new ArgumentNullException(ECEMessages[(int)ece.ECENomObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECENomObligatoire]);
            }
        }

        /// <summary>
        /// Adresse du destinataire
        /// </summary>
        public string Adresse
        {
            get
            {
                return addresseString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        addresseString = value;
                    }
                    else
                        throw new ArgumentNullException(ECEMessages[(int)ece.ECEAdresseObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECEAdresseObligatoire]);
            }
        }

        /// <summary>
        /// Ville du destinataire
        /// </summary>
        public string Ville
        {
            get
            {
                return villeString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        villeString = value;
                    }
                    else
                        throw new ArgumentNullException(ECEMessages[(int)ece.ECEVilleObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECEVilleObligatoire]);
            }
        }

        /// <summary>
        /// Province du destinataire
        /// </summary>
        public string Province
        {
            get
            {
                return provinceString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        provinceString = value;
                    }
                    else
                        throw new ArgumentNullException(ECEMessages[(int)ece.ECEProvinceObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECEProvinceObligatoire]);
            }
        }

        /// <summary>
        /// Code postal du destinataire
        /// </summary>
        public string CodePostal
        {
            get
            {
                return codePostalString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        if(codePostalRgx.IsMatch(value))
                        {
                            codePostalString = value;
                        }
                        else
                        {
                            throw new ArgumentException(ECEMessages[(int)ece.ECEFormatCPInvalide]);
                        }  
                    }
                    else
                        throw new ArgumentNullException(ECEMessages[(int)ece.ECECodePostalObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECECodePostalObligatoire]);
            }
        }

        /// <summary>
        /// Numéro de téléphone du destinataire 
        /// </summary>
        public string Telephone
        {
            get
            {
                return numeroTelephoneString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        if(telephoneRgx.IsMatch(value))
                        {
                            numeroTelephoneString = value;
                        }
                        else
                        {
                            throw new ArgumentException(ECEMessages[(int)ece.ECEFormatTelephoneInvalide]);
                        }
                    }
                    else
                        throw new ArgumentNullException(ECEMessages[(int)ece.ECETelephoneObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECETelephoneObligatoire]);
            }
        }

        /// <summary>
        /// Poids du colis expédié
        /// </summary>
        public string Poids
        {
            get
            {
                return poidsString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (Array.IndexOf(tPoidsString, value) != -1)
                    {
                        poidsString = value;
                    }
                    else
                        throw new ArgumentOutOfRangeException(ECEMessages[(int)ece.ECEPoidsObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECEPoidsObligatoire]);
            }
        }

        /// <summary>
        /// Zone d'expédition
        /// </summary>
        public string Zone
        {
            get
            {
                return zoneString;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (Array.IndexOf(tZonesString, value) != -1)
                    {
                        zoneString = value;
                    }
                    else
                        throw new ArgumentOutOfRangeException(ECEMessages[(int)ece.ECEZoneObligatoire]);
                }
                else
                    throw new ArgumentNullException(ECEMessages[(int)ece.ECEZoneObligatoire]);
            }
        }

        /// <summary>
        /// Prix d'expédition du colis
        /// </summary>
        public decimal Prix
        {
            get
            {
                return prixDecimal;
            }
            set
            {
                if (value > 0m)
                {
                    if (zoneString != string.Empty && poidsString != string.Empty)
                    {
                        int indicePoids = Array.IndexOf(tPoidsString, poidsString);
                        int indiceZone = Array.IndexOf(tZonesString, zoneString);
                        if (tPrixDecimal[indicePoids, indiceZone] == value)
                            prixDecimal = value;
                        else
                            throw new ArgumentException(ECEMessages[(int)ece.ECEPrixCoincidePas]);
                    }
                    else
                        throw new ArgumentNullException(ECEMessages[(int)ece.ECEPrixInvalide]);

                }
                else
                    throw new ArgumentOutOfRangeException(ECEMessages[(int)ece.ECEPrixInvalide]);
            }
        }

        /// <summary>
        /// Date d'expédition
        /// </summary>
        public DateTime DateExpedition
        {
            get
            {
                return dateExpeditionDateTime;
            }
            set
            {
                if (DateTime.Compare(DateTime.Today.AddDays(15), value) * DateTime.Compare(value, DateTime.Today.AddDays(-15)) > 0)
                {
                    dateExpeditionDateTime = value;
                    datePaiementDueDateTime = dateExpeditionDateTime.AddDays(30);
                }
                else
                    throw new ArgumentOutOfRangeException(ECEMessages[(int)ece.ECEDateInvalide]);
            }
        }

        /// <summary>
        /// Date de paiement due
        /// </summary>
        public DateTime DatePaiementDue
        {
            get { return datePaiementDueDateTime; }
        }

        #endregion

        #region Initialisation: Tableaux des zones, poids et prix

        /// <summary>
        /// Constructeur d'expedition n'utilisant pas de paramètres
        /// </summary>
        public Expedition()
        {
            InitMessageErreurs();

            InitZones();
            InitPoids();
            InitPrix();
        }

        /// <summary>
        /// Constructeur avec paramètes d'expédition
        /// </summary>
        /// <param name="pNom"> Nom du destinataire</param>
        /// <param name="pAdresse"> Adresse du destinataire</param>
        /// <param name="pVille"> Ville du destinataire</param>
        /// <param name="pProvince"> Province du destinataire</param>
        /// <param name="pCodePostal"> Code Postal du destinataire</param>
        /// <param name="pTelephone"> Numéro de téléphone du destinataire</param>
        /// <param name="pPoids"> Poids du colis à expédier</param>
        /// <param name="pZone"> Zone d'expédition du colis</param>
        /// <param name="pPrix"> Prix de l'expédition du colis</param>
        /// <param name="pDate"> Date d'expédition du colis</param>
        public Expedition(string pNom, string pAdresse, string pVille, string pProvince, string pCodePostal,
                          string pTelephone, string pPoids, string pZone, decimal pPrix, DateTime pDate) : this()
        {
            this.Nom = pNom;
            this.Adresse = pAdresse;
            this.Ville = pVille;
            this.Province = pProvince;
            this.CodePostal = pCodePostal;
            this.Telephone = pTelephone;
            this.Poids = pPoids;
            this.Zone = pZone;
            this.Prix = pPrix;
            this.DateExpedition = pDate;
        }

        /// <summary>
        /// Initialise le tableau contenant les poids de colis disponibles
        /// </summary>
        private void InitPoids()
        {
            try
            {
                using (StreamReader sr = new StreamReader("../../data/CategoriesPoids.data", Encoding.UTF8))
                {
                    int nombre = 0;

                    nombre = int.Parse(sr.ReadLine());

                    Array.Resize(ref tPoidsString, nombre);

                    for (int i = 0; i <= nombre - 1; i++)
                    {
                        tPoidsString[i] = (sr.ReadLine()).Trim();
                    }
                }

            }
            catch (FileNotFoundException fileEx)
            {
                throw new FileNotFoundException(ECEMessages[(int)ece.ECEErreurFichierIntrouvable]);
            }
            catch (FormatException formatEx)
            {
                throw new FormatException(ECEMessages[(int)ece.ECEErreurFormatNombre]);
            }
            catch (Exception ex)
            {
                throw new Exception(ECEMessages[(int)ece.ECEInattendu]);
            }
        }

        /// <summary>
        /// Initialise le tableau contenant les différente zones de livraison
        /// </summary>
        private void InitZones()
        {
            try
            {
                using (StreamReader sr = new StreamReader("../../data/ZonesExpedition.data", Encoding.UTF8))
                {
                    int nombre = 0;

                    nombre = int.Parse(sr.ReadLine());

                    Array.Resize(ref tZonesString, nombre);

                    for(int i = 0; i<= nombre -1;i++)
                    {
                        tZonesString[i] = (sr.ReadLine()).Trim();
                    }
                }

            }
            catch (FileNotFoundException fileEx)
            {
                throw new FileNotFoundException(ECEMessages[(int)ece.ECEErreurFichierIntrouvable]);
            }
            catch(FormatException formatEx)
            {
                throw new FormatException(ECEMessages[(int)ece.ECEErreurFormatNombre]);
            }
            catch (Exception ex)
            {
                throw new Exception(ECEMessages[(int)ece.ECEInattendu]);
            }
        }

        /// <summary>
        /// Initialise le tableau contenant les prix basés sur 
        /// </summary>
        private void InitPrix()
        {
            tPrixDecimal = new Decimal[20, 20];

            try
            {
                using (StreamReader sr = new StreamReader("../../Data/Prix.data"))
                {
                    int nbPoids = tPoidsString.Length;
                    int nbZones = tZonesString.Length;

                    for (int indicePoids = 0; indicePoids <= nbPoids - 1; indicePoids++)
                    {
                        for (int indiceZones = 0; indiceZones <= nbZones - 1; indiceZones++)
                        {
                            tPrixDecimal[indicePoids, indiceZones] =
                            Decimal.Parse((sr.ReadLine()).Trim(), enCaCultureInfo);
                        }
                    }

                    ResizeArray(ref tPrixDecimal, nbPoids, nbZones);
                }
            }
            catch (FormatException formatEx)
            {
                throw new FormatException(ECEMessages[(int)ece.ECEErreurFormatNombre]);
            }
            catch (FileNotFoundException fileEx)
            {
                throw new FileNotFoundException(ECEMessages[(int)ece.ECEErreurFichierIntrouvable]);
            }
            catch (Exception ex)
            {
                throw new Exception(ECEMessages[(int)ece.ECEInattendu]);
            }
        }

        /// <summary>
        /// Initialise les messages d'erreurs
        /// </summary>
        private void InitMessageErreurs()
        {
            ECEMessages[(int)ece.ECEAdresseObligatoire] = "Le champs adresse est obligatoire.";
            ECEMessages[(int)ece.ECECodePostalObligatoire] = "Le champs code postal est obligatoire.";
            ECEMessages[(int)ece.ECENomObligatoire] = "Le champs nom est obligatoire.";
            ECEMessages[(int)ece.ECEPoidsObligatoire] = "Le champs poids est obligatoire.";
            ECEMessages[(int)ece.ECEProvinceObligatoire] = "Le champs province est obligatoire.";
            ECEMessages[(int)ece.ECETelephoneObligatoire] = "Le champs numero de téléphone est obligatoire.";
            ECEMessages[(int)ece.ECEVilleObligatoire] = "Le champs ville est obligatoire.";
            ECEMessages[(int)ece.ECEZoneObligatoire] = "Le champs zone est obligatoire.";
            ECEMessages[(int)ece.ECEGetPrixZoneInvalide] = "Il est impossible d'obtenir le prix à partir de la zone fournie.";
            ECEMessages[(int)ece.ECEGetPrixPoidsInvalide] = "Il est impossible d'obtenir le prix à partir de la poids fournie.";
            ECEMessages[(int)ece.ECEDateInvalide] = "La date n'est pas valide. dateCourante – 15 jours <= valeur <= dateCourante + 15 jours.";
            ECEMessages[(int)ece.ECEPrixInvalide] = "Le prix doit être un entier supérieur à zéro";
            ECEMessages[(int)ece.ECEPrixCoincidePas] = "Le poids, la zone et le prix ne coincide pas.";
            ECEMessages[(int)ece.ECEFormatCPInvalide] = "Format de code postal invalide.";
            ECEMessages[(int)ece.ECEFormatTelephoneInvalide] = "Format de numéro de téléphone invalide.";
            ECEMessages[(int)ece.ECEErreurFormatNombre] = "Erreur lors de la conversion.";
            ECEMessages[(int)ece.ECEErreurFichierIntrouvable] = "Impossible de trouver le fichier en question.";
            ECEMessages[(int)ece.ECEErreurDossierIntrouvable] = "Impossible de trouver le dossier en question.";
            ECEMessages[(int)ece.ECExpeditionIncomplete] = "Le formulaire expédition est incomplet.";
            ECEMessages[(int)ece.ECEInattendu] = "Erreur inattendue. Veuillez contacter le programmeur.";
        }

        #endregion

        #region Méthodes privées

        /// <summary>
        /// Permet de modifier la taille d'un tableau a 2 dimensions
        /// </summary>
        /// <param name="array"> Tableau à être modifié</param>
        /// <param name="x"> Nombre de rangées</param>
        /// <param name="y"> Nombre de colonnes</param>
        /// <remarks>Array.Resize() fonctionne seulement avec un tableau a une dimension</remarks>
        private void ResizeArray(ref decimal[,] array,int x,int y)
        {
            decimal[,] tArray = new decimal[x, y];

            int minRows = Math.Min(x, array.GetLength(0));
            int minCols = Math.Min(y,array.GetLength(1));

            for (int i = 0; i <= minRows - 1; i++)
                for (int j = 0; j <= minCols - 1; j++)
                    tArray[i, j] = array[i, j];

            array = tArray;
        }

        /// <summary>
        /// Permet de vérifier si tous les champs privés sont initialisés
        /// </summary>
        /// <returns>True si les champs sont initialisé et false sinon</returns>
        private Boolean expeditionValide()
        {
            if (nomString != String.Empty &&
                addresseString != String.Empty &&
                villeString != String.Empty &&
                provinceString != String.Empty &&
                codePostalString != String.Empty &&
                numeroTelephoneString != String.Empty &&
                poidsString != String.Empty
                && zoneString != String.Empty && prixDecimal > 0 &&
                dateExpeditionDateTime > DateTime.Parse("0001/01/01") &&
                datePaiementDueDateTime > DateTime.Parse("0001/01/01"))
                return true;
            else
                return false;
        }

        #endregion

        #region Méthodes publiques

        /// <summary>
        /// Méthode pour passer le tableau de zones 
        /// </summary>
        /// <returns>tableau de string tZonesString</returns>
        public string[] GetZones()
        {
            return tZonesString;
        }

        /// <summary>
        /// Méthode pour passer le tableay des poids
        /// </summary>
        /// <returns>tableau de string tPoidsString</returns>
        public string[] GetPoids()
        {
            return tPoidsString;
        }

        /// <summary>
        /// Determiner le prix d'un colis basé sur l'index selectionné dans le comboBox 
        /// </summary>
        /// <param name="indexPoids">indice de la catégorie de poids d'un colis</param>
        /// <param name="indexZone">indice de la description de la zone de livraison</param>
        /// <returns>Prix d'expédition du colis ou zero (decimal)</returns>
        public decimal GetPrix(int indexPoids, int indexZone)
        {
            if (indexPoids >= tPrixDecimal.GetLowerBound(0) && indexPoids <= tPrixDecimal.GetUpperBound(0))
                if (indexZone >= tPrixDecimal.GetLowerBound(1) && indexZone <= tPrixDecimal.GetUpperBound(1))
                    return tPrixDecimal[indexPoids, indexZone];
                else
                    throw new ArgumentOutOfRangeException(ECEMessages[(int)ece.ECEGetPrixZoneInvalide]);
            else
                throw new ArgumentOutOfRangeException(ECEMessages[(int)ece.ECEGetPrixPoidsInvalide]);
        }

        /// <summary>
        /// Determiner le prix d'un colis basé sur l'item selectionné dans le comboBox 
        /// </summary>
        /// <param name="poids">Catégories de poids d'un colis : "1 lvre", "2 livres", etc</param>
        /// <param name="zone">Description de la zone de livraison : "A", "B", etc</param>
        /// <returns>Prix d'expédition ou zero (decimal)</returns>
        public decimal GetPrix(string poids,string zone)
        {
            int indicePoids = Array.IndexOf(tPoidsString, poids);
            int indiceZone = Array.IndexOf(tZonesString, zone);

            if (indicePoids != -1)
                if (indiceZone != -1)
                    return tPrixDecimal[indicePoids, indiceZone];
                else
                    throw new ArgumentException(ECEMessages[(int)ece.ECEGetPrixZoneInvalide]);
            else
                throw new ArgumentException(ECEMessages[(int)ece.ECEGetPrixPoidsInvalide]);
        }

        #endregion

        #region Methodes Publiques : Enregistrer

        /// <summary>
        /// Enregistrer la transaction dans un fichier
        /// </summary>
        public void Enregistrer()
        {
            try
            {
                if(expeditionValide())
                {
                    idLong = DateTime.Now.Ticks;
                    string pathExpeditionDataString = @"../../Data/Expedition.data";

                    using (StreamWriter expeditionStreamWriter = new StreamWriter(pathExpeditionDataString, true, System.Text.Encoding.UTF8))
                    {
                        string enregistrement = "{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}";

                        expeditionStreamWriter.WriteLine(string.Format(enregistrement,
                            this.Id, this.Nom, this.Adresse, this.Ville, this.Province, this.CodePostal, this.Telephone,
                            this.Poids, this.Zone, (this.Prix).ToString(enCaCultureInfo), (this.DateExpedition).ToString(enCaCultureInfo)));
                    }
                }
                else												
                    throw new ArgumentNullException("Transaction d'expédition", ECEMessages[(int)ece.ECExpeditionIncomplete]);

            }
            catch (DirectoryNotFoundException dirEx)
            {
                throw new DirectoryNotFoundException(ECEMessages[(int)ece.ECEErreurDossierIntrouvable]);
            }
            catch (Exception ex)
            {
                throw new Exception(ECEMessages[(int)ece.ECEInattendu]);
            }

        }

        /// <summary>
        /// Enregistrer la transaction courante
        /// </summary>
        /// <param name="pNom">Le nom du destinataire (string)</param>
        /// <param name="pAdresse">L'adresse du destinataire (string)</param>
        /// <param name="pVille">La ville du destinataire (string)</param>
        /// <param name="pProvince">La province du destinataire (string)</param>
        /// <param name="pCodePostal">Le code postal du destinataire (string)</param>
        /// <param name="pTelephone">Le numéro de téléphone du destinataire (string)</param>
        /// <param name="pPoids">La catégorie de poids (string)</param>
        /// <param name="pZone">La zone d'expédition (string)</param>
        /// <param name="pPrix">Le prix de l'expédition (decimal)</param>
        /// <param name="pDate">La date d'expédition (DateTime)</param>
        public void Enregistrer(string pNom, string pAdresse, string pVille, string pProvince, string pCodePostal,
                          string pTelephone, string pPoids, string pZone, decimal pPrix, DateTime pDate)
        {
            this.Nom = pNom;
            this.Adresse = pAdresse;
            this.Ville = pVille;
            this.Province = pProvince;
            this.CodePostal = pCodePostal;
            this.Telephone = pTelephone;
            this.Poids = pPoids;
            this.Zone = pZone;
            this.Prix = pPrix;
            this.DateExpedition = pDate;

            Enregistrer();
        }


        #endregion

        #region Impression des données dans un fichier texte
        
        /// <summary>
        /// Imprimer la transaction en cours
        /// </summary>
        /// <param name="companyName"></param>
        public void ImprimerTransactions(string companyName)
        {
            decimal totalPrix = 0.0M;
            try
            {
                using(StreamReader sr = new StreamReader("../../Data/Expedition.data",Encoding.UTF8))
                using(StreamWriter sw = new StreamWriter("..\\..\\Data\\Impression.data",true,Encoding.UTF8))
                {
                    string[] champs;

                    string ligne = "{0,-30} {1, 10} {2, -5} {3, -17}";

                    sw.WriteLine(companyName + Environment.NewLine);
                    sw.WriteLine(string.Format("{0,-18} {1}", "Membres:", "Jonathan Zogona"));
                    sw.WriteLine(string.Format("{0,-18} {1}", "", "Nathan Comeau") + Environment.NewLine);
                    sw.WriteLine(string.Format("{0,-18} {1}", "Date: ", DateTime.Now.ToLongDateString()) + Environment.NewLine);
                    sw.WriteLine("Liste des prix" + Environment.NewLine);

                    sw.WriteLine(string.Format(ligne, "Numéro de transaction", "Prix", " ", "Date due"));
                    sw.WriteLine(string.Format(ligne, "-----------------------", "--------", " " ,"---------------"));

                    string enregistrement = sr.ReadLine();

                    while(enregistrement != null)
                    {
                        champs = enregistrement.Split(delimiteur);   
                        sw.WriteLine(string.Format(ligne,champs[0],(Decimal.Parse(champs[9])).ToString("C2"), " ", champs[10]));

                        totalPrix += Decimal.Parse(champs[9], enCaCultureInfo);

                        enregistrement = sr.ReadLine();
                    }

                    sw.WriteLine(Environment.NewLine + string.Format("{0,-30} {1, 10}", "Total",totalPrix.ToString("C2")));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
