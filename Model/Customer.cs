using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Customer(string fullname, string address)
        {
            _fullname = fullname;
            _address = address;
        }
    }
}
