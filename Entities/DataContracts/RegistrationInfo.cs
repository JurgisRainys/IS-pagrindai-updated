using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Entities.DataContracts
{
    public class RegistrationInfo
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
