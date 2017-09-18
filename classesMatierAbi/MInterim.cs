/***********************************************************************
 * Module:  Interim.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Interim
 ***********************************************************************/

using System;
namespace ABI
{
    public class MInterim : MTemporaire
    {
        private String agenceInterim;
        private Decimal indemnitesInterim;

        public MInterim(Int32 numContrat, String qualification, DateTime dateDebut, DateTime dateFin, String motif, String agence, Decimal indemnites) : base(numContrat, qualification, dateDebut, dateFin, motif)
        {
            this.AgenceInterim = agence;
            this.IndemnitesInterim = indemnites;
        }

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