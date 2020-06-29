using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAnalyser.Models.Modelos
{
    public class Login
    {
        [Display(Name = "Personal Details:")]
        [Required(ErrorMessage = "Personal Details is required.")]
        [AllowHtml]
        public string PersonalDetails { get; set; }
    }
}