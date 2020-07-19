using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.CustomerModel
{
    public class CustomerModels
    {
        private int id;
        private string name;
        private long phoneNumber;
        private int pincode;
        private string city;
        private string email;
        private string locality;
        private string landmark;
        private string address;
        private string typeOfLocation;

        [Required]
        public string Name { get => name; set => name = value; }

        [Required]
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [Required]
        public int Pincode { get => pincode; set => pincode = value; }

        [Required]
        public string Locality { get => locality; set => locality = value; }

        [Required]
        public string Landmark { get => landmark; set => landmark = value; }

        [Required]
        public string Address { get => address; set => address = value; }

        [Required]
        public string TypeOfLocation { get => typeOfLocation; set => typeOfLocation = value; }

        public int Id { get => id; set => id = value; }

        [Key]
        [Required]
        public string Email { get => email; set => email = value; }

        [Required]
        public string City { get => city; set => city = value; }

    }
}
