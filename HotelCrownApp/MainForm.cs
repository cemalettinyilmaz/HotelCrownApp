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
    public partial class MainForm : Form
    {
        AppDbContext db = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void tsmCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm(db);
            customersForm.ShowDialog();
        }

        private void tsmRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm(db);
            roomsForm.ShowDialog();

        }

        private void tsmFeatures_Click(object sender, EventArgs e)
        {
            FeatureForm featureForm = new FeatureForm(db);
            featureForm.ShowDialog();
        }

        private void tsmServices_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm(db);
            serviceForm.ShowDialog();
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm(db);
            reservationForm.ShowDialog();
            FillDgv();
        }

        void FillDgv()
        {
            dgvReservations.Rows.Clear();
            foreach (var reservation in db.Reservations.ToList())
            {
                dgvReservations.Rows.Add(reservation.ReservationId,
                                            reservation.Room.RoomName,
                                            reservation.CheckInDate.Date.ToShortDateString(),
                                            reservation.CheckOutDate.Date.ToShortDateString(),
                                            reservation.CheckedInTime,
                                            reservation.CheckedOutTime,
                                            string.Join(",", reservation.Customers.Select(x => x.Customer.FullName)));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool sonuc = false;
            if (rbInTrue.Checked)
                sonuc = true;
            else if (rbInFalse.Checked)
                sonuc = false;
            bool sonucOut = false;
            if (rbOutTrue.Checked)
                sonucOut = true;
            if (rbOutFalse.Checked)
                sonucOut = false;

            dgvReservations.Rows.Clear();
            foreach (var reservation in db.Reservations.ToList())
            {
                if (dtpFrom.Value.Date >= reservation.CheckInDate.Date && dtpTo.Value.Date <= reservation.CheckOutDate.Date && reservation.CheckedInTime == sonuc && reservation.CheckedOutTime == sonucOut && reservation.Room.RoomName.Contains(txtSearch.Text))
                    dgvReservations.Rows.Add(reservation.ReservationId,
                                       reservation.Room.RoomName,
                                       reservation.CheckInDate.Date.ToShortDateString(),
                                       reservation.CheckOutDate.Date.ToShortDateString(),
                                       reservation.CheckedInTime,
                                       reservation.CheckedOutTime,
                                       string.Join(",", reservation.Customers.Select(x => x.Customer.FullName)));
                else if (rbAll.Checked || rbOutAll.Checked)
                    dgvReservations.Rows.Add(reservation.ReservationId,
                                       reservation.Room.RoomName,
                                       reservation.CheckInDate.Date.ToShortDateString(),
                                       reservation.CheckOutDate.Date.ToShortDateString(),
                                       reservation.CheckedInTime,
                                       reservation.CheckedOutTime,
                                       string.Join(",", reservation.Customers.Select(x => x.Customer.FullName)));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservations.Rows.Count > 0)
            {
                int deleteReservationID = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
                Reservation deleteReservation = db.Reservations.FirstOrDefault(x => x.ReservationId == deleteReservationID);
                DialogResult result = MessageBox.Show("Reservation will delete.Are you sure?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.Reservations.Remove(deleteReservation);
                    db.SaveChanges();
                    FillDgv();
                    MessageBox.Show("Reservation deleted");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReservations.Rows.Count > 0)
            {
                int updateReservationID = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
                Reservation updateReservation = db.Reservations.FirstOrDefault(x => x.ReservationId == updateReservationID);
                ReservationUpdateForm updateForm = new ReservationUpdateForm(db, updateReservation);
                updateForm.ShowDialog();
                FillDgv();

            }
        }



        private void dgvReservations_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var hti = dgvReservations.HitTest(e.X, e.Y);
                if (hti.RowIndex > 0)
                {
                    dgvReservations.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void checkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Has the customer checked into the hotel?", "Checked-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int reservationId = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
                    Reservation reservation = db.Reservations.FirstOrDefault(x => x.ReservationId == reservationId);
                    reservation.CheckedInTime = true;
                    db.SaveChanges();
                    FillDgv();
                }

            }
        }

        private void checkedOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Has the customer checked out the hotel?", "Checked-In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int reservationId = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
                    Reservation reservation = db.Reservations.FirstOrDefault(x => x.ReservationId == reservationId);
                    reservation.CheckedOutTime = true;
                    reservation.CheckOutDate = DateTime.Now;
                    db.SaveChanges();
                    FillDgv();
                }

            }
        }

        private void ınvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int reservationId = (int)dgvReservations.SelectedRows[0].Cells[0].Value;
                Reservation reservation = db.Reservations.FirstOrDefault(x => x.ReservationId == reservationId);
                InvoiceForm ınvoice = new InvoiceForm(db, reservation);
                ınvoice.ShowDialog();

            }
        }
    }
}

