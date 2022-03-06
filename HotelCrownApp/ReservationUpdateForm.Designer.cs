namespace HotelCrownApp
{
    partial class ReservationUpdateForm
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
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReservationServices = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nudQuanty = new System.Windows.Forms.NumericUpDown();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanty)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(142, 17);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(239, 21);
            this.cmbRooms.TabIndex = 25;
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Location = new System.Drawing.Point(142, 89);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(239, 20);
            this.dtpOutDate.TabIndex = 23;
            // 
            // dtpInDate
            // 
            this.dtpInDate.Location = new System.Drawing.Point(142, 49);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(239, 20);
            this.dtpInDate.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "CheckOutDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "CheckInDate";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(276, 603);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(333, 32);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update Reservation";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvService
            // 
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(29, 161);
            this.dgvService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(370, 350);
            this.dgvService.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "All Service List";
            // 
            // dgvReservationServices
            // 
            this.dgvReservationServices.AllowUserToAddRows = false;
            this.dgvReservationServices.AllowUserToDeleteRows = false;
            this.dgvReservationServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservationServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservationServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.Service,
            this.UnitPrice,
            this.Quantity});
            this.dgvReservationServices.Location = new System.Drawing.Point(496, 161);
            this.dgvReservationServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservationServices.Name = "dgvReservationServices";
            this.dgvReservationServices.ReadOnly = true;
            this.dgvReservationServices.RowHeadersVisible = false;
            this.dgvReservationServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationServices.Size = new System.Drawing.Size(361, 350);
            this.dgvReservationServices.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Services Received";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(415, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 20);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(767, 519);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nudQuanty
            // 
            this.nudQuanty.Location = new System.Drawing.Point(415, 325);
            this.nudQuanty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuanty.Name = "nudQuanty";
            this.nudQuanty.Size = new System.Drawing.Size(60, 20);
            this.nudQuanty.TabIndex = 38;
            this.nudQuanty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ServiceID
            // 
            this.ServiceID.HeaderText = "Column1";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Visible = false;
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ReservationUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 647);
            this.Controls.Add(this.nudQuanty);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReservationServices);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.dtpOutDate);
            this.Controls.Add(this.dtpInDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ReservationUpdateForm";
            this.Text = "ReservationUpdateForm";
            this.Load += new System.EventHandler(this.ReservationUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReservationServices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nudQuanty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}