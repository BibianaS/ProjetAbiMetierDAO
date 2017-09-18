/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;
namespace ABI
{
    public abstract class MContrat
    {
        private Int32 numeroContrat;
        private String qualification;
        private String statut;
        private Decimal salaireBrut;
        DateTime dateDebut;
        DateTime dateFin;

        /// <summary>
        /// Constructeur avec date debut et fin de contrat
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        public MContrat(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin)
        {
            this.NumeroContrat = numContrat;
            this.Qualification = qualification;
            this.SalaireBrut = salaireBrut;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.statut = valStatut(dateDebut, dateFin);
        }

        /// <summary>
        /// Constructeur avec date debut de contrat
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        public MContrat(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut)
        {
            this.NumeroContrat = numContrat;
            this.Qualification = qualification;
            this.SalaireBrut = salaireBrut;
            this.DateDebut = dateDebut;
            this.statut = valStatut(dateDebut, dateFin);
        }

        public MContrat(Int32 numContrat, String qualification, DateTime dateDebut, DateTime dateFin)
        {
            this.NumeroContrat = numContrat;
            this.DateFin = dateFin;
            this.Qualification = qualification;
            this.DateDebut = dateDebut;
            this.statut = valStatut(dateDebut, dateFin);
        }

        /// <summary>
        /// Propriete du numero de contrat
        /// </summary>
        public Int32 NumeroContrat
        {
            get
            {
                return this.numeroContrat;
            }

            set
            {
                this.numeroContrat = value;
            }
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
                this.qualification = value;
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
                statut = value;
            }
        }
        private String valStatut(DateTime dateDebut, DateTime dateFin)
        {
            if (DateFin >= DateTime.Today)
            {
                statut = "Actif";
            }
            else
            {
                statut = "Inactif";
            }
            return Statut;
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

                Int32 result = DateTime.Compare(value, DateTime.Today);
                if (result <= 0)
                {
                    throw new Exception("Merci de reinseigner une date future");
                }
                if (result > 0)
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