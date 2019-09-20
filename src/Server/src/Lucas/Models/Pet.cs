using System;
using System.Collections.Generic;

namespace Lucas.Models
{
    public partial class Pet
    {
        public int PetId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool? IsOwner { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual User User { get; set; }
    }
}
