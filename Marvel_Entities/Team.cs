using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marvel.Entities
{
    public class Team
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Hero> Heroes { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }

    }
}
