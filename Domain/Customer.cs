using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace customerEmployeeManagementBackend.Domain
{
    public class Customer : Person
    {
        public Customer(PersonType type)
        {
            Type = type;
        }
        
        public PersonType Type { get; set; }
    }
}
