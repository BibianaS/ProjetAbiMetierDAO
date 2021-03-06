/***********************************************************************
 * Module:  Classe6.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Classe6
 ***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace ABI
{
    [DataContract]
    [Serializable]
    [KnownType(typeof(MCdd))]
    [KnownType(typeof(MInterim))]
    [KnownType(typeof(MStagiaire))]

    
    public abstract class MTemporaire : MContrat
    {
        
        private DateTime dateFin;
        private String motif;
        /// <summary>
        /// Constructeur des contrats Stage et Cdd (avec salaire brut)
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFinReel"></param>
        /// <param name="motif"></param>
        public MTemporaire(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif) : base(numContrat, qualification, salaireBrut, dateDebut)
        {
            this.DateFin = dateFin;
            this.Motif = motif;
        }
        /// <summary>
        /// Constructeur le contrat interim (sans salaire brut)
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFinReel"></param>
        /// <param name="motif"></param>
        public MTemporaire(Int32 numContrat, String qualification, DateTime dateDebut, DateTime dateFin, String motif) : base(numContrat, qualification, dateDebut)
        {
            this.DateFin = dateFin;
            this.Motif = motif;
        }

        //M�thode de la date de fin
        [DataMember]
        public DateTime DateFin
        {
            get
            {
                return this.dateFin;
            }
            set
            {
                if (value < DateTime.Today || value < DateDebut)
                {
                    throw new Exception("Merci de reinseigner une date de fin de contrat posterireur � la date d'aujourd'hui");
                }
                else
                {
                    this.dateFin = value;
                }
            }
        }

        //M�thode du motif du contrat
        [DataMember]
        public string Motif
        {
            get
            {
                return this.motif;
            }
            set
            {
                motif = value;
            }
        }
    }
}