
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
using System.IO;


using cp = Geographie.Monde.CodePays;

namespace Geographie
{
    /// <summary>
    /// Objet métier : Régions ou provinces des pays de livraison d'un colis
    /// </summary>
    /// <remarks>Tous droits réservés Comeau Zogona Inc 2019</remarks>
    public class Monde
    {
        #region Champs privés

        private string[] tCanada;
        private string[] tEtatsUnis;

        #endregion

        #region Enumerations

        public enum CodePays
        {
            CPCanada,
            CPEtatsUnis
        }

        #endregion

        #region Constructeur de la classe

        /// <summary>
        /// Constructeur sans paramètre
        /// </summary>
        public Monde()
        {
            InitEtats();
            InitProvinces();
        }

        #endregion

        #region Methodes Privées : Initialisation des régions

        #region Initialisation tableau États-Unis
        
        /// <summary>
        /// Initialisation du tableau des États américains
        /// </summary>
        private void InitEtats()
        {

            try
            {
                using (StreamReader sr = new StreamReader("../../data/EtatsAmericains.data", Encoding.UTF8))
                {
                    tEtatsUnis = new string[100];

                    string etatString;

                    int i = 0;

                    etatString = sr.ReadLine();

                    while (etatString != null)
                    {
                        tEtatsUnis[i] = etatString;
                        etatString = sr.ReadLine();
                        i++;
                    }

                    Array.Resize(ref tEtatsUnis, i);
                }

            }
            catch (FileNotFoundException fileEx)
            {
                throw new FileNotFoundException("Impossible d'acceder au fichier.", fileEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur inattendue.");
            }
        }
        
        #endregion
            
        #region Initialisation tableau Canada

        private void InitProvinces()
        {

            try
            {
                using(StreamReader sr =  new StreamReader("../../data/ProvincesCanada.data",Encoding.UTF8))
                {
                    tCanada = new string[50];

                    string provinceString;
                    int  i = 0;

                    provinceString = sr.ReadLine();

                    while(provinceString != null)
                    {
                        tCanada[i] = provinceString;
                        provinceString = sr.ReadLine();
                        i++;
                    }

                    Array.Resize(ref tCanada, i);
                }

            }
            catch(FileNotFoundException fileEx)
            {
                throw new FileNotFoundException("Impossible d'acceder au fichier.",fileEx.Message);
            }
            catch(Exception ex)
            {
                throw new Exception("Erreur inattendu.");
            }
            
        }

        #endregion
        
        #endregion

        #region Methodes publiques : Régions

        /// <summary>
        /// Recupération des regions en fonction du pays choisi
        /// </summary>
        /// <param name="pays">Pays choisi</param>
        /// <returns>La liste des régions choisies (string[])</returns>
        public string[] GetRegions(CodePays pays)
        {
            string[] getRegions;

            switch(pays)
            {
                case cp.CPCanada:
                    getRegions = tCanada;
                    break;
                case cp.CPEtatsUnis:
                    getRegions = tEtatsUnis;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Erreur dans les régions");
            }

            return getRegions;
        }

        #endregion
    }
}
