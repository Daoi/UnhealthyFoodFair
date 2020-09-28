using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserControls;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        OrderList orderList = new OrderList();
        MenuInfo menu = new MenuInfo();
        System.Drawing.Point originLoc;
        int totalOrders = 0;


        public Form1()
        {
            originLoc = new System.Drawing.Point(104, 8);
            InitializeComponent();
            OrderControlPanel origin = new OrderControlPanel();
            pnlOrder.Controls.Add(origin);
            origin.initValues(originLoc, orderList, menu, btnMoreToOrder);
         

        }


        private void btnMoreToOrder_Click(object sender, EventArgs e)
        {
            totalOrders++;
            if(totalOrders == 5)
            {
                btnMoreToOrder.Enabled = false;
                MessageBox.Show("You've reached the maximum order amount!");
            }
            OrderControlPanel newOrder = new OrderControlPanel();
            newOrder.initValues(originLoc, orderList, menu, btnMoreToOrder);
            pnlOrder.Controls.Add(newOrder);
            MessageBox.Show($"{txtName.Text} your order({orderList.internalList.Count} items) so far is: \r\n {orderList.buildStringForMessageBox()}");
            btnMoreToOrder.Enabled = false;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnName.Text))
            {
                pnlOrder.Visible = true;
                lblInstructions.Visible = true;
                pnlControlButtons.Visible = true;
            }
        }

        private void btnAllDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtName.Text} your order({orderList.internalList.Count} items) so far is: \r\n {orderList.buildStringForMessageBox()}");
            OrderFile writer = new OrderFile(orderList);
            writer.writeFile();
            Application.Exit();
        }

        private void lblItemKey_Click(object sender, EventArgs e)
        {

        }
    }
}
