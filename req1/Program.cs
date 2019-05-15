using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contact 1 detail:");
            string contact1Detail = Console.ReadLine();
            //fill code here.
            string[] input = contact1Detail.Split(',');
            Contact c1 = new Contact(input[0],input[1],input[2], input[3], input[4], input[5], DateTime.Parse(input[6]));
            Console.WriteLine("Enter contact 2 detail:");
            string contact2Detail = Console.ReadLine();
            //fill code here.
            string[] input1 = contact1Detail.Split(',');
            Contact c2 = new Contact(input1[0], input1[1], input1[2], input1[3], input1[4], input1[5], DateTime.Parse(input1[6]));

            Console.WriteLine("\nContact 1:");
            Console.WriteLine(c1);
            Console.WriteLine("\nContact 1:");
            Console.WriteLine(c2);

            if(c1.Equals(c2))
                Console.WriteLine("Contact 1 is same as Contact 2");
            else
                Console.WriteLine("Contact 1 and Contact 2 are different");
        }
    }
}
