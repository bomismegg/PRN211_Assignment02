using DataAccess.Repository.MemberRepo;
using SalesWinApp.MemberUI;
using SalesWinApp.Presenter;
using System;
using System.Windows.Forms;
using SalesWinApp.OrderUI;
using SalesWinApp.ProductUI;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {

        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembersManagement frmMemberManagement = new frmMembersManagement
            {
                LoginMember = this.LoginMember
            };
            frmMemberManagement.MdiParent = this;
            frmMemberManagement.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository
            };
            frmProductsManagement.MdiParent = this;
            frmProductsManagement.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdersManagement frmOrdersManagement = new frmOrdersManagement
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository
            };
            frmOrdersManagement.MdiParent = this;
            frmOrdersManagement.Show();
        }
    }
    
}
