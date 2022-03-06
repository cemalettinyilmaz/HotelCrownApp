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
    public partial class ServiceForm : Form
    {
        private readonly AppDbContext db;

        public ServiceForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceName.Text))
            {
                MessageBox.Show("Fill All Areas");
                return;
            }
            Service newService = new Service() { ServiceName = txtServiceName.Text, UnitPrice = (double)nudPrice.Value };
            db.Services.Add(newService);
            db.SaveChanges();
            FillDgv();
            MessageBox.Show("Services Added");
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            FillDgv();
        }
        void FillDgv()
        {
            dgvService.DataSource = db.Services.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count > 0)
            {
                Service deletedService = (Service)dgvService.SelectedRows[0].DataBoundItem;
                db.Services.Remove(deletedService);
                db.SaveChanges();
                FillDgv();
                MessageBox.Show("Services Deleted");
            }
        }
    }
}
