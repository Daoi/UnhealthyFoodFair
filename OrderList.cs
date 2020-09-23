using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    class OrderList
    {
        List<OrderItem> internalList;

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
            StringBuilder sb = new StringBuilder();
            internalList.ForEach(order => sb.Append(order.buildAttributeString() + "\r\n"));
            return sb.ToString();
        }

        public string writeStringToUpdateFile()
        {
            StringBuilder sb = new StringBuilder();
            internalList.ForEach(order => sb.Append(order.buildAttributeString()));
            return sb.ToString();

        }
    }
}
