/***********************************************************************
 * Module:  Cdd.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdd
 ***********************************************************************/

using System;
namespace ABI
{
    public class Cdd : Temporaire
    {

        public Cdd(Int32 numContrat, String qualification, String statut, Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif) : base(numContrat, qualification, statut, salaireBrut, dateDebut, dateFin, motif)
        {

        }


        public override String ToString()
        {

            return base.ToString();
        }
    }
}