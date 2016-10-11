using CustomModel01.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomModel01.Models
{
    public class Login
    {
        [BoolRequired(ErrorMessage = "請勾選同意")]
        public bool Agree { get; set; }
    }
}