namespace HotelCrownApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.ReservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOutFalse = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbOutAll = new System.Windows.Forms.RadioButton();
            this.rbOutTrue = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbInTrue = new System.Windows.Forms.RadioButton();
            this.rbInFalse = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRooms,
            this.tsmFeatures,
            this.tsmServices,
            this.tsmCustomers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmRooms
            // 
            this.tsmRooms.Name = "tsmRooms";
            this.tsmRooms.Size = new System.Drawing.Size(56, 19);
            this.tsmRooms.Text = "Rooms";
            this.tsmRooms.Click += new System.EventHandler(this.tsmRooms_Click);
            // 
            // tsmFeatures
            // 
            this.tsmFeatures.Name = "tsmFeatures";
            this.tsmFeatures.Size = new System.Drawing.Size(63, 19);
            this.tsmFeatures.Text = "Features";
            this.tsmFeatures.Click += new System.EventHandler(this.tsmFeatures_Click);
            // 
            // tsmServices
            // 
            this.tsmServices.Name = "tsmServices";
            this.tsmServices.Size = new System.Drawing.Size(61, 19);
            this.tsmServices.Text = "Services";
            this.tsmServices.Click += new System.EventHandler(this.tsmServices_Click);
            // 
            // tsmCustomers
            // 
            this.tsmCustomers.Name = "tsmCustomers";
            this.tsmCustomers.Size = new System.Drawing.Size(76, 19);
            this.tsmCustomers.Text = "Customers";
            this.tsmCustomers.Click += new System.EventHandler(this.tsmCustomers_Click);
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationId,
            this.Room,
            this.CheckInDate,
            this.CheckOutDate,
            this.CheckedInTime,
            this.CheckedOutTime,
            this.Customers});
            this.dgvReservations.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvReservations.Location = new System.Drawing.Point(13, 154);
            this.dgvReservations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersVisible = false;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(1041, 441);
            this.dgvReservations.TabIndex = 2;
            this.dgvReservations.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvReservations_MouseDown);
            // 
            // ReservationId
            // 
            this.ReservationId.FillWeight = 15F;
            this.ReservationId.HeaderText = "Id";
            this.ReservationId.Name = "ReservationId";
            this.ReservationId.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.FillWeight = 16F;
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // CheckInDate
            // 
            this.CheckInDate.FillWeight = 24F;
            this.CheckInDate.HeaderText = "Check-In Date";
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.FillWeight = 25F;
            this.CheckOutDate.HeaderText = "Check-Out Date";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            // 
            // CheckedInTime
            // 
            this.CheckedInTime.FillWeight = 18F;
            this.CheckedInTime.HeaderText = "Checked-In";
            this.CheckedInTime.Name = "CheckedInTime";
            this.CheckedInTime.ReadOnly = true;
            // 
            // CheckedOutTime
            // 
            this.CheckedOutTime.FillWeight = 19F;
            this.CheckedOutTime.HeaderText = "Checked-Out";
            this.CheckedOutTime.Name = "CheckedOutTime";
            this.CheckedOutTime.ReadOnly = true;
            // 
            // Customers
            // 
            this.Customers.FillWeight = 31.98619F;
            this.Customers.HeaderText = "Customers";
            this.Customers.Name = "Customers";
            this.Customers.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservations";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.Location = new System.Drawing.Point(942, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOutFalse);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rbOutAll);
            this.groupBox2.Controls.Add(this.rbOutTrue);
            this.groupBox2.Location = new System.Drawing.Point(616, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rbOutFalse
            // 
            this.rbOutFalse.AutoSize = true;
            this.rbOutFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOutFalse.Location = new System.Drawing.Point(10, 59);
            this.rbOutFalse.Name = "rbOutFalse";
            this.rbOutFalse.Size = new System.Drawing.Size(50, 17);
            this.rbOutFalse.TabIndex = 5;
            this.rbOutFalse.TabStop = true;
            this.rbOutFalse.Text = "False";
            this.rbOutFalse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Checked Out";
            // 
            // rbOutAll
            // 
            this.rbOutAll.AutoSize = true;
            this.rbOutAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOutAll.Location = new System.Drawing.Point(10, 25);
            this.rbOutAll.Name = "rbOutAll";
            this.rbOutAll.Size = new System.Drawing.Size(36, 17);
            this.rbOutAll.TabIndex = 5;
            this.rbOutAll.TabStop = true;
            this.rbOutAll.Text = "All";
            this.rbOutAll.UseVisualStyleBackColor = true;
            // 
            // rbOutTrue
            // 
            this.rbOutTrue.AutoSize = true;
            this.rbOutTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOutTrue.Location = new System.Drawing.Point(10, 42);
            this.rbOutTrue.Name = "rbOutTrue";
            this.rbOutTrue.Size = new System.Drawing.Size(47, 17);
            this.rbOutTrue.TabIndex = 5;
            this.rbOutTrue.TabStop = true;
            this.rbOutTrue.Text = "True";
            this.rbOutTrue.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(769, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Tag = "Search";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(178, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(135, 26);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(352, 35);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(135, 26);
            this.dtpTo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(795, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Checked In";
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.BackColor = System.Drawing.Color.Green;
            this.btnNewReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewReservation.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnNewReservation.FlatAppearance.BorderSize = 0;
            this.btnNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewReservation.ForeColor = System.Drawing.Color.White;
            this.btnNewReservation.Location = new System.Drawing.Point(121, 603);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(164, 47);
            this.btnNewReservation.TabIndex = 5;
            this.btnNewReservation.Text = "NEW RESERVATION";
            this.btnNewReservation.UseVisualStyleBackColor = false;
            this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(383, 603);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 47);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(654, 603);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAll.Location = new System.Drawing.Point(10, 25);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(36, 17);
            this.rbAll.TabIndex = 5;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbInTrue
            // 
            this.rbInTrue.AutoSize = true;
            this.rbInTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbInTrue.Location = new System.Drawing.Point(10, 42);
            this.rbInTrue.Name = "rbInTrue";
            this.rbInTrue.Size = new System.Drawing.Size(47, 17);
            this.rbInTrue.TabIndex = 5;
            this.rbInTrue.TabStop = true;
            this.rbInTrue.Text = "True";
            this.rbInTrue.UseVisualStyleBackColor = true;
            // 
            // rbInFalse
            // 
            this.rbInFalse.AutoSize = true;
            this.rbInFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbInFalse.Location = new System.Drawing.Point(10, 59);
            this.rbInFalse.Name = "rbInFalse";
            this.rbInFalse.Size = new System.Drawing.Size(50, 17);
            this.rbInFalse.TabIndex = 5;
            this.rbInFalse.TabStop = true;
            this.rbInFalse.Text = "False";
            this.rbInFalse.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbInFalse);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rbInTrue);
            this.groupBox3.Controls.Add(this.rbAll);
            this.groupBox3.Location = new System.Drawing.Point(510, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 84);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkedInToolStripMenuItem,
            this.checkedOutToolStripMenuItem,
            this.ınvoiceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // checkedInToolStripMenuItem
            // 
            this.checkedInToolStripMenuItem.Name = "checkedInToolStripMenuItem";
            this.checkedInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedInToolStripMenuItem.Text = "Checked-In";
            this.checkedInToolStripMenuItem.Click += new System.EventHandler(this.checkedInToolStripMenuItem_Click);
            // 
            // checkedOutToolStripMenuItem
            // 
            this.checkedOutToolStripMenuItem.Name = "checkedOutToolStripMenuItem";
            this.checkedOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedOutToolStripMenuItem.Text = "Checked-Out";
            this.checkedOutToolStripMenuItem.Click += new System.EventHandler(this.checkedOutToolStripMenuItem_Click);
            // 
            // ınvoiceToolStripMenuItem
            // 
            this.ınvoiceToolStripMenuItem.Name = "ınvoiceToolStripMenuItem";
            this.ınvoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ınvoiceToolStripMenuItem.Text = "Invoice";
            this.ınvoiceToolStripMenuItem.Click += new System.EventHandler(this.ınvoiceToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewReservation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Hotel Crown";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRooms;
        private System.Windows.Forms.ToolStripMenuItem tsmFeatures;
        private System.Windows.Forms.ToolStripMenuItem tsmServices;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomers;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbOutFalse;
        private System.Windows.Forms.RadioButton rbInFalse;
        private System.Windows.Forms.RadioButton rbOutTrue;
        private System.Windows.Forms.RadioButton rbInTrue;
        private System.Windows.Forms.RadioButton rbOutAll;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceToolStripMenuItem;
    }
}