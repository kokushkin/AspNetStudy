using ModelValidation.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models
{
    //[NoVasyaOnMonday]
    public class Appointment//: IValidatableObject
    {
        [Required(ErrorMessage = "Введите свое имя")]
        [StringLength(10, MinimumLength = 3)]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        //[FutureDate(ErrorMessage = "Введите дату относящуюся к будущему")]
        public DateTime Date { get; set; }

        //[MustBeTrue(ErrorMessage = "Вы должны принять условия")]
        public bool TermsAccepted { get; set; }

        //public IEnumerable<ValidationResult> Validate(
        //    ValidationContext validationContext)
        //{
        //    List<ValidationResult> errors = new List<ValidationResult>();

        //    if (String.IsNullOrEmpty(ClientName))
        //        errors.Add(new ValidationResult("Введите свое имя"));

        //    if (DateTime.Now > Date)
        //        errors.Add(new ValidationResult("Введите дату относящуюся к будущему"));

        //    if (errors.Count == 0 && ClientName == "Вася" &&
        //        Date.DayOfWeek == DayOfWeek.Monday)
        //        errors.Add(new ValidationResult("Васи в понедельник отдыхают!"));

        //    if (!TermsAccepted)
        //        errors.Add(new ValidationResult("Вы должны принять условия"));

        //    return errors;
        //}
    }
}