using HotelCrownApp.HotelCrown.Data;
using HotelCrownApp.HotelCrown.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCrownApp
{
    public partial class CustomersForm : Form
    {
        private readonly AppDbContext db;

        public CustomersForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            FillDgv();
            dtpBirthdate.MaxDate = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesc.Text) || string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtIdentyNumber.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Fill All Areas");
                return;
            }
            if (btnAdd.Text == "Add")
            {
                Customer customer = new Customer()
                {
                    FullName = txtFullName.Text,
                    IdentityNumber = txtIdentyNumber.Text,
                    Birthdate = dtpBirthdate.Value,
                    PhoneNumber = txtPhoneNumber.Text,
                    Description = txtDesc.Text,
                    Gender = (Gender)cmbGender.SelectedValue
                };
                db.Customers.Add(customer);
                db.SaveChanges();
                FillDgv();
                ClearAreas();
                MessageBox.Show("Costumer Added");
            }
            else
            {
                updateCustomer.FullName = txtFullName.Text;
                updateCustomer.IdentityNumber = txtIdentyNumber.Text;
                updateCustomer.Birthdate = dtpBirthdate.Value;
                updateCustomer.PhoneNumber = txtPhoneNumber.Text;
                updateCustomer.Description = txtDesc.Text;
                updateCustomer.Gender = (Gender)cmbGender.SelectedValue;
                db.SaveChanges();
                FillDgv();
                ClearAreas();
                MessageBox.Show("Costumer Updated");
                btnAdd.Text = "Add";
            }
        }
        void FillDgv()
        {
            dgvCostumer.DataSource = db.Customers.ToList();
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));
            cmbGender.SelectedIndex = 0;
        }
        void ClearAreas()
        {
            txtDesc.Clear();
            txtFullName.Clear();
            txtIdentyNumber.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCostumer.SelectedRows.Count > 0)
            {
                Customer deletedCustomer = (Customer)dgvCostumer.SelectedRows[0].DataBoundItem;
                DialogResult result = MessageBox.Show(deletedCustomer.FullName + " regist will delete. Are you sure?", "Delete", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    db.Customers.Remove(deletedCustomer);
                    db.SaveChanges();
                    FillDgv();
                    MessageBox.Show("Costumer deleted");
                }

            }
        }
        Customer updateCustomer;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCostumer.SelectedRows.Count > 0)
            {
                updateCustomer = (Customer)dgvCostumer.SelectedRows[0].DataBoundItem;
                txtFullName.Text = updateCustomer.FullName;
                txtDesc.Text = updateCustomer.Description;
                txtIdentyNumber.Text = updateCustomer.IdentityNumber;
                txtPhoneNumber.Text = updateCustomer.PhoneNumber;
                dtpBirthdate.Value = updateCustomer.Birthdate;
                cmbGender.SelectedItem = updateCustomer.Gender;
                btnAdd.Text = "Update";
                btnCancel.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
            ClearAreas();
            btnCancel.Visible = false;
        }
    }
}
