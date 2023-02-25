using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public class Authors
    {
        [Key]
        public int AuthorsID { get; set; }
        public string? AuthorName { get; set; }
        public List<Books> Books { get; set; } = new List<Books>(); // relacja 1:n od strony 1 autor : wielu książek
    }
}
