using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Basics1
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static void Dictfun()
        {
            Console.WriteLine(" Inside Dictfun ");
            Customer cust1 = new Customer()
            {
                ID = 101,
                Name = "Robin"
            };

            Customer cust2 = new Customer() { ID = 2, Name = "John" };
            Customer cust3 = new Customer() { ID = 111, Name = "Tom" };
            Customer cust4 = new Customer() { ID = 222, Name = "James" };

            Dictionary<int, Customer> dictionarycustomers = new Dictionary<int, Customer>();
            dictionarycustomers.Add(cust1.ID, cust1);
            dictionarycustomers.Add(cust2.ID, cust2);
            dictionarycustomers.TryAdd(cust3.ID, cust3);
            dictionarycustomers.Add(cust4.ID, cust4);
            Console.WriteLine("The values of dictionary are as follows");
            foreach (KeyValuePair<int, Customer> kvp in dictionarycustomers)
            {
                Console.WriteLine(" Key = " + kvp.Key + "  " + " Value = " + kvp.Value);
            }

            Customer cust222 = dictionarycustomers[222];
            Console.WriteLine(" For Customer 222 the details : ID={0}, Name= {1} : ", cust222.ID, cust222.Name);
            Console.WriteLine($" Customer 222 Details : {cust222.ID} as ID and {cust222.Name} as Name");

            foreach (KeyValuePair<int, Customer> keyValuePair in dictionarycustomers)
            {
                Console.WriteLine(" The Key is : " + keyValuePair.Key);
                Customer cust = keyValuePair.Value;
                Console.WriteLine(" ID = " + cust.ID + " Name = " + cust.Name);
            }

            if (dictionarycustomers.ContainsKey(120))
            {
                Customer custobj = dictionarycustomers[120];
            }
            else
            {
                Console.WriteLine($"customer 120 does not exist");
            }

        }
    }
}
