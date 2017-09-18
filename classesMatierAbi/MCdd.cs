/***********************************************************************
 * Module:  Cdd.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Cdd
 ***********************************************************************/

using System;
namespace ABI
{
    public class MCdd : MTemporaire
    {
        public MCdd(Int32 numContrat, String qualification,  Decimal salaireBrut, DateTime dateDebut, DateTime dateFin, String motif) : base(numContrat, qualification, salaireBrut, dateDebut, dateFin, motif)
        {

        }
        
        public override String ToString()
        {

            return base.ToString();
        }
    }
}