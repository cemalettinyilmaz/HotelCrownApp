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
    public partial class ReservationUpdateForm : Form
    {
        private readonly AppDbContext db;
        private readonly Reservation resarvation;

        public ReservationUpdateForm(AppDbContext db, Reservation resarvation)
        {
            InitializeComponent();
            this.db = db;
            this.resarvation = resarvation;
        }

        private void ReservationUpdateForm_Load(object sender, EventArgs e)
        {
            cmbFill();
            cmbRooms.SelectedItem = resarvation.Room;
            dtpInDate.Value = resarvation.CheckInDate.Date;
            dtpOutDate.Value = resarvation.CheckOutDate.Date;
            dgvFill();

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



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            resarvation.Room = (Room)cmbRooms.SelectedItem;
            resarvation.CheckInDate = dtpInDate.Value;
            resarvation.CheckOutDate = dtpOutDate.Value;


            foreach (var reservation in db.Reservations.ToList())
            {
                if (reservation != resarvation)
                {
                    if ((resarvation.CheckInDate.Date >= reservation.CheckInDate.Date && resarvation.CheckInDate.Date < reservation.CheckOutDate.Date) || (resarvation.CheckOutDate.Date >= reservation.CheckInDate.Date && resarvation.CheckOutDate.Date < reservation.CheckOutDate.Date))
                    {
                        MessageBox.Show("The room is full at this time.");
                        return;
                    }
                }
            }


            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Reservation Update");

            }

        }
        void dgvFill()
        {
            dgvService.DataSource = db.Services.ToList();
            dgvReservationServices.Rows.Clear();
            foreach (var service in resarvation.Services)
            {
                dgvReservationServices.Rows.Add(service.ServiceId, service.ServiceName, service.UnitPrice, service.Quantity);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count > 0)
            {
                Service service = (Service)dgvService.SelectedRows[0].DataBoundItem;
                ReservationService reservationService = new ReservationService()
                {
                    Service = service,
                    ServiceName = service.ServiceName,
                    UnitPrice = service.UnitPrice,
                    Quantity = (int)nudQuanty.Value,
                };
                resarvation.Services.Add(reservationService);
                db.SaveChanges();
                dgvFill();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservationServices.SelectedRows.Count > 0)
            {
                int serviceId = (int)dgvReservationServices.SelectedRows[0].Cells[0].Value;
                ReservationService reservationService = resarvation.Services.FirstOrDefault(x => x.ServiceId == serviceId);
                db.ReservationServices.Remove(reservationService);
                db.SaveChanges();
                dgvFill();

            }
        }
    }
}
