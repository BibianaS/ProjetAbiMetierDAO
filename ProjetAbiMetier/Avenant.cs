/***********************************************************************
 * Module:  Avenant.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Avenant
 ***********************************************************************/

using System;

namespace ABI
{
    public class Avenant
    {
        public Avenant(DateTime date, String qualification, String statut, String libelle)
        {
            // TODO: implement
        }

        public override String ToString()
        {
            // TODO: implement
            return null;
        }

        private String Libelle;

        public String _Libelle
        {
            get
            {
                return Libelle;
            }
            set
            {
                if (this.Libelle != value)
                    this.Libelle = value;
            }
        }

    }
}