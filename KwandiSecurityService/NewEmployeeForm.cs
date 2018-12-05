using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSS.DataLayer;
using KSS.DataLayer.Entities;
using KSS.DataLayer.Repository;

namespace KwandiSecurityService
{
    public partial class NewEmployeeForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly EmployeeRepository _employeeRepository;

        public NewEmployeeForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _employeeRepository = new EmployeeRepository();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            var status = radEmployed.Checked ? UserStatus.Employed : UserStatus.Unemployed;

            var user = new User
            {
                City = txtCity.Text,
                ContactNumber = txtContactNumber.Text,
                Line1 = txtLine1.Text,
                Line2 = txtLine2.Text,
                Line3 = txtLine3.Text,
                PostalCode = txtPostalCode.Text,
                Name = txtUserName.Text,
                Surname = txtSurname.Text,
                UserStatus = status
            };

            var success = _userRepository.AddUser(user);
            if (success == 1)
            {
                var employee = new Employee
                {
                    UserId = user.Id,
                    Salary = 0,
                    Qualifications = new List<Qualification> { new Qualification { Name = "Security AAA"} }
                };

                _employeeRepository.AddEmployee(employee);

                txtCity.Text = string.Empty;
                txtContactNumber.Text = string.Empty;
                txtLine1.Text = string.Empty;
                txtLine2.Text = string.Empty;
                txtLine3.Text = string.Empty;
                txtPostalCode.Text = string.Empty;
                txtUserName.Text = string.Empty;
                txtSurname.Text = string.Empty;
                radEmployed.Checked = false;
                radUnemployed.Checked = false;
                txtQualificationName.Text = string.Empty;
                txtQualificatioCode.Text = string.Empty;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
