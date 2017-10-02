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

        public static List<MCollaborateur> GetListCollaborateur() {
            if (DonneesDAO.DBContextABI == null)
            {
                DonneesDAO.DBContextABI = new Model1Container();
            }
            List<MCollaborateur> liste = new List<MCollaborateur>();
            //Recupere un collaborateur avec une matricrule specifique
            var query = from a in DonneesDAO.DBContextABI.CollaborateurSet
                        select a;

            MCollaborateur leCollaborateur;

            foreach (Collaborateur item in query)
            {
                //Instancie chaque collaborateur
                leCollaborateur = new MCollaborateur(item.Matricule,
                    item.PrenomCollaborateur,
                    item.NomCollaborateur,
                    item.PhotoCollaborateur,
                    item.NumeroSecu.ToString());

                //Ajoute à la liste de collaborateurs du MListeCollaborateur les collaborateurs recuperés
                liste.Add(leCollaborateur);
            }

            return liste;

        }

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
                    item.PrenomCollaborateur,
                    item.NomCollaborateur,
                    item.PhotoCollaborateur,
                    item.NumeroSecu.ToString());

                //Ajoute à la liste de collaborateurs du MListeCollaborateur les collaborateurs recuperés
                listeCollaborateurs.Ajouter(leCollaborateur);
            }
        }

        public static void ModifCollaborateur(MCollaborateur monCollaborateur)
        {
            Collaborateur unCollaborateur;
            //instancier un dbContext si besoin
            if (DonneesDAO.DBContextABI == null)
            {
                DonneesDAO.DBContextABI = new Model1Container();
            }
            unCollaborateur = DonneesDAO.DBContextABI.CollaborateurSet.Find(monCollaborateur.Matricule);
            unCollaborateur.PrenomCollaborateur = monCollaborateur.PrenomCollaborateur;
            unCollaborateur.NomCollaborateur = monCollaborateur.NomCollaborateur;
            unCollaborateur.PhotoCollaborateur = monCollaborateur.PhotoCollaborateur;
            unCollaborateur.NumeroSecu = Int32.Parse(monCollaborateur.NumeroSecu);
            DonneesDAO.DBContextABI.SaveChanges();
        }

        public static void InserenouveauCollaborateur(MCollaborateur unCollabo, MContrat contrat)
        {
            if (DonneesDAO.DBContextABI == null)
            {
                DonneesDAO.DBContextABI = new Model1Container();
            }
            Collaborateur unCollaboateurEF = new Collaborateur(unCollabo.Matricule,
                unCollabo.PrenomCollaborateur,
                unCollabo.NomCollaborateur,
                unCollabo.PhotoCollaborateur,
                Int32.Parse(unCollabo.NumeroSecu));

           // Contrats contratEf = new Contrats(contrat.NumeroContrat, contrat.Qualification, contrat.SalaireBrut, contrat.DateDebut);
            Contrats contratEF = MContratDAOEFStatic.creerUnContrat(contrat);
            unCollaboateurEF.Contrats.Add(contratEF);
            DonneesDAO.DBContextABI.CollaborateurSet.Add(unCollaboateurEF);
            DonneesDAO.DBContextABI.SaveChanges();

        }

        
    }

}

