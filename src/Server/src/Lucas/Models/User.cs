using System;
using System.Collections.Generic;

namespace Lucas.Models
{
    public partial class User
    {
        public User()
        {
            Pet = new HashSet<Pet>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public DateTime? Bob { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual ICollection<Pet> Pet { get; set; }
    }
}
