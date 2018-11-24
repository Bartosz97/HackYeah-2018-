using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackYeah_2018_.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public long Number { get; set; }
        public string Name { get; set; }
    }
}
