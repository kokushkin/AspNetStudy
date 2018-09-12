using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlState.Models
{
    public class User
    {
        [Required(ErrorMessage = "Пожалуйста, введите имя")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Имя должно содержать от 3 до 20 символов")]
        [RegularExpression(@"^[A-Za-zА-Яа-я\s]+", ErrorMessage = "В имени допускаются только буквы и пробелы")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите возраст")]
        [Range(5, 100, ErrorMessage = "Возраст должен находится в пределах от 5 до 100")]
        public int Age { get; set; }

        public string Cell { get; set; }

        [CustomValidation(typeof(ControlState.CustomChecks), "CheckZip")]
        public string Zip { get; set; }
    }
}