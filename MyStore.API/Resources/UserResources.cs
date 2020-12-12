using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.API.Resources
{
    public class UserResources
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AdressResources Adress { get; set; }
    }
}
