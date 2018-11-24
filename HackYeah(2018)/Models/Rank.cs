using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackYeah_2018_.Models
{
    public class Rank
    {
        public long Id { get; set; }
        public User User { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime Date { get; set; }
    }
}
