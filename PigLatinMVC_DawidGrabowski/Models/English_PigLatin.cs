using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PigLatinMVC_DawidGrabowski.Models
{
    public class English_PigLatin
    {
        [Display(Name = "Text in English")]
        [Required(ErrorMessage = "This cannot be empty, please enter a text!")]
        public string English_text { get; set; }

        [Display(Name = "Text in Pig Latin")]
        public string PigLatin_text { get; set; }
    }
}