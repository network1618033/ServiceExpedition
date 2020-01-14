
/*
    Programmeur:        Nathan Comeau, Jonathan Zogona
    Date:               12/12/2019
    But:                Créer une application qui gère un service d'expédition

    Solution:           ServiceExpedition.sln
    Projet:             ServiceExpedition.csproj
    Classe:             ExpeditionForm.cs

    Phase               J   
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using em = ServiceExpedition.ExpeditionGen.ErrorMessages;

namespace ServiceExpedition
{
    /// <summary>
    /// Classe générale dans la couche présentation
    /// </summary>
    class ExpeditionGen
    {
        #region Champs public static messages d'erreurs

        public static string[] EMMessages = new string[10];

        #endregion 

        #region Enumérations

        public enum ErrorMessages
        {
            EMInfoIncomplet,
            EMetatInvalide,
            EMInitCombobox,
            EMindeterminee,
            EMargumentOutOfRange,
            EMEnregistrer
        }

        #endregion

        #region Initialisation des messages d'erreurs globaux

        /// <summary>
        /// Initialisation du tableau des messages d'erreurs
        /// </summary>
        public static void InitMessages()
        {
            EMMessages[(int)em.EMInfoIncomplet] = "L'information du destinataire ou du colis est incomplète.\r\net est obligatoir pour produire la facture.";
            EMMessages[(int)em.EMetatInvalide] = "Le nom saisi n'est pas un état américain valide.";
            EMMessages[(int)em.EMInitCombobox] = "Erreur lors de l'initialisation des Combobox.";
            EMMessages[(int)em.EMindeterminee] = "Erreur indeterminée. Veuillez joindre le programmeur.";
            EMMessages[(int)em.EMEnregistrer] = "Erreur lors de l'enregistrement des données d'expédition.";
        }

        #endregion
    }
}
