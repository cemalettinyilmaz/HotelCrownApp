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
    public partial class ReservationForm : Form
    {
        private readonly AppDbContext db;

        public ReservationForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            cmbFill();
            FillDgvCustomer();
            FillDgvReservation();
        }
        void FillDgvReservation()
        {
            dgvReservation.Rows.Clear();
            foreach (var reservation in db.Reservations.ToList())
            {
                dgvReservation.Rows.Add(reservation.ReservationId, reservation.Room.RoomName, reservation.CheckInDate, reservation.CheckOutDate, string.Join(",", reservation.Customers.Select(x => x.Customer.FullName)));
            }
        }
        void FillDgvCustomer()
        {
            dgvAllCostumer.DataSource = db.Customers.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvReservationCostumer.Rows.Count <= 0)
            {
                MessageBox.Show("You must to add customer on reservation !");
                return;
            }
            Reservation newReservation = new Reservation();
            newReservation.Room = (Room)cmbRooms.SelectedItem;
            newReservation.CheckInDate = dtpInDate.Value;
            newReservation.CheckOutDate = dtpOutDate.Value;
            newReservation.CheckedInTime = false;
            newReservation.CheckedOutTime = false;

            for (int i = 0; i < dgvReservationCostumer.Rows.Count; i++)
            {
                if (dgvReservationCostumer.Rows.Count > 0)
                {
                    int customerId = (int)dgvReservationCostumer.Rows[i].Cells[0].Value;
                    ReservationCustomer reservationCustomer = new ReservationCustomer();
                    reservationCustomer.Customer = db.Customers.FirstOrDefault(x => x.CustomerId == customerId);
                    newReservation.Customers.Add(reservationCustomer);
                }

            }
            foreach (var reservation in db.Reservations.ToList())
            {
                if ((newReservation.CheckInDate.Date >= reservation.CheckInDate.Date && newReservation.CheckInDate.Date < reservation.CheckOutDate.Date) || (newReservation.CheckOutDate.Date >= reservation.CheckInDate.Date && newReservation.CheckOutDate.Date < reservation.CheckOutDate.Date))
                {
                    MessageBox.Show("The room is full at this time.");
                    return;
                }
            }


            db.Reservations.Add(newReservation);
            if (db.SaveChanges() > 0)
            {
                FillDgvReservation();
                MessageBox.Show("Reservation Added");
                dgvReservationCostumer.Rows.Clear();
            }

        }

        void cmbFill()
        {
            if (db.Rooms.Any())
            {
                cmbRooms.DataSource = db.Rooms.ToList();
                cmbRooms.DisplayMember = ("RoomName");
                cmbRooms.SelectedIndex = 0;
            }
            else
            {
                DialogResult result = MessageBox.Show("No rooms found. Want to add a room?", "No Rooms", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RoomsForm roomsForm = new RoomsForm(db);
                    roomsForm.ShowDialog();
                    cmbFill();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnAddCostumer_Click(object sender, EventArgs e)
        {
            if (dgvAllCostumer.Rows.Count > 0)
            {
                Customer newCustomer = (Customer)dgvAllCostumer.SelectedRows[0].DataBoundItem;
                for (int i = 0; i < dgvReservationCostumer.Rows.Count; i++)
                {
                    if ((int)dgvReservationCostumer.Rows[i].Cells[0].Value == newCustomer.CustomerId)
                    {
                        return;
                    }
                }
                dgvReservationCostumer.Rows.Add(newCustomer.CustomerId, newCustomer.FullName);
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm(db);
            customersForm.ShowDialog();
            FillDgvCustomer();
        }

        private void btnDeleteCostumer_Click(object sender, EventArgs e)
        {
            if (dgvReservationCostumer.Rows.Count > 0)
            {
                dgvReservationCostumer.Rows.Remove(dgvReservationCostumer.SelectedRows[0]);
            }
        }
    }
}
