using System;
using System.Collections.Generic;
using System.Text;
using GamerAccountApp.Entities;
using GamerAccountApp.Interfaces;

namespace GamerAccountApp.ManagerServices
{
    class CustomerManager
    {
        List<ICustomer> customers = new List<ICustomer>() { };

        public void Add(ICustomer Customer)
        {
            customers.Add(Customer);
            Console.WriteLine("{0} {1}, added from system", Customer.PlayerName, Customer.PlayerLastName);
        }

        public void Delete(ICustomer customer)
        {
            Console.WriteLine("{0} {1} , Deleted from system ", customer.PlayerName, customer.PlayerLastName);
        }

        public void Update(ICustomer customer, int Id)
        {

        }

        public void ListCustomer()
        {
            int i = 1;
            foreach (var customer in customers)
            {
                Console.WriteLine("***********    ***********");
                Console.WriteLine("{0}. Player \n Name Surname : {1} \n {2}\n Tc No:{3}\n BirthDate{4}",
                    i, customer.PlayerName, customer.PlayerLastName, customer.TcNo, customer.BirthYear);
                Console.WriteLine("***********    ***********");
                i += 1;
            }
            


        }

    }
}
