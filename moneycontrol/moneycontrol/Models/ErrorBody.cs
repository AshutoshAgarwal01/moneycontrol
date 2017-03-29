using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace moneycontrol.Models
{
    public class ErrorBody
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public ErrorBody(string code, string desc)
        {
            Code = code;
            Description = desc;
        }
    }
}