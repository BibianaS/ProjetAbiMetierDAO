/***********************************************************************
 * Module:  Stage.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Stage
 ***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace ABI
{
    [DataContract]
    public class MStagiaire : MTemporaire
    {
        private String ecole;
        private String mission;

        public MStagiaire(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif, String ecole, String mission) : base(numContrat, qualification, salaireBrut, dateDebut, dateFin, motif)
        {
            this.Ecole = ecole;
            this.Mission = mission;
        }


        [DataMember]
        public string Ecole
        {
            get { return this.ecole; }
            set { this.ecole = value; }
        }

        [DataMember]
        public string Mission
        {
            get { return this.mission; }
            set { this.mission = value; }
        }
    }
}