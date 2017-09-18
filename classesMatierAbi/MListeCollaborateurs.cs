/***********************************************************************
 * Module:  ListeSalaries.cs
 * Author:  CDI14
 * Purpose: Definition of the Class ListeSalaries
 ***********************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ABI
{
    public class MListeCollaborateurs
    {
        /// <summary>
        /// Collection de collaborateurs
        /// </summary>
        public SortedDictionary<Int32, MCollaborateur> listeCollaborateurs;
        public System.Data.DataTable dtCollaborateurs;

        /// <summary>
        /// Constructeur liste collaborateurs
        /// </summary>
        public MListeCollaborateurs()
        {
            //instanciation du Dictinary et Table de collaborateurs
            listeCollaborateurs = new SortedDictionary<Int32, MCollaborateur>();
            dtCollaborateurs = new DataTable();


            //Colonnes de la datatTable de collaborateurs
            this.dtCollaborateurs.Columns.Add(new DataColumn(("Matricule"), typeof(System.Int32)));
            this.dtCollaborateurs.Columns.Add(new DataColumn(("Nom"), typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn(("Prenom"), typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn(("Numero SS"), typeof(System.String)));
         }

        /// <summary>
     /// Ajouter un collaborateur a la liste
     /// </summary>
     /// <param name="unCollaborateur"></param>
        public void Ajouter(MCollaborateur unCollaborateur)
        {
            this.listeCollaborateurs.Add(unCollaborateur.Matricule, unCollaborateur);
        }

        /// <summary>
        /// Supprimer un collaborateur de la liste
        /// </summary>
        /// <param name="unCollaborateur"></param>
        public void Modifier(MCollaborateur unCollaborateur)
        {
            this.listeCollaborateurs[unCollaborateur.Matricule] = unCollaborateur;
        }

        /// <summary>
        /// Lister les collaborateus
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable ListerCollaborateurs()
        {
            dtCollaborateurs.Clear();
            foreach (MCollaborateur unCollaborateur in this.listeCollaborateurs.Values)
            {
                dtCollaborateurs.Rows.Add(unCollaborateur.Matricule, unCollaborateur.NomCollabo, unCollaborateur.PrenomCollabo, unCollaborateur.NumeroSS);
            }
            return dtCollaborateurs;
        }
        public MCollaborateur RestituerCollaborateur(Int32 cle)
        {
            MCollaborateur unCollaborateur;
            unCollaborateur = this.listeCollaborateurs[cle] as MCollaborateur;
            if(unCollaborateur == null)
            {
                throw new Exception("Aucun collaborateur avec cette Matricule");
            }
            else
            {
                return unCollaborateur;
            }

        }
    }
}