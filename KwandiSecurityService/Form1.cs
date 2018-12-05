using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSS.DataLayer.Repository;

namespace KwandiSecurityService
{
    public partial class Login : Form
    {
        private readonly ClientRepository _clientRepository;
        public Login()
        {
            InitializeComponent();
            _clientRepository = new ClientRepository();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            var clients = _clientRepository.GetListOfClients();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var landing = new LandingForm();
            landing.ShowDialog();
        }
    }
}
