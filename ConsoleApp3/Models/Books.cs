using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public class Books
    {
        [Key]
        public int BooksId { get; set; }
        public Authors AuthorName { get; set; }
        public int AuthorID{ get; set; } // AuthorID jest w tabeli Blog2 a AuthorsID w tabeli Authors

        public string bookName { get; set;}
    }
}
