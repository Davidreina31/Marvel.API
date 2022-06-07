using System;
using System.Collections.Generic;

namespace Marvel.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Pseudo { get; set; }

        public ICollection<User_Hero> UserHero { get; set; }
    }
}
