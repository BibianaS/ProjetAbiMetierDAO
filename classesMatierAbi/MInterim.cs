/***********************************************************************
 * Module:  Interim.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Interim
 ***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace ABI
{
    [DataContract]
    public class MInterim : MTemporaire
    {
        private String agenceInterim;
        private Decimal indemnitesInterim;

        public MInterim(Int32 numContrat, String qualification, DateTime dateDebut, DateTime dateFin, String motif, String agence, Decimal indemnites) : base(numContrat, qualification, dateDebut, dateFin, motif)
        {
            this.AgenceInterim = agence;
            this.IndemnitesInterim = indemnites;
        }


        //Méthode qui enregistre le nom de l'agence intérim
        [DataMember]
        public string AgenceInterim
        {
            get
            {
                return agenceInterim;
            }

            set
            {
                agenceInterim = value;
            }
        }

        //Méthode qui enregistre les indemnités
        [DataMember]
        public decimal IndemnitesInterim
        {
            get
            {
                return indemnitesInterim;
            }

            set
            {
                indemnitesInterim = value;
            }
        }
    }
}