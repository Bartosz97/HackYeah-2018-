using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackYeah_2018_.Models
{
    public class Ticket
    {
        public long Id { get; set; }
        public User User { get; set; }
        public float Latitude { get; set; }
        public float Length { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
