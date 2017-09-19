using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MCollaborateurDAOEFStatic
    {
        //instanciation du db context si null
        public static void InstancieCollaborateur()
        {
            if(DonneesDAO.DBContextABI == null)
            {
                DonneesDAO.DBContextABI = new ABIContainer();
            }

           
        }
    }
}
