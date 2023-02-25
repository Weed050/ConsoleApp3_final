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
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
       
    }
}
