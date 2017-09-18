/***********************************************************************
 * Module:  Interim.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Interim
 ***********************************************************************/

using System;
namespace ABI
{
    public class Interim : Temporaire
    {
        private String agenceInterim;
        private Decimal indemnitesInterim;


        public Interim(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif, String agence, Decimal indemnites) : base(numContrat, qualification, statut, salaireBrut, dateDebut, dateFin, motif)
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