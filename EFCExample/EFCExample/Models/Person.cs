using System;
using System.Collections.Generic;
using System.Text;

namespace EFCExample.Models
{
   public class Person
    {
        //Convención de Entity Framework
        //Primary Key
        public int PersonID { get; set; }          
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
