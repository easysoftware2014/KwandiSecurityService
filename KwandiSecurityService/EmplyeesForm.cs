using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSS.DataLayer.Repository;

namespace KwandiSecurityService
{
    public partial class EmplyeesForm : Form
    {
        private readonly UserRepository _userRepository;
        public EmplyeesForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void EmplyeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kwandiSecurityServiceDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.kwandiSecurityServiceDataSet2.Users);

            //var users = _userRepository.GetAllUsers();
            //foreach (var user in users)
            //{
            //    name.Name = user.Name;

            //}
            //var newUser = (from us in users
            //                select new
            //                {
            //                    us.Name,
            //                    us.Surname,
            //                    us.ContactNumber,
            //                    us.IdNumber,
            //                    us.UserStatus
            //                }).ToList();

            //empGridView.DataSource = newUser;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpExistingEmployees.Visible = true;
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var newEmployee = new NewEmployeeForm();
            newEmployee.ShowDialog();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                kwandiSecurityServiceDataSet1.Tables["Users"].DefaultView.RowFilter = $"Name LIKE '{txtSearch.Text}%'";
            }
            
        }

        private void empGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpEditEmployee.Visible = true;

            if (e.RowIndex > -1)
            {
                lblId.Text = empGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNamEdit.Text = empGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSurnameEdit.Text = empGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtContactEdit.Text = empGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                var status = Convert.ToInt32(empGridView.Rows[e.RowIndex].Cells[5].Value);

                if (status == 1)
                    radEmplyedEdit.Checked = true;
                else
                    radUnEmployedEdit.Checked = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addNew = new NewEmployeeForm();
            addNew.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            grpEditEmployee.Visible = false;
            var client = new Clients();
            client.ShowDialog();
        }
    }
}
