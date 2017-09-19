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
        private String mission;

        public MStagiaire(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif, String ecole, String mission) : base(numContrat, qualification, salaireBrut, dateDebut, dateFin, motif)
        {
            this.Ecole = ecole;
            this.Mission = mission;
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

        public string Mission { get => mission; set => mission = value; }
    }
}