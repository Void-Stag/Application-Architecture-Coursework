using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2659902___Library_System.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Copies { get; set; }
        public string BookCover { get; set; }
        public string Rating { get; set; }
    }
}