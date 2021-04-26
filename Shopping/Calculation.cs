using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Calculation
    {
        public static decimal CalculateSubTotal(List<Item> calculationItems)
        {
            /*  decimal total = 0;
               for(int index=0;index > items.Count; index++)
              {
                  Item item = items[index];
                  total += item.ItemPrice
              }
            return total;*/

            decimal total = 0;

            foreach(Item item in calculationItems)
            {
               total += item.ItemPrice;
            }
            return total;
        }

        public static decimal CalculateWithVat(List<Item> calculationItems)
        {
            decimal subTotal = CalculateSubTotal(calculationItems);
            
             return subTotal * ((100 + Tax.VatAmount) / 100);
        }
    }
}
