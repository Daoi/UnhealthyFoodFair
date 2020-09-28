using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using WindowsFormsApp11;

namespace UserControls
{
    public class OrderControlPanel : UserControl
    {

        public OrderList orderList { get; set; }
        private Label labelEnterItemKey;
        private TextBox textItemKey;
        private Label labelEnterItemQuantity;
        private TextBox textItemQuantity;
        private Button btnAdd;
        private Panel pnlOrderControls;
        public MenuInfo menu { get; set; }
        Button orderMore;

        public OrderControlPanel()
        {
            InitializeComponent();
        }

        public void initValues(Point loc, OrderList orderList, MenuInfo menu, Button orderMore)
        {
            this.orderList = orderList;
            this.menu = menu;
            pnlOrderControls.Location = loc;
            this.orderMore = orderMore;
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(textItemKey.Text, out key))
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

            if (!int.TryParse(textItemQuantity.Text, out quantity))
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

            btnAdd.Enabled = false;
            Point loc = pnlOrderControls.Location;
            loc.Y -= 160;
            OrderControlPanel newPanel = new OrderControlPanel();
            newPanel.initValues(loc, orderList, menu, orderMore);
            MessageBox.Show("Please click Add more to order more items, or All done to complete your order.");
            btnAdd.Enabled = false;
            textItemKey.Enabled = false;
            textItemQuantity.Enabled = false;
            orderMore.Enabled = true;
            
        }

        private void InitializeComponent()
        {
            this.labelEnterItemKey = new System.Windows.Forms.Label();
            this.textItemKey = new System.Windows.Forms.TextBox();
            this.labelEnterItemQuantity = new System.Windows.Forms.Label();
            this.textItemQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlOrderControls = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelEnterItemKey
            // 
            this.labelEnterItemKey.AutoSize = true;
            this.labelEnterItemKey.Location = new System.Drawing.Point(3, 14);
            this.labelEnterItemKey.Name = "labelEnterItemKey";
            this.labelEnterItemKey.Size = new System.Drawing.Size(79, 13);
            this.labelEnterItemKey.TabIndex = 0;
            this.labelEnterItemKey.Text = "Enter Item Key:";
            // 
            // textItemKey
            // 
            this.textItemKey.Location = new System.Drawing.Point(88, 11);
            this.textItemKey.Name = "textItemKey";
            this.textItemKey.Size = new System.Drawing.Size(100, 20);
            this.textItemKey.TabIndex = 1;
            // 
            // labelEnterItemQuantity
            // 
            this.labelEnterItemQuantity.AutoSize = true;
            this.labelEnterItemQuantity.Location = new System.Drawing.Point(195, 14);
            this.labelEnterItemQuantity.Name = "labelEnterItemQuantity";
            this.labelEnterItemQuantity.Size = new System.Drawing.Size(100, 13);
            this.labelEnterItemQuantity.TabIndex = 2;
            this.labelEnterItemQuantity.Text = "Enter Item Quantity:";
            // 
            // textItemQuantity
            // 
            this.textItemQuantity.Location = new System.Drawing.Point(301, 11);
            this.textItemQuantity.Name = "textItemQuantity";
            this.textItemQuantity.Size = new System.Drawing.Size(100, 20);
            this.textItemQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlOrderControls
            // 
            this.pnlOrderControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderControls.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderControls.Name = "pnlOrderControls";
            this.pnlOrderControls.Size = new System.Drawing.Size(637, 43);
            this.pnlOrderControls.TabIndex = 5;
            // 
            // OrderControlPanel
            // 
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textItemQuantity);
            this.Controls.Add(this.labelEnterItemQuantity);
            this.Controls.Add(this.textItemKey);
            this.Controls.Add(this.labelEnterItemKey);
            this.Controls.Add(this.pnlOrderControls);
            this.Name = "OrderControlPanel";
            this.Size = new System.Drawing.Size(637, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
