using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayThree.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsOnSale { get; set; }
        public string Author { get; set; }
    }
}
