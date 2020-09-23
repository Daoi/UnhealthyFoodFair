using System;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MenuInfo menu = new MenuInfo();
        OrderList orderList = new OrderList();

        private void btnMoreToOrder_Click(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(txtItemKey.Text, out key))
            {
                MessageBox.Show("Keys must be a number between 1 and 8", "Error");
                return;
            }
            if (key < 1 || key > 8)
            {
                MessageBox.Show("Keys must be a number between 1 and 8", "Error");
                return;
            }
            int quantity;

            if (!int.TryParse(txtItemOrderCount.Text, out quantity))
            {
                MessageBox.Show("Quantity should be a number greater than 0, less than 10", "Error");
                return;
            }
            if (quantity > 10 || quantity < 1)
            {
                MessageBox.Show("Quantity should be a number greater than 0, less than 10", "Error");
                return;
            }

            OrderItem ord = new OrderItem(key, menu.getMenuItemName(key), menu.getMenuItemPrice(key), quantity);
            orderList.Add(ord);

            MessageBox.Show($"Order so far is: \r\n {orderList.buildStringForMessageBox()}");

            txtItemKey.Clear();
            txtItemOrderCount.Clear();


        }
    }
}
