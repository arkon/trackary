﻿using System.ComponentModel.DataAnnotations;

namespace TrackaryASP.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Student number")]
        public int StudentNumber { get; set; }

        public string UTORid { get; set; }

        [Display(Name = "TCard Barcode")]
        public string TCardBarcode { get; set; }

        [DataType(DataType.Currency)]
        public decimal Rewards { get; set; }
    }
}