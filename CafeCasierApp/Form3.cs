using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCasierApp
{
    public partial class KasirPanelForm : Form
    {
        public KasirPanelForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
