/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;
namespace ABI
{
    public abstract class Contrat
    {

        DateTime dateDebut;
        DateTime dateFin;
        private Int32 numeroContrat;
        private String qualification;
        private String statut;
        private Decimal salaireBrut;

        /// <summary>
        /// Constructeur avec date debut et fin de contrat
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        public Contrat(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin)
        {
            this.NumeroContrat = numContrat;
            this.Qualification = qualification;
            this.Statut = statut;
            this.SalaireBrut = salaireBrut;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
        }

        /// <summary>
        /// Constructeur avec date debut de contrat
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        public Contrat(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateDebut)
        {
            this.Qualification = qualification;
            this.Statut = statut;
            this.SalaireBrut = salaireBrut;
            this.DateDebut = dateDebut;
        }

        /// <summary>
        /// Propriete de la qualification
        /// </summary>
        public String Qualification
        {
            get
            {
                return qualification;
            }
            set
            {

            }
        }

        /// <summary>
        /// Propriete du Statut
        /// </summary>
        public String Statut
        {
            get
            {
                return statut;
            }
            set
            {
            }
        }

        /// <summary>
        /// Propriete de la date de debut du contrat
        /// </summary>
        public DateTime DateDebut
        {
            get
            {
                return this.dateDebut;
            }

            set
            {

                Int32 result = DateTime.Compare(value, DateTime.Now);
                if (result > 0)
                {
                    throw new Exception("Merci de reinseigner une date future");
                }
                if (result <= 0)
                {
                    this.dateDebut = value;
                }
            }
        }

        /// <summary>
        /// Propriete du salaire brut
        /// </summary>
        public Decimal SalaireBrut
        {
            get
            {
                return salaireBrut;
            }

            set
            {
                salaireBrut = value;
            }
        }

        /// <summary>
        /// Propriete date fin de contrat
        /// </summary>
        public DateTime DateFin
        {
            get
            {
                return dateFin;
            }

            set
            {
                Int32 result = DateTime.Compare(value, DateTime.Now);
                if (result > 0)
                {
                    throw new Exception("Merci de reinseigner une date future");
                }
                if (result <= 0 && DateDebut <= value)
                {
                    this.dateFin = value;
                }
                else
                {
                    throw new Exception("Verifier la date de debut et fin de contrat");
                }
            }
        }

        public Int32 NumeroContrat
        {
            get
            {
                return numeroContrat;
            }

            set
            {
                numeroContrat = value;
            }
        }

        /// <summary>
        /// Methode qui decrit le contrat
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Date creation du contrat : " + DateTime.Now + ". Numéro de contrat : " + NumeroContrat + ". Qualification : " + Qualification + ". Statut : " + Statut + ". Date debut contrat : " + DateDebut + ". Date de fin : " + DateFin;
        }
    }
}