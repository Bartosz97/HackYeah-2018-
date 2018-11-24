using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HackYeah_2018_.Models
{
    public class Rank
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Ticket")]
        public int RankTicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
        [ForeignKey("User")]
        public int RankUserId { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }

    }
}
