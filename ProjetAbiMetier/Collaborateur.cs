/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace ABI
{

    public class Collaborateur
    {
        private static Int32 matricule;
        private String prenomCollabo;
        private String nomCollabo;
        private SByte photoCollabo;
        private String numeroSS;
        private String statutCollaborateur;

        //public TypeDuContrat[] typeDuContrat;

        private System.Collections.Generic.SortedDictionary<Int32, Contrat> Contrats;
        private System.Data.DataTable dtContrats;

        public Collaborateur(String prenom, String nom, String numeroSS, String statut)
        {
            this.PrenomCollabo = prenom;
            this.NomCollabo = nom;
            this.NumeroSS = numeroSS;
            this.StatutCollaborateur = statut;
            Contrats = new SortedDictionary<Int32, Contrat>();
            dtContrats = new System.Data.DataTable();
            dtContrats.Columns.Add("Num Contrat", typeof(Int32));
            dtContrats.Columns.Add("Qualification", typeof(String));
            dtContrats.Columns.Add("Statut", typeof(String));
            dtContrats.Columns.Add("Date Debut", typeof(DateTime));
        }

        /// <summary>
        /// Propriete Matricule
        /// </summary>
        public int Matricule
        {
            get
            {
                return Matricule;
            }
        }

        /// <summary>
        /// Propriete prenom du collaborateur
        /// </summary>

        public String PrenomCollabo
        {
            get
            {
                return this.PrenomCollabo;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Merci de reinseigner un Prénom");
                }
                else
                {
                    this.prenomCollabo = value.Trim().ToLower();
                }

            }
        }

        /// <summary>
        /// Propriete Nom du collaborateur
        /// </summary>
        public String NomCollabo
        {
            get
            {
                return nomCollabo;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Merci de reinseigner un Nom");
                }
                else
                {
                    nomCollabo = value.Trim().ToUpper();
                }
            }
        }


        //public SByte _PhotoCollabo
        //{
        //    get
        //    {
        //        return PhotoCollabo;
        //    }
        //    set
        //    {
        //        if (this.PhotoCollabo != value)
        //            this.PhotoCollabo = value;
        //    }
        //}


        //TODO
        //CHANGER LE NOMBRE DE NUMEROS A 13


        /// <summary>
        /// Propriete du Securite sociale
        /// </summary>
        public String NumeroSS
        {
            get
            {
                return this.numeroSS;
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
                        this.numeroSS = value;  // tout est bon, on affecte la propriété
                    }
                }
                else // il n'y a pas 13 caractères
                {
                    // levée d'exception
                    throw new Exception(value.ToString() + "\n" + "n'est pas un numero de SS valide : 3 chiffres, pas plus, pas moins");
                }

            }
        }

        /// <summary>
        /// Propriete qui define le statud d'un commaborateur
        /// Actif ou inactif
        /// </summary>
        public String StatutCollaborateur
        {
            get
            {
                return statutCollaborateur;
            }
            set
            {
                this.statutCollaborateur = value;
            }
        }


        public void Ajouter(Contrat unContrat)
        {
            if (Contrats.ContainsKey(unContrat.NumeroContrat) || unContrat.NumeroContrat == 0)
            {
                throw new Exception("Le numero de contrat existe deja ou il est de valeur 0");
            }
            else
            {
                Contrats.Add(unContrat.NumeroContrat, unContrat);
            }
        }

        public void Modifier(Contrat unContrat)
        {

        }

        public Contrat Restituer(Int32 numContrat)
        {
            return Contrats[numContrat];
        }

        public override String ToString()
        {
            // TODO: implement
            return "Matricule : " + Matricule + ". Nom : " + NomCollabo + ". Prenom : " + PrenomCollabo;
        }


    }
}