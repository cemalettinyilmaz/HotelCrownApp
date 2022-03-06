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
    public partial class InvoiceForm : Form
    {
        private readonly AppDbContext db;
        private readonly Reservation reservation;

        public InvoiceForm(AppDbContext db, Reservation reservation)
        {
            InitializeComponent();
            this.db = db;
            this.reservation = reservation;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            lblRoomName.Text = reservation.Room.RoomName.ToString();
            lblCustomers.Text = string.Join(",", reservation.Customers.Select(x => x.Customer.FullName));
            int day = reservation.CheckOutDate.Day - reservation.CheckInDate.Day;
            lblRoomStayedDay.Text = day.ToString();
            double roomPrice = reservation.Room.Price;
            lblRoomCost.Text = reservation.Room.Price.ToString();
            double TotalCost = day * roomPrice;

            dgvService.Rows.Clear();
            foreach (var service in reservation.Services)
            {
                dgvService.Rows.Add(service.ServiceId, service.ServiceName, service.UnitPrice, service.Quantity);
                TotalCost += service.UnitPrice * service.Quantity;
            }
            lblTotalCost.Text = TotalCost.ToString() + " $";
        }

    }
}
