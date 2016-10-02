using CustomModel01.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomModel01.Models
{
    public class Book
    {
        [ContainWord("MVC", ErrorMessage = "請輸入包含MVC的書")]
        public string Name { get; set; }
    }
}