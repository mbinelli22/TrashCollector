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

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string ZipCode { get; set; }
        
        [Display(Name = "Pick Up Days")]
        public string PickUpDay { get; set; }

        [Display(Name = "Price Per Pickup")]
        public string PricePerPickUp { get; set; }

        [Display(Name = "Date Signed Up")]
        public DateTime DateSignedUp { get; set; }
        //foreign key
        //public virtual ICollection<TrashCollectorWorker> TrashCollectors { get; set; }

    }
}