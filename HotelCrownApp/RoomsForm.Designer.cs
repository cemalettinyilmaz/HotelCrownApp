namespace HotelCrownApp
{
    partial class RoomsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.dgvAllFeatures = new System.Windows.Forms.DataGridView();
            this.dgvRoomFeatures = new System.Windows.Forms.DataGridView();
            this.FeatureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddFeature = new System.Windows.Forms.Button();
            this.btnDeleteFeature = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFeatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomFeatures)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room List";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(596, 41);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(197, 26);
            this.txtRoomName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Name:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(596, 83);
            this.nudCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(197, 26);
            this.nudCapacity.TabIndex = 4;
            this.nudCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price :";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 3;
            this.nudPrice.Location = new System.Drawing.Point(596, 125);
            this.nudPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(197, 26);
            this.nudPrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "All Features";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(870, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Room Features";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(790, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(366, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(17, 34);
            this.dgvRoomList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.RowHeadersVisible = false;
            this.dgvRoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomList.Size = new System.Drawing.Size(439, 441);
            this.dgvRoomList.TabIndex = 6;
            // 
            // dgvAllFeatures
            // 
            this.dgvAllFeatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllFeatures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllFeatures.Location = new System.Drawing.Point(492, 212);
            this.dgvAllFeatures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAllFeatures.Name = "dgvAllFeatures";
            this.dgvAllFeatures.ReadOnly = true;
            this.dgvAllFeatures.RowHeadersVisible = false;
            this.dgvAllFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllFeatures.Size = new System.Drawing.Size(318, 213);
            this.dgvAllFeatures.TabIndex = 6;
            // 
            // dgvRoomFeatures
            // 
            this.dgvRoomFeatures.AllowUserToAddRows = false;
            this.dgvRoomFeatures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomFeatures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoomFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomFeatures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeatureID,
            this.FeatureName});
            this.dgvRoomFeatures.Location = new System.Drawing.Point(862, 212);
            this.dgvRoomFeatures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRoomFeatures.Name = "dgvRoomFeatures";
            this.dgvRoomFeatures.ReadOnly = true;
            this.dgvRoomFeatures.RowHeadersVisible = false;
            this.dgvRoomFeatures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomFeatures.Size = new System.Drawing.Size(342, 213);
            this.dgvRoomFeatures.TabIndex = 6;
            // 
            // FeatureID
            // 
            this.FeatureID.HeaderText = "FeatureID";
            this.FeatureID.Name = "FeatureID";
            this.FeatureID.ReadOnly = true;
            // 
            // FeatureName
            // 
            this.FeatureName.HeaderText = "FeatureName";
            this.FeatureName.Name = "FeatureName";
            this.FeatureName.ReadOnly = true;
            // 
            // btnAddFeature
            // 
            this.btnAddFeature.BackColor = System.Drawing.Color.Green;
            this.btnAddFeature.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddFeature.ForeColor = System.Drawing.Color.White;
            this.btnAddFeature.Location = new System.Drawing.Point(817, 300);
            this.btnAddFeature.Name = "btnAddFeature";
            this.btnAddFeature.Size = new System.Drawing.Size(38, 34);
            this.btnAddFeature.TabIndex = 7;
            this.btnAddFeature.Text = " >";
            this.btnAddFeature.UseVisualStyleBackColor = false;
            this.btnAddFeature.Click += new System.EventHandler(this.btnAddFeature_Click);
            // 
            // btnDeleteFeature
            // 
            this.btnDeleteFeature.BackColor = System.Drawing.Color.Red;
            this.btnDeleteFeature.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteFeature.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFeature.Location = new System.Drawing.Point(1020, 433);
            this.btnDeleteFeature.Name = "btnDeleteFeature";
            this.btnDeleteFeature.Size = new System.Drawing.Size(184, 27);
            this.btnDeleteFeature.TabIndex = 5;
            this.btnDeleteFeature.Text = "Delete Feature from Room";
            this.btnDeleteFeature.UseVisualStyleBackColor = false;
            this.btnDeleteFeature.Click += new System.EventHandler(this.btnDeleteFeature_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Green;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(320, -4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(136, 30);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 522);
            this.Controls.Add(this.btnAddFeature);
            this.Controls.Add(this.dgvRoomFeatures);
            this.Controls.Add(this.dgvAllFeatures);
            this.Controls.Add(this.dgvRoomList);
            this.Controls.Add(this.btnDeleteFeature);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1235, 561);
            this.MinimumSize = new System.Drawing.Size(493, 561);
            this.Name = "RoomsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RoomsForm";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFeatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomFeatures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.DataGridView dgvAllFeatures;
        private System.Windows.Forms.DataGridView dgvRoomFeatures;
        private System.Windows.Forms.Button btnAddFeature;
        private System.Windows.Forms.Button btnDeleteFeature;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureName;
        private System.Windows.Forms.Button btnAddRoom;
    }
}