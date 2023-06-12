using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2_Final
{
    internal static class Class1
    {
        public static Class2 Class2
        {
            get => default;
            set
            {
            }
        }

        public static Class3 Class3
        {
            get => default;
            set
            {
            }
        }

        class inventoryItems
        {
            private string make;
            private int productYear;
            private double productPrice;
            private double productQuantity;

            public inventoryItems(string make, int productYear, double productPrice, double productQuantity)
            {
                this.make = make;
                this.productYear = productYear;
                this.productPrice = productPrice;
                this.productQuantity = productQuantity;
            }

            public inventoryItems()
            {
            }

            public void setMake(string make)
            {
                this.make = make;
            }
            public void getMake()
            {
                Console.WriteLine("Product" + make);
            }

            public void setYear(int productYear)
            {
                this.productYear=productYear;
            }
            public void getYear()
            {
                Console.WriteLine("Product" + productYear);
            }
            public void setPrice(double price)
            {
                this.productPrice = productPrice;
            }
            public void getPrice()
            {
                Console.WriteLine("Product Price "+ productPrice);
            }
            public void setQuantity(int productQuantity)
            {
                this.productQuantity=productQuantity;
            }
            public void getQuantity()
            {
                Console.WriteLine("Product quantity"+ productQuantity);
            }
            public void printItems()
            {
                Console.WriteLine("Product Make"+ make);
                Console.WriteLine("Product Year" + productYear);
                Console.WriteLine("Product Price"+ productPrice);
                Console.WriteLine("Product Quantity" + productQuantity);
            }
        }
    }
}
