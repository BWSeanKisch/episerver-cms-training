using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlloyTraining.Business.Validation
{
    public class OperaYearAttribute : ValidationAttribute
    {
        public OperaYearAttribute()
        {
            ErrorMessage = "The first opera was dope. Especially back in 1597";
        }
        public override bool IsValid(object value)
        {
            if (!(value is int)) return false;
            return ((int)value) > 1597;
        }
    }
}