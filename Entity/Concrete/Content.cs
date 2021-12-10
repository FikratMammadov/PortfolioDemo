using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime Date { get; set; }

        public int HeadingId { get; set; }
        public Heading Heading { get; set; }

        public int? WriterId { get; set; }
        public Writer Writer { get; set; }
    }
}
