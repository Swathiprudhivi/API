using System;
using System.Collections.Generic;

namespace APIASS.Models
{
    public partial class Products
    {
        public int Pid { get; set; }
        public double Price { get; set; }
        public int Stocknum { get; set; }
        public string Pname { get; set; }
        public int Subcatid { get; set; }
    }
}
