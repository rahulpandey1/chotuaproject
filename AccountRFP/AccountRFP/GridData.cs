using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRFP
{
    public class GridData
    {
        //this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.vertical = new System.Windows.Forms.DataGridViewComboBoxColumn();
        //this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.b2bproducts = new System.Windows.Forms.DataGridViewComboBoxColumn();
        //this.dealDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.engType = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.dealSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.currentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
        //this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.pocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
        public int no { get; set; }
        public SortedDictionary<int, string> vertical { get; set; }
        public string customer { get; set; }
        public SortedDictionary<int, string> b2bproducts { get; set; }
        public string dealDescr { get; set; }
        public string engType { get; set; }
        public string dealSize { get; set; }
        public string cp { get; set; }
        public SortedDictionary<int, string> currentStatus { get; set; }
        public string comments { get; set; }
        public string pocName { get; set; }
        public string month { get; set; }        
    }
}
