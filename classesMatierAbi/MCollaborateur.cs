/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace ABI
{

    public class MCollaborateur
    {
        private Int32 matricule;
        private String prenomCollaborateur;
        private String nomCollaborateur;
        private string photoCollaborateur;
        private String numeroSecu;
        private System.Collections.Generic.SortedDictionary<Int32, MContrat> Contrats;
        private System.Data.DataTable dtContrats;

        public MCollaborateur(Int32 Matricule, String prenom, String nom, String photo, String numeroSecu)
        {
            this.PhotoCollaborateur = "photoCollabo";
            this.PrenomCollaborateur = prenom;
            this.NomCollaborateur = nom;
            this.NumeroSecu = numeroSecu;
            this.Matricule = Matricule;

            Contrats = new SortedDictionary<Int32, MContrat>();
            dtContrats = new System.Data.DataTable();
            dtContrats.Columns.Add("Num Contrat", typeof(Int32));
            dtContrats.Columns.Add("Qualification", typeof(String));
            dtContrats.Columns.Add("Statut", typeof(String));
            dtContrats.Columns.Add("Date Debut", typeof(DateTime));
        }

        /// <summary>
        /// Propriete prenom du collaborateur
        /// </summary>
        public String PrenomCollaborateur
        {
            get
            {
                return this.prenomCollaborateur;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Merci de reinseigner un Prénom");
                }
                else
                {
                    this.prenomCollaborateur = value.Trim().ToLower();
                }

            }
        }

        /// <summary>
        /// Propriete Nom du collaborateur
        /// </summary>
        public String NomCollaborateur
        {
            get
            {
                return nomCollaborateur;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Merci de reinseigner un Nom");
                }
                else
                {
                    nomCollaborateur = value.Trim().ToUpper();
                }
            }
        }

        public string PhotoCollaborateur
        {
            get
            {
                return photoCollaborateur;
            }
            set
            {
                if (this.photoCollaborateur != value)
                    this.photoCollaborateur = value;
            }
        }

        /// <summary>
        /// Propriete du Securite sociale
        /// Recupere le numero en strring et verifie qu'il s'agit bien d'un Int de 13 caractères
        /// </summary>
        public String NumeroSecu
        {
            get
            {
                return this.numeroSecu;
            }
            set
            {
                // l'appelant doit fournir un code postal valide à 13 chiffres
                Int32 i;               // variable  de boucle
                Boolean erreur = false; // indicateur erreur
                if (value.Length == 3) // 5 car. attendus : OK ==> contrôler un à un
                {
                    for (i = 0; i < value.Length; i++)  // controle chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i]))) // charabia ??
                        { erreur = true; }

                    } // fin de boucle controle chiffres
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        // levée d'exception
                        throw new Exception(value.ToString() + "\n" + "n'est pas un numero valide : uniquement des chiffres");
                    }
                    else
                    {
                        this.numeroSecu = value;  // tout est bon, on affecte la propriété
                    }
                }
                else // il n'y a pas 13 caractères
                {
                    // levée d'exception
                    throw new Exception(value.ToString() + "\n" + "n'est pas un numero de Secu valide : 13 chiffres, pas plus, pas moins");
                }

            }
        }


        /// <summary>
        /// propriete de la matricule du collaborateur
        /// </summary>
        public int Matricule
        {
            get
            {
                return matricule;
            }

            //TODO : VERIFICATION DE LA MATRICULE

            set
            {
                if (value == 0)
                {
                    throw new Exception("Merci de reinseigner un Nom");
                }
                else
                {

                    matricule = value;

                }
            }
        }

        /// <summary>
        /// Ajoute un contrat à la collection
        /// </summary>
        /// <param name="unContrat"></param>
        public void AjouterContrat(MContrat unContrat)
        {
            if (Contrats.ContainsKey(unContrat.NumeroContrat))
            {
                throw new Exception("Le numero de contrat existe deja ou il est de valeur 0");
            }
            else
            {
                Contrats.Add(unContrat.NumeroContrat, unContrat);
            }
        }

        /// <summary>
        /// Methode qui cherche un contrat dans la collection et le retourne
        /// </summary>
        /// <param name="numContrat"></param>
        /// <returns></returns>
        public MContrat RestituerContrat(Int32 numContrat)
        {
            return Contrats[numContrat];
        }

        /// <summary>
        /// Datat table qui recupere la collection de contrats
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable ListerContrats()
        {
            dtContrats.Clear();
            foreach (MContrat unContrat in this.Contrats.Values)
            {
                this.dtContrats.Rows.Add(unContrat.NumeroContrat, unContrat.Qualification, unContrat.Statut, unContrat.DateDebut);
            }
            return this.dtContrats;
        }

        //initialise la collection 
        public void initialiseListeContrats()
        {
            this.Contrats.Clear();
        }

        public override String ToString()
        {
            // TODO: implement
            return "Matricule : " + Matricule + ". Nom : " + NomCollaborateur + ". Prenom : " + PrenomCollaborateur;
        }
    }
}
