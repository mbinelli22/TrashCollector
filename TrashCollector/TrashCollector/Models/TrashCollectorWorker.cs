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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name = "User name")]
        public string UserName { get; set; }

        public string Password { get; set; }

        [Display(Name ="Route Zip Code")]
        public string RouteZipCode { get; set; }

        public DateTime StartDay { get; set; }


    }
}