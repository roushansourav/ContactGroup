using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req1
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

        public override bool Equals(object obj)
        {
            Contact other = (Contact)obj;
            return this.Name.Equals(other.Name,StringComparison.OrdinalIgnoreCase)&& this.Mobile.Equals(other.Mobile, StringComparison.OrdinalIgnoreCase) && this.Email.Equals(other.Email, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("Name: {0}\nCompany: {1}\nTitle: {2}\nMobile: {3}\nAlternate Contact: {4}\nEmail: {5}\nDate Created: {6:dd-MM-yyyy}\n",Name,Company,Title,Mobile,AlternateMobile,Email,DateCreated);
        }
    }
}
