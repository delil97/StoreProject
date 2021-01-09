using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Core.Models
{
    public class Ad
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Cost { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Adress Adress { get; set; }
    }
}
