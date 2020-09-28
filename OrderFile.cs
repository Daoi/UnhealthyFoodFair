using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public class OrderFile
    {


        private OrderList currentOrder;
        private static string path = "UpdatedOrderFile.txt";
        private static StreamWriter sw;// new StreamWriter(tempFile);
        private static StreamReader sr;

        public OrderFile(OrderList currentOrder)
        {
            this.currentOrder = currentOrder;
        }

        public void writeFile()
        {
            sw = new StreamWriter(path);
            try
            {
                string[] orders = currentOrder.writeStringToUpdateFile().Split('|');
                foreach(string order in orders)
                {
                    sw.Write(order + "r\n");
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Error with writing file: " + e.ToString());
            }
            sw.Close();
        }
    }
}
