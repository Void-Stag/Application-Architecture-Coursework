using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2659902___Library_System.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string Cardtype { get; set; }
        public int CSV { get; set; }
        public int ExpiryDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string OrderStatus { get; set; }
    }
}