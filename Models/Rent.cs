using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace P2659902___Library_System.Models
{
    public class Rent
    {
       [Key] public int Id { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("Book")] //Foreign Key for Book model
        public int BookId { get; set; }
        public virtual Book Book { get; set; } //Used for navigating to the book model
    }
}