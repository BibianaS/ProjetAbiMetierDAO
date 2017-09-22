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
               if(item is Interim)
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
                if (item is Cdd)
                {
                    leContrat = new MCdd(item.NumeroContrat,
                        item.Qualification,
                        item.SalaireBrut,
                        item.DateDebut,
                        ((Interim)item).DateFin,
                        ((Interim)item).Motf);
                }

                //si le contrat est un Stage
                if(item is Stage)
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
                //leCollaborateur.AjouterContrat(leContrat);
            }
        }


        //public static ICollection<Contrats> InsereContrat(MContrat unContrat)
        //{
        //    if (DonneesDAO.DBContextABI == null)
        //    {
        //        DonneesDAO.DBContextABI = new Model1Container();
        //    }

        //    Contrats unContratEF = null;

        //    //si le ciontrat c'est un CDI
        //    if (unContrat is MCdi)
        //    {
        //            unContratEF = new CDI(unContrat.NumeroContrat,
        //            unContrat.Qualification,
        //            unContrat.SalaireBrut,
        //            unContrat.DateDebut);
        //    }
        //    //Si le contrat est un Interim
        //    if (unContrat is MInterim)
        //    {
        //        unContratEF = new Interim(unContrat.NumeroContrat,
        //            unContrat.Qualification,
        //            0,
        //            unContrat.DateDebut,
        //            ((MInterim)unContrat).DateFin,
        //            ((MInterim)unContrat).Motif,
        //            ((MInterim)unContrat).AgenceInterim,
        //            ((MInterim)unContrat).IndemnitesInterim);
        //    }

        //    //Si le contrat est un cdd
        //    if (unContrat is MCdd)
        //    {
        //        unContratEF = new Cdd(unContrat.NumeroContrat,
        //            unContrat.Qualification,
        //            unContrat.SalaireBrut,
        //            unContrat.DateDebut,
        //            ((MCdd)unContrat).DateFin,
        //            ((MCdd)unContrat).Motif);
        //    }

        //    //si le contrat est un Stage
        //    if (unContrat is MStagiaire)
        //    {
        //        unContratEF = new Stage(unContrat.NumeroContrat,
        //            unContrat.Qualification,
        //            unContrat.SalaireBrut,
        //            unContrat.DateDebut,
        //            ((MStagiaire)unContrat).DateFin,
        //            ((MStagiaire)unContrat).Motif,
        //            ((MStagiaire)unContrat).Ecole,
        //            ((MStagiaire)unContrat).Mission);
        //    }

        //    try
        //    {
        //        DonneesDAO.DBContextABI.ContratsSet.Add(unContratEF);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
            
        //    //unCollaboateurEF.Contrats = unCollabo.
        //   //leCollaborateur.AjouterContrat(leContrat);
        //}

    }
}
