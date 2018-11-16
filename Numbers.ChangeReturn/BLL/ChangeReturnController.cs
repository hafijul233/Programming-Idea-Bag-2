using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Numbers.ChangeReturn.DAL;

namespace Numbers.ChangeReturn.BLL
{
    public class ChangeReturnController
    {
        public CrpItemsDb crpItems = new CrpItemsDb();

        public List<string> itemsNameList = new List<string>();

        public ChangeReturnController()
        {
            for (int i = 0; i < crpItems.CrpItemsDbList.Count(); i++)
            {
                itemsNameList.Add(crpItems.CrpItemsDbList[i].Name.ToString());
            }
        }
    }
}
