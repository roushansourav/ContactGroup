using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> list = new List<Contact>();
            ContactBO cb = new ContactBO();
            Console.WriteLine("Enter the number of contact details:");
            int n = Convert.ToInt32(Console.ReadLine());
            //fill code here.
            for(int i=0;i<n;i++)
            {
                string[] detail = Console.ReadLine().Split(',');
                list.Add(new Contact(detail[0], detail[1], detail[2], detail[3], detail[4], detail[5], DateTime.Parse(detail[6])));
            }
            Console.WriteLine("Enter a search type:\n1.Name\n2.Date created\n3.Email domain");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the names:");
                String names = Console.ReadLine();
                string[] inp = names.Split(',');
                List<string> name = new List<string>();
                for(int i=0;i<inp.Length;i++)
                {
                    name.Add(inp[i]);
                }
                //fill code here.
                foreach(Contact c in cb.FindContact(list,name))
                    Console.WriteLine(c);

                

            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the date to search contacts that were created on that date");
                //fill code here.
                DateTime dt = DateTime.Parse(Console.ReadLine());
                foreach (Contact c in cb.FindContact(list, dt))
                    Console.WriteLine(c);

            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the Email domain to search contacts that have same email domain");
                String domain = Console.ReadLine();
                //fill code here.
                foreach (Contact c in cb.FindContact(list, domain))
                    Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
