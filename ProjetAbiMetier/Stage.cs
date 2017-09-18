/***********************************************************************
 * Module:  Stage.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stage
 ***********************************************************************/

using System;
namespace ABI
{
    public class Stagiaire : Temporaire
    {


        private String ecole;

        public Stagiaire(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, String mission, DateTime dateDebut, DateTime dateFin, String ecole) : base(numContrat, qualification, statut, salaireBrut, mission, dateDebut, dateFin)
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