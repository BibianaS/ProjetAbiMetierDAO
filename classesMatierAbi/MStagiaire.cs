/***********************************************************************
 * Module:  Stage.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stage
 ***********************************************************************/

using System;
namespace ABI
{
    public class MStagiaire : MTemporaire
    {
        private String ecole;

        public MStagiaire(Int32 numContrat, String qualification, Decimal salaireBrut, String mission, DateTime dateDebut, DateTime dateFin, String ecole) : base(numContrat, qualification, salaireBrut, mission, dateDebut, dateFin)
        {
            this.Ecole = ecole;
        }

        public string Ecole
        {
            get
            {
                return this.Ecole;
            }

            set
            {
                this.Ecole = value;
            }
        }
    }
}