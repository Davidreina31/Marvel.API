using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marvel.Entities
{
    public class User_Hero
    {
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("Hero")]
        public Guid HeroId { get; set; }

        public Hero Hero { get; set; }
    }
}
