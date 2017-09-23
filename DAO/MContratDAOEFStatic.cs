using ABI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MContratDAOEFStatic
    {
        public static void InstancieUnContrat(MCollaborateur leCollaborateur)
        {
            leCollaborateur.initialiseListeContrats();
               
            //instancier un dbContext si besoin
            if (DonneesDAO.DBContextABI == null)
            {
                DonneesDAO.DBContextABI = new Model1Container();
            }

            //Recupere un collaborateur avec une matricrule specifique
            var query = from a in DonneesDAO.DBContextABI.ContratsSet
                        where a.Collaborateur.Matricule == leCollaborateur.Matricule
                        select a;

            MContrat leContrat;

            foreach (Contrats item in query)
            {
                //si le ciontrat c'est un CDI
                if (item is CDI)
                {
                    leContrat = new MCdi(item.NumeroContrat,
                        item.Qualification,
                        item.SalaireBrut,
                        item.DateDebut);
                }
                //Si le contrat est un Interim
               else if(item is Interim)
                {
                    leContrat = new MInterim(item.NumeroContrat,
                        item.Qualification,
                        item.DateDebut,
                        ((Interim)item).DateFin,
                        ((Interim)item).Motf,
                        ((Interim)item).AgenceInterim,
                        ((Interim)item).Indemnites);                        
                }

                //Si le contrat est un cdd
                else if (item is Cdd)
                {
                    leContrat = new MCdd(item.NumeroContrat,
                        item.Qualification,
                        item.SalaireBrut,
                        item.DateDebut,
                        ((Cdd)item).DateFin,
                        ((Cdd)item).Motf);
                }

                //si le contrat est un Stage
                else
                {
                    leContrat = new MStagiaire(item.NumeroContrat,
                        item.Qualification,
                        item.SalaireBrut,
                        item.DateDebut,
                        ((Stage)item).DateFin,
                        ((Stage)item).Motf,
                        ((Stage)item).Ecole,
                        ((Stage)item).Mission);
                }

                leCollaborateur.AjouterContrat(leContrat);
            }
        }
        
       public static Contrats creerUnContrat(MContrat leContrat)
        {
            Contrats unContratEF;

            //si le contrat c'est un CDI
            if (leContrat is MCdi)
            {
                unContratEF = new CDI(leContrat.NumeroContrat,
                    leContrat.Qualification,
                    leContrat.SalaireBrut,
                    leContrat.DateDebut);
                return unContratEF;
            }
            //Si le contrat est un Interim
            else if (leContrat is MInterim)
            {
                unContratEF = new Interim(leContrat.NumeroContrat,
                    leContrat.Qualification,
                    leContrat.DateDebut,
                    ((MInterim)leContrat).DateFin,
                    ((MInterim)leContrat).Motif,
                    ((MInterim)leContrat).AgenceInterim,
                    ((MInterim)leContrat).IndemnitesInterim);
                return unContratEF;
            }

            //Si le contrat est un cdd
            else if (leContrat is MCdd)
            {
                unContratEF = new Cdd(leContrat.NumeroContrat,
                    leContrat.Qualification,
                    leContrat.SalaireBrut,
                    leContrat.DateDebut,
                    ((MCdd)leContrat).DateFin,
                    ((MCdd)leContrat).Motif);
                return unContratEF;
            }

            //si le contrat est un Stage
            else
            {
                unContratEF = new Stage(leContrat.NumeroContrat,
                   leContrat.Qualification,
                    leContrat.SalaireBrut,
                   leContrat.DateDebut,
                    ((MStagiaire)leContrat).DateFin,
                    ((MStagiaire)leContrat).Motif,
                    ((MStagiaire)leContrat).Ecole,
                    ((MStagiaire)leContrat).Mission);
                return unContratEF;
            }
        }
    }
}
