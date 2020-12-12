using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Core.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string PostalCity { get; set; }
        public int PostalCode { get; set; }
    }
}
