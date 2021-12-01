using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1_Basics1
{
   public  class Dictionary2
    {
        Customer cust1 = new Customer()
        {
            ID= 101,
            Name= "Romans"
        };
        Customer cust2 = new Customer()
        {
            ID = 225,
            Name = "Steve"

        }; 
        Customer cust3 = new Customer()
        {
            ID = 567,
            Name = "Smith"

        }; 
        Customer cust4 = new Customer()
        {
            ID = 332,
            Name = "Jonas"

        };
        Dictionary<int, Customer> dictionarycustomers1 = new Dictionary<int, Customer>();
        
        public static void dictfun2()
        {
            //ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Dictionary2 obj = new Dictionary2();
            obj.dictionarycustomers1.Add(obj.cust1.ID, obj.cust1);
            obj.dictionarycustomers1.Add(obj.cust2.ID, obj.cust2);
            obj.dictionarycustomers1.Add(obj.cust3.ID, obj.cust3);
            obj.dictionarycustomers1.Add(obj.cust4.ID, obj.cust4);

            foreach(KeyValuePair<int, Customer> keyValuePair in obj.dictionarycustomers1)
            {
                Console.WriteLine("The key is "+ keyValuePair.Key);
                Customer cust = keyValuePair.Value;
                Console.WriteLine("Name for " + keyValuePair.Key + "Is "+ cust.Name);
                Console.WriteLine("Name for " + cust.ID + " Is " + cust.Name);
            }
            Customer cust5 = new Customer()
            {
                ID = 11,
                Name = "Tulips"
            };

            if(!obj.dictionarycustomers1.ContainsKey(11))
            {
                obj.dictionarycustomers1.Add(cust5.ID, cust5);
                Console.WriteLine(" cust5 added");
            }
            if(obj.dictionarycustomers1.ContainsKey(11))
            {
                Customer findcust5 = obj.dictionarycustomers1[11];
                Console.WriteLine("ID is "+ findcust5.ID);
                Console.WriteLine("Value is "+ findcust5.Name);
            }
            Console.ResetColor();
            Customer custer;
            if(obj.dictionarycustomers1.TryGetValue(12, out custer))
            {
                Console.WriteLine("ID= {0}, Name= {1}", custer.ID, custer.Name);
            }
            else
            {
                Console.WriteLine(" Not found");
            }
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Total Items= {0} " , obj.dictionarycustomers1.Count());
            Console.ResetColor();

        }

    }
}
