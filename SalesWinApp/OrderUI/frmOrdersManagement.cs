﻿using AutoMapper;
using BusinessObjects.Models;
using DataAccess.Repository.OrderRepo;
using SalesWinApp.MemberUI;
using SalesWinApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesWinApp.ProductUI;
using DataAccess.Repository.ProductRepo;
using DataAccess.Repository.MemberRepo;
using System.Reflection;
using System.Diagnostics;

namespace SalesWinApp.OrderUI
{
    public partial class frmOrdersManagement : Form
    {
        public MemberPresenter LoginMember { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        private IOrderRepository orderRepository = new OrderRepository();
        private IEnumerable<OrderPresenter> orderPresenters = new List<OrderPresenter>();

        BindingSource source;
        private IMapper mapper;
        public frmOrdersManagement()
        {
            InitializeComponent();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            mapper = config.CreateMapper();
        }
        private void CreateMainMenu()
        {
            MenuStrip mainMenu = new MenuStrip();
            this.Controls.Add(mainMenu);
            this.MainMenuStrip = mainMenu;

            if (!LoginMember.Fullname.Equals("Admin"))
            {
                ToolStripMenuItem menuOrder = new ToolStripMenuItem("&Order Product");
                ToolStripMenuItem menuProfile = new ToolStripMenuItem("My &Profile");
                ToolStripMenuItem menuExit = new ToolStripMenuItem("&Exit");

                // Main Menu
                mainMenu.Items.AddRange(new ToolStripItem[]
                {
                    menuOrder,
                    menuProfile,
                    menuExit
                });
                menuOrder.Click += new EventHandler(menuOrder_Click);
                menuProfile.Click += new EventHandler(menuProfile_Click);
                menuExit.Click += new EventHandler(menuExit_Click);
            }
        }

        private void menuMemberMng_Click(object sender, EventArgs e)
        {
            frmMembersManagement frmMemberManagement = null;
            frmMemberManagement = new frmMembersManagement
            {
                LoginMember = this.LoginMember
            };
            frmMemberManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberManagement.Show();
        }
        private void menuProductMng_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement()
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository,
            };
            frmProductsManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmProductsManagement.Show();
        }
        private void menuExit_Click(object sender, EventArgs e) => Close();

        private void menuOrder_Click(object sender, EventArgs e)
        {
            frmProductsManagement frmProductsManagement = new frmProductsManagement()
            {
                LoginMember = this.LoginMember,
                MemberRepository = this.MemberRepository,
            };
            frmProductsManagement.Closed += (s, args) => this.Close();
            this.Hide();
            frmProductsManagement.Show();
        }
        private void menuProfile_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Member Details",
                MemberInfo = LoginMember,
                InsertOrUpdate = false,
                MemberRepository = this.MemberRepository,
            };
            frmMemberDetails.Closed += (s, args) => this.Close();
            this.Hide();
            frmMemberDetails.Show();
        }

        private void LoadOrder()
        {
            source = new BindingSource();
            source.DataSource = orderPresenters;

            txtOrderID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtOrderTotal.DataBindings.Clear();
            txtMemberName.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text", source, "OrderID");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtOrderTotal.DataBindings.Add("Text", source, "OrderTotal");
            txtMemberName.DataBindings.Add("Text", source, "MemberName");

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = source;
        }
        private void frmOrdersManagement_Load(object sender, EventArgs e)
        {
            try
            {
                CreateMainMenu();

                startDate.Value = DateTime.Today;
                startDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "dd/MM/yyyy";

                endDate.Value = DateTime.Today;
                endDate.Format = DateTimePickerFormat.Custom;
                endDate.CustomFormat = "dd/MM/yyyy";

                IEnumerable<Order> orders = orderRepository.GetOrders(LoginMember.MemberId);
                if (orders.Any())
                {
                    orderPresenters = orders.Select(or => mapper.Map<Order, OrderPresenter>(or));
                    LoadOrder();

                    DateTime minDate = orderPresenters.Min(order => order.OrderDate);
                    DateTime maxDate = orderPresenters.Max(order => order.OrderDate);

                    startDate.Value = minDate;
                    endDate.Value = maxDate;
                }
                else
                {
                    MessageBox.Show("No order found!", "Order Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Orders List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private OrderPresenter GetOrder()
        {
            OrderPresenter orderPresenter = null;
            try
            {
                orderPresenter = new OrderPresenter()
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    MemberName = txtMemberName.Text,
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    OrderTotal = decimal.Parse(txtOrderTotal.Text)
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderPresenter;
        }
        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                OrderPresenter = GetOrder(),
                LoginMember = this.LoginMember
            };
            frmOrderDetails.ShowDialog();
            LoadOrder();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime searchStartDate = startDate.Value;
                DateTime searchEndDate = endDate.Value;
                if (DateTime.Compare(searchStartDate, searchEndDate) > 0)
                {
                    DateTime temp = searchStartDate;
                    searchStartDate = searchEndDate;
                    searchEndDate = temp;
                }
                IEnumerable<Order> orders = orderRepository.GetOrders(LoginMember.MemberId, searchStartDate, searchEndDate);
                if (orders.Any())
                {
                    orderPresenters = orders.Select(or => mapper.Map<Order, OrderPresenter>(or));
                    LoadOrder();
                }
                else
                {
                    MessageBox.Show("No order found!", "Order Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
