using System;
using System.Collections;
using System.Collections.Generic;

namespace Marvel.Entities
{
    public class Hero
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public ICollection<User_Hero> UserHero { get; set; }
    }
}
