using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req2
{
    class Contact
    {
        string _name;
        string _company;
        string _title;
        string _mobile;
        string _alternateMobile;
        string _email;
        DateTime _dateCreated;

        public Contact(string name, string company, string title, string mobile, string alternateMobile, string email, DateTime dateCreated)
        {
            Name = name;
            Company = company;
            Title = title;
            Mobile = mobile;
            AlternateMobile = alternateMobile;
            Email = email;
            DateCreated = dateCreated;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Company { get { return _company; } set { _company = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Mobile { get { return _mobile; } set { _mobile = value; } }
        public string AlternateMobile { get { return _alternateMobile; } set { _alternateMobile = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public DateTime DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }

        
        public override string ToString()
        {
            return string.Format("{0}{1,20}{2,20}{3,20}{4,20}{5,20}{6,20}", Name, Company, Title, Mobile, AlternateMobile, Email, DateCreated.ToShortDateString());
        }
    }
}
