using ABI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MCollaborateurDAOEFStatic
    {

        /// <summary>
        /// Recuèere une liste de collaborateurs vide
        /// Recupère chaque collaborateur de la BDD
        /// Ajoute chaque collaborateur à la liste recuperée par paramètre
        /// </summary>
        /// <param name="listeCollaborateurs"></param>        
        public static void InstancieCollaborateur(MListeCollaborateurs listeCollaborateurs)
        {
            //instancier un dbContext si besoin
            if (DonneesDAO.DBContextABI == null)
            {
                DonneesDAO.DBContextABI = new Model1Container();
            }

            //Recupere un collaborateur avec une matricrule specifique
            var query = from a in DonneesDAO.DBContextABI.CollaborateurSet
                        select a;

            MCollaborateur leCollaborateur;

            foreach (Collaborateur item in query)
            {
                //Instancie chaque collaborateur
                leCollaborateur = new MCollaborateur(item.Matricule,
                    item.PrenomCollabo,
                    item.NomCollabo,
                    item.NumeroSS.ToString());

                //Ajoute à la liste de collaborateurs du MListeCollaborateur les collaborateurs recuperés
                listeCollaborateurs.Ajouter(leCollaborateur);
            }            
        }


        public static void InsereCollaborateur(MCollaborateur unCollabo)
        {
            if (DonneesDAO.DBContextABI == null)
            {
                DonneesDAO.DBContextABI = new Model1Container();
            }
            Collaborateur unCollaboateurEF = null;

            unCollaboateurEF = new Collaborateur(unCollabo.Matricule,
                unCollabo.PrenomCollabo,
                unCollabo.NomCollabo,
                unCollabo.PhotoCollabo,
                Int32.Parse(unCollabo.NumeroSS));
            try
            {
                DonneesDAO.DBContextABI.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //unCollaboateurEF.Contrats = unCollabo.
        }

    }

}
