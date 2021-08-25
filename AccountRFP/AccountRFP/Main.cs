using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRFP
{
    public partial class Main : Form
    {
        Dictionary<string, string> userInformations =
            new Dictionary<string, string>() { { "Admin", "pwd" }, { "User", "pwd" } };
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text)
                && userInformations.ContainsKey(textBox1.Text) && userInformations[textBox1.Text] == textBox2.Text)
            {
                if (textBox1.Text == "Admin") { new Admin().Show(); this.Hide(); }
                if (textBox1.Text == "User") { new User().Show(); this.Hide(); }
            }
            else { MessageBox.Show("Wrong Credentials"); }
        }
    }
}
