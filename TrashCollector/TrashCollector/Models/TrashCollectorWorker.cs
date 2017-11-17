using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class TrashCollectorWorker
    {
        [Key]
        public int WorkerID { get; set; }

        [Required]
        [Display(Name = "First Name *")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name *")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "User Name *")]
        public string UserName { get; set; }    

        [Required]
        [Display(Name ="Email *")]
        public string Email { get; set; }   

        [Required]
        [Display(Name ="Password *")]
        public string Password { get; set; }

        [Required]
        [Display(Name ="Route Zip Code *")]
        public string RouteZipCode { get; set; }

        [Required]
        [Display(Name = "Price Per Pickup *")]
        public string PricePerPickUp { get; set; }

        public DateTime StartDay { get; set; }


    }
}