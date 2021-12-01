using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1_Basics1
{
  public   class Dictionary3
    {
        public static void dictfun3()
        {

            Console.WriteLine(" Inside Dictionary3");
            Console.ResetColor();
            Customer cust1 = new Customer()
            {
                ID = 121,
                Name = "Jonnass Fillip"
            };

            Customer cust2 = new Customer()
            {
                ID = 341,
                Name = " Catherina"

            };

            Customer cust3 = new Customer()
            {
                ID = 678,
                Name = " Romboii"

            };
            Customer cust4 = new Customer()
            {
                ID = 133,
                Name = " Luthanssaa"

            };
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Customer[] customerarr = new Customer[4];
            customerarr[0] = cust1;
            customerarr[1] = cust2;
            customerarr[2] = cust3;
            customerarr[3] = cust4;

            Dictionary<int, Customer> dictionary = customerarr.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int,Customer> kvp in dictionary)
            {
                Console.WriteLine(" Key is "+ kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine(" Value is "+ cust.Name);
            }
            Console.ResetColor();
            listcustomer.Add(cust1);
            listcustomer.Add(cust2);
            listcustomer.Add(cust3);
            listcustomer.Add(cust4);

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Dictionary<int, Customer> dictionary1 = customerarr.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customer> kvp in dictionary1)
            {
                Console.WriteLine(" Key is " + kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine(" Value is " + cust.Name);
            }

            Console.ResetColor();
        }

       static List<Customer> listcustomer = new List<Customer>();

        
    }
}
