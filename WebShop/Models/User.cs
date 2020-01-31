using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class User
    {

        public Guid ID { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Adress { get; set; }

        public string City { get; set; }

        public int Zip { get; set; }



    }





}
