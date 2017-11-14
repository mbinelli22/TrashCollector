using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        
        //[Display(Name =aslkdfjaslkdjfaslkjf)]
        public string PickUpDay { get; set; }
        public string PricePerPickUp { get; set; }
        public DateTime DateSignedUp { get; set; }
        //foreign key
        //public virtual ICollection<TrashCollectorWorker> TrashCollectors { get; set; }

    }
}