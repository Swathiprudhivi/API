using System;
using System.Collections.Generic;

namespace APIASS.Models
{
    public partial class Sellers
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Spassword { get; set; }
        public string Companyname { get; set; }
        public int Gstin { get; set; }
        public int Sphnum { get; set; }
        public string Semail { get; set; }
        public string PostalAddress { get; set; }
    }
}
