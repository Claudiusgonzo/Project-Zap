﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Project.Zap.Models
{
    public class AddLocationViewModel
    {

        [BindProperty]
        [Required, StringLength(30, MinimumLength = 5)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        public string ZipOrPostcode { get; set; }

        [BindProperty]
        [Required]
        public string Address { get; set; }

    }

    [BindRequired]
    public class LocationViewModel
    {

        [BindProperty]
        [Required, StringLength(30, MinimumLength = 5)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        public string ZipOrPostcode { get; set; }

        public string Address { get; set; }
    }
}