using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class MenuInfo
    {

        string[] hiddenNames = new string[8] { "Hot Dog", "Hamburger", "French Frie", "Bacon Burger",
            "Large Soda", "Cheese Steak", "Large Milkshake", "Bar-B-Que Ribs" };
        decimal[] hiddenPrices = new decimal[8] { 3.50m, 6.50m, 3.00m, 7.50m,
                                                  1.50m, 7.75m, 4.50m, 8.00m };

        public string getMenuItemName(int key)
        {
            return hiddenNames[key];
        }

        public decimal getMenuItemPrice(int key)
        {
            return hiddenPrices[key];
        }

        
    }
}
