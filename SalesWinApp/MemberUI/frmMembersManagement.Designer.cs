
namespace SalesWinApp.MemberUI
{
    partial class frmMembersManagement
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
            lbMemberID = new System.Windows.Forms.Label();
            txtMemberID = new System.Windows.Forms.TextBox();
            lbMemberName = new System.Windows.Forms.Label();
            txtMemberName = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lbPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lbCity = new System.Windows.Forms.Label();
            txtCity = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            txtCountry = new System.Windows.Forms.TextBox();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            lbSearch = new System.Windows.Forms.Label();
            txtSearchValue = new System.Windows.Forms.TextBox();
            lbSearchCountry = new System.Windows.Forms.Label();
            cboCountry = new System.Windows.Forms.ComboBox();
            lbSearchCity = new System.Windows.Forms.Label();
            cboSearchCity = new System.Windows.Forms.ComboBox();
            grSearch = new System.Windows.Forms.GroupBox();
            grFilter = new System.Windows.Forms.GroupBox();
            lbCompanyName = new System.Windows.Forms.Label();
            txtCompanyName = new System.Windows.Forms.TextBox();
            menuProductMng = new System.Windows.Forms.ToolStripMenuItem();
            menuOrderMng = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            grSearch.SuspendLayout();
            grFilter.SuspendLayout();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(30, 57);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(149, 53);
            txtMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(210, 27);
            txtMemberID.TabIndex = 1;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(30, 112);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(69, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Fullname";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(149, 108);
            txtMemberName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(210, 27);
            txtMemberName.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(30, 167);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(149, 163);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(210, 27);
            txtEmail.TabIndex = 5;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(434, 57);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(510, 53);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(210, 27);
            txtPassword.TabIndex = 7;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(434, 112);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 8;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(510, 108);
            txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(210, 27);
            txtCity.TabIndex = 9;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(434, 167);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(510, 163);
            txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(210, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(149, 264);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(125, 31);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(434, 264);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(125, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(8, 444);
            dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(743, 344);
            dgvMemberList.TabIndex = 15;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(18, 32);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(53, 20);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(95, 28);
            txtSearchValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(212, 27);
            txtSearchValue.TabIndex = 17;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new System.Drawing.Point(31, 28);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new System.Drawing.Size(60, 20);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Country";
            // 
            // cboCountry
            // 
            cboCountry.Location = new System.Drawing.Point(88, 24);
            cboCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new System.Drawing.Size(188, 28);
            cboCountry.TabIndex = 0;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // lbSearchCity
            // 
            lbSearchCity.AutoSize = true;
            lbSearchCity.Location = new System.Drawing.Point(37, 75);
            lbSearchCity.Name = "lbSearchCity";
            lbSearchCity.Size = new System.Drawing.Size(34, 20);
            lbSearchCity.TabIndex = 19;
            lbSearchCity.Text = "City";
            // 
            // cboSearchCity
            // 
            cboSearchCity.Location = new System.Drawing.Point(88, 71);
            cboSearchCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new System.Drawing.Size(188, 28);
            cboSearchCity.TabIndex = 20;
            cboSearchCity.SelectedIndexChanged += cboSearchCity_SelectedIndexChanged;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new System.Drawing.Point(29, 303);
            grSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grSearch.Size = new System.Drawing.Size(330, 119);
            grSearch.TabIndex = 22;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboSearchCity);
            grFilter.Controls.Add(lbSearchCity);
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new System.Drawing.Point(422, 308);
            grFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grFilter.Size = new System.Drawing.Size(297, 112);
            grFilter.TabIndex = 23;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(30, 215);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(116, 20);
            lbCompanyName.TabIndex = 24;
            lbCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new System.Drawing.Point(149, 211);
            txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(210, 27);
            txtCompanyName.TabIndex = 5;
            // 
            // menuProductMng
            // 
            menuProductMng.Name = "menuProductMng";
            menuProductMng.Size = new System.Drawing.Size(32, 19);
            // 
            // menuOrderMng
            // 
            menuOrderMng.Name = "menuOrderMng";
            menuOrderMng.Size = new System.Drawing.Size(32, 19);
            // 
            // frmMembersManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(758, 809);
            Controls.Add(lbCompanyName);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmMembersManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lbSearchCity;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.GroupBox grFilter;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.ToolStripMenuItem menuProductMng;
        private System.Windows.Forms.ToolStripMenuItem menuOrderMng;
    }
}