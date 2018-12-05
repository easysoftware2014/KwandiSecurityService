using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwandiSecurityService
{
    public partial class ucBaseControl : UserControl
    {
        public ucBaseControl()
        {
            InitializeComponent();
        }

        private void ucBaseControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
