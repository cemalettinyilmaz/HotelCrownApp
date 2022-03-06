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
    public partial class RoomsForm : Form
    {
        private readonly AppDbContext db;

        public RoomsForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            FillDgvs();
        }

        void FillDgvs()
        {
            dgvRoomList.DataSource = db.Rooms.ToList();
            dgvAllFeatures.DataSource = db.Features.ToList();
        }

        private void dgvRoomList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomName.Text) && nudCapacity.Value == 0)
            {
                MessageBox.Show("Fill All Area");
                return;
            }
            if (btnAdd.Text == "Add")
            {
                Room newRoom = new Room();
                newRoom.RoomName = txtRoomName.Text;
                newRoom.Capacity = (int)nudCapacity.Value;
                newRoom.Price = (double)nudPrice.Value;
                if (dgvRoomFeatures.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvRoomFeatures.RowCount; i++)
                    {
                        int featureId = (int)dgvRoomFeatures.Rows[i].Cells[0].Value;
                        RoomFeature newFeature = new RoomFeature();
                        newFeature.Feature = db.Features.FirstOrDefault(x => x.FeatureId == featureId);
                        newRoom.Features.Add(newFeature);
                    }
                }
                db.Rooms.Add(newRoom);
                if (db.SaveChanges() > 0)
                {
                    FillDgvs();
                    MessageBox.Show("Room Added");
                }
            }
        }

        private void btnAddFeature_Click(object sender, EventArgs e)
        {
            if (dgvAllFeatures.Rows.Count > 0 && dgvAllFeatures.SelectedRows.Count > 0)
            {
                Feature newFeature = (Feature)dgvAllFeatures.SelectedRows[0].DataBoundItem;
                dgvRoomFeatures.Rows.Add(newFeature.FeatureId, newFeature.FeatureName);
            }
        }

        private void btnDeleteFeature_Click(object sender, EventArgs e)
        {
            if (dgvRoomFeatures.SelectedRows.Count > 0)
            {
                dgvRoomFeatures.Rows.Remove(dgvRoomFeatures.SelectedRows[0]);
            }
        }
        bool click = false;
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (click == false)
            {
                this.Size = MaximumSize;
                click = true;
            }
            else
            {
                this.Size = MinimumSize;
                click = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoomList.SelectedRows.Count > 0)
            {
                Room deleteRoom = (Room)dgvRoomList.SelectedRows[0].DataBoundItem;
                db.Rooms.Remove(deleteRoom);
                db.SaveChanges();
                FillDgvs();
                MessageBox.Show("Room Deleted");
            }
        }
    }
}
