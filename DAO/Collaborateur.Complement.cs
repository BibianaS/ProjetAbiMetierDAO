using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Collaborateur
    {

        public Collaborateur(Int32 matricule, String prenomCollabo, String nomCollabo, String photo, Int32 numeroSecu)
        {
            this.Matricule = matricule;
            this.PrenomCollabo = prenomCollabo;
            this.NomCollabo = nomCollabo;
            this.PhotoCollabo = "photoCollabo";
            this.NumeroSecu = numeroSecu;
            this.Contrats = new HashSet<Contrats>();
        }
    }
}
