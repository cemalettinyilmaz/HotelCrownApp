namespace HotelCrownApp
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAllCostumer = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReservationCostumer = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddCostumer = new System.Windows.Forms.Button();
            this.btnDeleteCostumer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCostumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationCostumer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInDate
            // 
            this.dtpInDate.Location = new System.Drawing.Point(143, 44);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(239, 20);
            this.dtpInDate.TabIndex = 2;
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Location = new System.Drawing.Point(143, 78);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(239, 20);
            this.dtpOutDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CheckInDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CheckOutDate";
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.Room,
            this.CheckInDate,
            this.CheckOutDate,
            this.Customers});
            this.dgvReservation.Location = new System.Drawing.Point(13, 131);
            this.dgvReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowHeadersVisible = false;
            this.dgvReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservation.Size = new System.Drawing.Size(810, 417);
            this.dgvReservation.TabIndex = 18;
            // 
            // ReservationID
            // 
            this.ReservationID.FillWeight = 15.30573F;
            this.ReservationID.HeaderText = "ReservationID";
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.FillWeight = 33.86394F;
            this.Room.HeaderText = "RoomName";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // CheckInDate
            // 
            this.CheckInDate.FillWeight = 33.86394F;
            this.CheckInDate.HeaderText = "CheckInDate";
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.FillWeight = 33.86394F;
            this.CheckOutDate.HeaderText = "CheckOutDate";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            // 
            // Customers
            // 
            this.Customers.FillWeight = 33.86394F;
            this.Customers.HeaderText = "Customers";
            this.Customers.Name = "Customers";
            this.Customers.ReadOnly = true;
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(143, 12);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(239, 21);
            this.cmbRooms.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reservation List";
            // 
            // dgvAllCostumer
            // 
            this.dgvAllCostumer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCostumer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCostumer.Location = new System.Drawing.Point(831, 51);
            this.dgvAllCostumer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAllCostumer.Name = "dgvAllCostumer";
            this.dgvAllCostumer.ReadOnly = true;
            this.dgvAllCostumer.RowHeadersVisible = false;
            this.dgvAllCostumer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllCostumer.Size = new System.Drawing.Size(755, 241);
            this.dgvAllCostumer.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1190, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "All Costumers";
            // 
            // dgvReservationCostumer
            // 
            this.dgvReservationCostumer.AllowUserToAddRows = false;
            this.dgvReservationCostumer.AllowUserToDeleteRows = false;
            this.dgvReservationCostumer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservationCostumer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservationCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationCostumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerFullName});
            this.dgvReservationCostumer.Location = new System.Drawing.Point(831, 347);
            this.dgvReservationCostumer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservationCostumer.Name = "dgvReservationCostumer";
            this.dgvReservationCostumer.ReadOnly = true;
            this.dgvReservationCostumer.RowHeadersVisible = false;
            this.dgvReservationCostumer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationCostumer.Size = new System.Drawing.Size(756, 128);
            this.dgvReservationCostumer.TabIndex = 18;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // CustomerFullName
            // 
            this.CustomerFullName.HeaderText = "CustomerFullName";
            this.CustomerFullName.Name = "CustomerFullName";
            this.CustomerFullName.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1163, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reservation Costumer";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1047, 516);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 32);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add Reservation";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddCostumer
            // 
            this.btnAddCostumer.BackColor = System.Drawing.Color.Green;
            this.btnAddCostumer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCostumer.ForeColor = System.Drawing.Color.White;
            this.btnAddCostumer.Location = new System.Drawing.Point(1121, 300);
            this.btnAddCostumer.Name = "btnAddCostumer";
            this.btnAddCostumer.Size = new System.Drawing.Size(179, 19);
            this.btnAddCostumer.TabIndex = 23;
            this.btnAddCostumer.Text = "Add Costumer to Reservation";
            this.btnAddCostumer.UseVisualStyleBackColor = false;
            this.btnAddCostumer.Click += new System.EventHandler(this.btnAddCostumer_Click);
            // 
            // btnDeleteCostumer
            // 
            this.btnDeleteCostumer.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCostumer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCostumer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCostumer.Location = new System.Drawing.Point(1121, 483);
            this.btnDeleteCostumer.Name = "btnDeleteCostumer";
            this.btnDeleteCostumer.Size = new System.Drawing.Size(179, 20);
            this.btnDeleteCostumer.TabIndex = 21;
            this.btnDeleteCostumer.Text = "Delete Costumer from Reservation";
            this.btnDeleteCostumer.UseVisualStyleBackColor = false;
            this.btnDeleteCostumer.Click += new System.EventHandler(this.btnDeleteCostumer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Green;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(1497, 23);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(90, 23);
            this.btnAddCustomer.TabIndex = 23;
            this.btnAddCustomer.Text = "Add Costumer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 560);
            this.Controls.Add(this.btnAddCostumer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeleteCostumer);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.dgvReservationCostumer);
            this.Controls.Add(this.dgvAllCostumer);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.dtpOutDate);
            this.Controls.Add(this.dtpInDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCostumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationCostumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAllCostumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReservationCostumer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddCostumer;
        private System.Windows.Forms.Button btnDeleteCostumer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullName;
    }
}