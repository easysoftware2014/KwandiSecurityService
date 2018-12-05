using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KwandiSecurityService
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kwandiSecurityServiceDataSet4.getclientInformation' table. You can move, or remove it, as needed.
            this.getclientInformationTableAdapter.Fill(this.kwandiSecurityServiceDataSet4.getclientInformation);
            this.clientsTableAdapter1.Fill(this.kwandiSecurityServiceDataSet3.Clients);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpEditClient.Visible = true;

            if (e.RowIndex > -1)
            {
                lblId.Text = clientGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtClientEdit.Text = clientGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtClientContact.Text = clientGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
               
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var newClient = new NewClientForm();
            newClient.ShowDialog();
        }
    }
}
