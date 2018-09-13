using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControlState.Models
{
    public class User : IValidatableObject
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Name == "Вася" && Age < 20)
            {
                errors.Add(
                    new ValidationResult("Васям до 20 лет доступ на сайт запрещен!"));
            }
            return errors;
        }
    }
}