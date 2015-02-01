using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpecFlowDemo.Models
{
    public class BillableHours
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tid saknas")]
        [Display(Name = "Tid")]
        public string Tid { get; set; }

        [Required(ErrorMessage = "Kund saknas")]
        [Display(Name = "Kund")]
        public string Kund { get; set; }

        [Display(Name = "Kommentar")]
        public string Kommentar { get; set; }
    }
}