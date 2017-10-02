/***********************************************************************
 * Module:  Cdi.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdi
 ***********************************************************************/

using System;
using System.Runtime.Serialization;

namespace ABI
{
    [DataContract]
    public class MCdi : MContrat
    {
        /// <summary>
        /// Constructeur avec date de debut uniquement
        /// </summary>
        /// <param name="qualification"></param>
        /// <param name="statut"></param>
        /// <param name="salaireBrut"></param>
        /// <param name="dateFin"></param>
        public MCdi(Int32 numContrat, String qualification, Decimal salaireBrut, DateTime dateDebut) : base(numContrat, qualification, salaireBrut, dateDebut)
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

