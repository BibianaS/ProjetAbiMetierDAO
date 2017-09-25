using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Collaborateur
    {

        public Collaborateur(Int32 matricule, String prenomCollaborateur, String nomCollaborateur, String photo, Int32 numeroSecu)
        {
            this.Matricule = matricule;
            this.PrenomCollaborateur = prenomCollaborateur;
            this.NomCollaborateur = nomCollaborateur;
            this.PhotoCollaborateur = "photoCollaborateur";
            this.NumeroSecu = numeroSecu;
            this.Contrats = new HashSet<Contrats>();
        }
    }
}
