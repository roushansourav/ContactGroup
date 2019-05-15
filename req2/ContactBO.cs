using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace req2
{
    class ContactBO
    {
        public List<Contact> FindContact(List<Contact>contactList, List<string> name)
        {
            List<Contact> result = new List<Contact>();
            foreach(string s in name)
            {
                foreach(Contact c in contactList)
                {
                    if (s.Equals(c.Name))
                        result.Add(c);
                }
            }
            return result;
        }

        public List<Contact> FindContact(List<Contact>contactList, DateTime dateCreated)
        {
            var result = from p in contactList
                         where p.DateCreated == dateCreated
                         select p;
            return result.ToList<Contact>();
        }

        public List<Contact> FindContact(List<Contact>contactList, string domain)
        {
            List<Contact> result = new List<Contact>();
            foreach(Contact c in contactList)
            {
                if (Regex.IsMatch(c.Email, ("@"+ domain+@"\.")))
                    result.Add(c);
            }
            return result;
        }
    }
}
