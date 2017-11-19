using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name = "First Name *")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name *")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="User Name *")]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="Email *")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Password *")]
        public string Password { get; set; }

        [Required]
        [Display(Name ="Address *")]
        public string Address { get; set; }

        [Required]
        //[ForeignKey("ZipCode")]
        [Display(Name ="Zip Code *")]
        public string ZipCode { get; set; }
        
        [Display(Name ="Price Per Trash Pick Up")]
        public int PricePerPickUp { get; set; }

        [Required]
        [Display(Name = "Pick Up Day *")]
        public string PickUpDay { get; set; }

        [Display(Name = "Date Signed Up")]
        public DateTime DateSignedUp { get; set; }
        //foreign key
        //public virtual ICollection<TrashCollectorWorker> TrashCollectors { get; set; }
        

    }
}