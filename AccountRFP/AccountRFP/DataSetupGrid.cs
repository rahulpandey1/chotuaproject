using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRFP
{
    public class DataSetupGrid
    {
        private object GetDropDownData()
        {
            SortedDictionary<string, int> userCache = new SortedDictionary<string, int>
            {
              {"BFS-LS", 1},
              {"MAF", 2}
            };
            return new BindingSource(userCache, null);
        }
        public static GridData GetNewGridData()
        {
            return new GridData() { 
                no = 1, 
                currentStatus = new SortedDictionary<int, string>() { { 1, "completed" } },
                dealSize="test",
                comments="comments",
                cp= "cp",
                customer = "customer",
                dealDescr= "dealDescr",
                engType= "engType",
                month="day",
                pocName= "pocName",
                vertical = new SortedDictionary<int, string>() { { 1, "vertical" } },
                b2bproducts = new SortedDictionary<int, string>() { { 1, "ss" } }
            };
        }
    }
}
