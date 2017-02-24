using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Models
{
    public class Personnel
    {
        private readonly List<Gender> _genders = new List<Gender>
        {
            new Gender { ID = 1, Name = "Male" },
            new Gender { ID = 2, Name = "Female" }
        };

        private readonly List<Status> _statuses = new List<Status>
        {
            new Status { ID = 1, Name = "Single" },
            new Status { ID = 2, Name = "Married" }
        };

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Lastname { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        public string TC { get; set; }
        
        [Required]
        public int Gender { get; set; }

        [Required]
        public int Status { get; set; }
        
        [Required]
        public bool HaveKid { get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        public string Info { get; set; }

        public IEnumerable<SelectListItem> Genders
        {
            get {
                return new SelectList(_genders, "ID", "Name");
            }
        }

        public  IEnumerable<SelectListItem> Statuses
        {
            get {
                return new SelectList(_statuses, "ID", "Name");
            }
        }
    }
}