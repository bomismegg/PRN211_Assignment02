using AutoMapper;
using BusinessObjects.Models;
using DataAccess.Repository.MemberRepo;
using SalesWinApp.MemberUI;
using SalesWinApp.Presenter;
using SalesWinApp.ProductUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        private IMapper mapper;
        public frmLogin()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Email = txtEmail.Text;
                string Password = txtPassword.Text;
                Member loginMember = memberRepository.Login(Email, Password);
                MemberPresenter memberPresenter = mapper.Map<MemberPresenter>(loginMember);
                if (loginMember != null)
                {
                    string memberName = loginMember.FullName;
                    if (memberName.Equals("Admin"))
                    {
                        //frmMembersManagement frmMemberManagement = null;
                        //frmMemberManagement = new frmMembersManagement
                        //{
                        //    LoginMember = memberPresenter,
                        //};
                        //frmMemberManagement.Closed += (s, args) => this.Close();
                        //this.Hide();
                        //frmMemberManagement.Show();
                        //frmProductsManagement frmProductsManagement = new frmProductsManagement();
                        //frmProductsManagement.Closed += (s, args) => this.Close();
                        //this.Hide();
                        //frmProductsManagement.Show();
                        frmMain frmMain = null;
                        frmMain = new frmMain
                        {
                            LoginMember = memberPresenter,
                            MemberRepository = memberRepository,
                        };
                        frmMain.Closed += (s, args) => this.Close();
                        this.Hide();
                        frmMain.Show();
                    }
                    else
                    {
                        //frmMemberDetails frmMemberDetails = new frmMemberDetails
                        //{
                        //    Text = "Member Details",
                        //    MemberInfo = memberPresenter,
                        //    InsertOrUpdate = false,
                        //    MemberRepository = memberRepository
                        //};
                        //frmMemberDetails.Closed += (s, args) => this.Close();
                        //this.Hide();
                        //frmMemberDetails.Show();
                        frmProductsManagement frmProductsManagement = new frmProductsManagement()
                        {
                            LoginMember = memberPresenter,
                            MemberRepository = memberRepository,
                        };
                        frmProductsManagement.Closed += (s, args) => this.Close();
                        this.Hide();
                        frmProductsManagement.Show();
                    }
                }
                else
                {
                    if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
