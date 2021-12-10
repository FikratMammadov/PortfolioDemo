using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Heading
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string  Name { get; set; }
        public DateTime Date { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
