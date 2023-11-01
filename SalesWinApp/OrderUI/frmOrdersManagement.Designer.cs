
namespace SalesWinApp.OrderUI
{
    partial class frmOrdersManagement
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
            dgvOrderList = new System.Windows.Forms.DataGridView();
            lbOrderID = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            lbOrderDate = new System.Windows.Forms.Label();
            txtOrderDate = new System.Windows.Forms.TextBox();
            lbOrderTotal = new System.Windows.Forms.Label();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            grSearch = new System.Windows.Forms.GroupBox();
            btnSearch = new System.Windows.Forms.Button();
            endDate = new System.Windows.Forms.DateTimePicker();
            lbEndDate = new System.Windows.Forms.Label();
            startDate = new System.Windows.Forms.DateTimePicker();
            lbStartDate = new System.Windows.Forms.Label();
            lbMember = new System.Windows.Forms.Label();
            txtMemberName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            grSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new System.Drawing.Point(14, 237);
            dgvOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new System.Drawing.Size(472, 336);
            dgvOrderList.TabIndex = 0;
            dgvOrderList.CellDoubleClick += dgvOrderList_CellDoubleClick;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(15, 57);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(66, 20);
            lbOrderID.TabIndex = 1;
            lbOrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new System.Drawing.Point(96, 53);
            txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(130, 27);
            txtOrderID.TabIndex = 2;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(15, 96);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(83, 20);
            lbOrderDate.TabIndex = 3;
            lbOrderDate.Text = "Order Date";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Enabled = false;
            txtOrderDate.Location = new System.Drawing.Point(96, 92);
            txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(130, 27);
            txtOrderDate.TabIndex = 4;
            // 
            // lbOrderTotal
            // 
            lbOrderTotal.AutoSize = true;
            lbOrderTotal.Location = new System.Drawing.Point(15, 135);
            lbOrderTotal.Name = "lbOrderTotal";
            lbOrderTotal.Size = new System.Drawing.Size(84, 20);
            lbOrderTotal.TabIndex = 5;
            lbOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new System.Drawing.Point(96, 131);
            txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new System.Drawing.Size(130, 27);
            txtOrderTotal.TabIndex = 6;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(endDate);
            grSearch.Controls.Add(lbEndDate);
            grSearch.Controls.Add(startDate);
            grSearch.Controls.Add(lbStartDate);
            grSearch.Location = new System.Drawing.Point(245, 35);
            grSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Size = new System.Drawing.Size(241, 176);
            grSearch.TabIndex = 7;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(80, 123);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(109, 43);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // endDate
            // 
            endDate.Location = new System.Drawing.Point(80, 71);
            endDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            endDate.Name = "endDate";
            endDate.Size = new System.Drawing.Size(154, 27);
            endDate.TabIndex = 3;
            endDate.Value = new System.DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new System.Drawing.Point(11, 79);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new System.Drawing.Size(70, 20);
            lbEndDate.TabIndex = 2;
            lbEndDate.Text = "End Date";
            // 
            // startDate
            // 
            startDate.Location = new System.Drawing.Point(80, 19);
            startDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            startDate.Name = "startDate";
            startDate.Size = new System.Drawing.Size(154, 27);
            startDate.TabIndex = 1;
            startDate.Value = new System.DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new System.Drawing.Point(7, 27);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new System.Drawing.Size(76, 20);
            lbStartDate.TabIndex = 0;
            lbStartDate.Text = "Start Date";
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new System.Drawing.Point(15, 173);
            lbMember.Name = "lbMember";
            lbMember.Size = new System.Drawing.Size(65, 20);
            lbMember.TabIndex = 5;
            lbMember.Text = "Member";
            // 
            // txtMemberName
            // 
            txtMemberName.Enabled = false;
            txtMemberName.Location = new System.Drawing.Point(96, 169);
            txtMemberName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(130, 27);
            txtMemberName.TabIndex = 6;
            // 
            // frmOrdersManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(499, 596);
            Controls.Add(grSearch);
            Controls.Add(txtMemberName);
            Controls.Add(lbMember);
            Controls.Add(txtOrderTotal);
            Controls.Add(lbOrderTotal);
            Controls.Add(txtOrderDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Controls.Add(dgvOrderList);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmOrdersManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Orders Management";
            Load += frmOrdersManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lbOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.TextBox txtMemberName;
    }
}