/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;

namespace ABI
{


    public class Cdi : Contrat
    {
        /// <summary>
        /// Constructeur avecdate de febut et date de fin
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        public Cdi(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin) : base(numContrat, qualification, statut, salaireBrut, dateDebut, dateFin)
        {
        }

        /// <summary>
        /// Constructeur avec date de debut uniquement
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateFin"></param>
        public Cdi(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateFin) : base(numContrat, qualification, statut, salaireBrut, dateFin)
        {
        }

        /// <summary>
        /// Description de la calsse CDI
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return base.ToString();
        }
    }
}

