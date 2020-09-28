using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class OrderList
    {
        public List<OrderItem> internalList {get; set;}

        public OrderList()
        {
            internalList = new List<OrderItem>();
        }

        public void Add(OrderItem order)
        {
            internalList.Add(order);
        }

        public string buildStringForMessageBox()
        {
            const int KEY = 0;
            const int ITEM = 1;
            const int PRICE = 2;
            const int QUANTITY = 3;


            StringBuilder sb = new StringBuilder();
            foreach(OrderItem order in internalList)
            {
                string[] items = order.buildAttributeString().Split('*');
                sb.Append($"({items[QUANTITY]}){items[ITEM]} {items[PRICE]} Quantity: {items[QUANTITY]} \r\n");
            }
            return sb.ToString();
        }

        public string writeStringToUpdateFile()
        {
            StringBuilder sb = new StringBuilder();
            internalList.ForEach(order => sb.Append(order.buildAttributeString() + "|"));
            return sb.ToString();

        }
    }
}
