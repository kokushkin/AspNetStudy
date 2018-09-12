using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlState
{
    public class CustomChecks
    {
        public static ValidationResult CheckZip(string zipCode)
        {
            return zipCode != null && zipCode.ToLower().StartsWith("00") ?
                ValidationResult.Success : new ValidationResult("Индекс должен начинаться с 00");
        }
    }
}