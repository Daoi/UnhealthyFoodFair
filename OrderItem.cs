using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class OrderItem
    {
        int hiddenKey;
        string hiddenName;
        decimal hiddenPrices;
        int hiddenCount; 

        public OrderItem(int key, string name, decimal prices, int count)
        {
            hiddenKey = key;
            hiddenName = name;
            hiddenPrices = prices;
            hiddenCount = count;
        }

        public string buildAttributeString()
        {
            return $"{hiddenKey}*{hiddenName}*{hiddenPrices}*{hiddenCount}";
        }

    }
}
