using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Basics2
{
    public class List1customer
    {
        public int ID { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }

        public static void Listfun1()
        {

            List1customer cust1 = new List1customer
            {
                ID = 101,
                Name = "Tulip",
                Salary = 1000
            };

            List1customer cust2 = new List1customer
            {
                ID = 102,
                Name = "Phillips",
                Salary = 2000
            };
            List1customer cust3 = new List1customer
            {
                ID = 103,
                Name = "Jonnas",
                Salary = 3000
            };
            List1customer cust4 = new List1customer
            {
                ID = 104,
                Name = "Nomass",
                Salary = 4000
            };
            List<List1customer> Customers = new List<List1customer>(2);
            Customers.Add(cust1);
            Customers.Add(cust2);
            Customers.Add(cust3);
            Customers.Add(cust4);
            
            List1customer c = Customers[0];
            Console.WriteLine("ID={0}, Name={1}, Salary={2}", c.ID, c.Name,c.Salary);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (List1customer lc in Customers)
            {
                Console.WriteLine(" ID = {0}, Name={1}, Salary={2}", lc.ID, lc.Name,lc.Salary);
            }
            Console.ResetColor();
            for(int i=0; i<Customers.Count;i++)
            {
                List1customer lcc = Customers[i];
                Console.WriteLine($"ID is {lcc.ID}, Name is {lcc.Name} and Salary is {lcc.Salary}");
            }

        }
    }

}
