using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Cart
    {
        //One to many
        private List<Item> Items; //relationship between 

        public Cart()//Constructor
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }


        public string GetCartWithTotals()
        {
            StringBuilder builder = new StringBuilder();
            //string builderS = string.Empty;

            decimal subTotal = Calculation.CalculateSubTotal(Items);
            decimal subTotalWithVat = Calculation.CalculateWithVat(Items);

            foreach(Item item in Items)
            {
                builder.AppendLine(item.ItemName + " " + item.ItemPrice);//building a List of strings
                //builderS += $"{item.ItemName} {item.ItemPrice}";
            }
            builder.AppendLine("Sub Total: " + " " + subTotal.ToString("N2"));
            builder.AppendLine("With Vat: " + " " + subTotalWithVat.ToString("N2"));

            return builder.ToString();
        }
    }
}
