using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Address
    {
        private string city;
        private string state;
        private int zip;
        private object phoneNumber;
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public int Zip
        {
            get
            {
                return this.zip;
            }
            set
            {
                this.zip = value;
            }
        }

        public object PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }

        }
    }
}
