﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Contrats
    {
        public Contrats (Int32 numeroContrat, String qualificatioin, Decimal salaire, DateTime dateDeb)
        {
            this.Statut = "Entrepreneur";
            this.NumeroContrat = numeroContrat;
            this.Qualification = qualificatioin;
            this.SalaireBrut = salaire;
            this.DateDebut = dateDeb;
        }
        public Contrats(Int32 numeroContrat, String qualificatioin, DateTime dateDeb)
        {
            this.Statut = "Entrepreneur";
            this.NumeroContrat = numeroContrat;
            this.Qualification = qualificatioin;
            this.DateDebut = dateDeb;
        }

        public Contrats() { }
    }
}
