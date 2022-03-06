namespace HotelCrownApp
{
    partial class InvoiceForm
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRoomCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoomStayedDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.Service,
            this.UnitPrice,
            this.Quantity});
            this.dgvService.Location = new System.Drawing.Point(13, 117);
            this.dgvService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(361, 296);
            this.dgvService.TabIndex = 35;
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
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(129, 9);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(66, 13);
            this.lblRoomName.TabIndex = 36;
            this.lblRoomName.Text = "Room Name";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(129, 34);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(56, 13);
            this.lblCustomers.TabIndex = 37;
            this.lblCustomers.Text = "Costumers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Total Cost:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(302, 418);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCost.TabIndex = 38;
            this.lblTotalCost.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Room Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Customers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Room rate per day:";
            // 
            // lblRoomCost
            // 
            this.lblRoomCost.AutoSize = true;
            this.lblRoomCost.Location = new System.Drawing.Point(129, 56);
            this.lblRoomCost.Name = "lblRoomCost";
            this.lblRoomCost.Size = new System.Drawing.Size(97, 13);
            this.lblRoomCost.TabIndex = 37;
            this.lblRoomCost.Text = "Room rate per day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Number of days stayed:";
            // 
            // lblRoomStayedDay
            // 
            this.lblRoomStayedDay.AutoSize = true;
            this.lblRoomStayedDay.Location = new System.Drawing.Point(129, 81);
            this.lblRoomStayedDay.Name = "lblRoomStayedDay";
            this.lblRoomStayedDay.Size = new System.Drawing.Size(118, 13);
            this.lblRoomStayedDay.TabIndex = 39;
            this.lblRoomStayedDay.Text = "Number of days stayed:";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 474);
            this.Controls.Add(this.lblRoomStayedDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRoomCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.dgvService);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRoomCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRoomStayedDay;
    }
}