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
    public partial class FeatureForm : Form
    {
        private readonly AppDbContext db;

        public FeatureForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFeatureName.Text))
            {
                if (btnAdd.Text == "Add")
                {
                    Feature feature = new Feature()
                    {
                        FeatureName = txtFeatureName.Text
                    };
                    db.Features.Add(feature);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Feature Added");
                        txtFeatureName.Clear();

                    }

                }
                else
                {
                    featureUpdate.FeatureName = txtFeatureName.Text;
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Feature Update");
                        txtFeatureName.Clear();
                        btnAdd.Text = "Add";
                        btnCancel.Visible = false;
                    }

                }
                fillDgv();
            }
            else
            {
                MessageBox.Show("Fill Feature Name");
            }
        }

        private void FeatureForm_Load(object sender, EventArgs e)
        {
            dgvFeature.DataSource = db.Features.ToList();
        }
        Feature featureUpdate;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            featureUpdate = (Feature)dgvFeature.SelectedRows[0].DataBoundItem;
            txtFeatureName.Text = featureUpdate.FeatureName;
            btnAdd.Text = "Update";
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvFeature.SelectedRows.Count > 0)
            {
                btnAdd.Text = "Add";
                txtFeatureName.Clear();
                btnCancel.Visible = false;

            }
        }
        void fillDgv()
        {
            dgvFeature.DataSource = db.Features.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Feature deleteFeature = new Feature();
            deleteFeature = (Feature)dgvFeature.SelectedRows[0].DataBoundItem;
            db.Features.Remove(deleteFeature);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Feature Deleted");
            }
            fillDgv();
        }
    }
}
