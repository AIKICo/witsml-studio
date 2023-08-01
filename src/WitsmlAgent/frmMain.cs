using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WitsmlAgent.WitsmlStoreServiceReference;

namespace WitsmlAgent
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WitsmlStoreClient client = new WitsmlStoreClient();
            string out1, out2;
            client.ClientCredentials.UserName.UserName = "administrator";
            client.ClientCredentials.UserName.Password = "Kabinet95##@";
            client.WMLS_GetCap(string.Empty, out out1, out out2);
            client.Close();
        }
    }
}
