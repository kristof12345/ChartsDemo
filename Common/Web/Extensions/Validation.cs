using System;
using System.ComponentModel.DataAnnotations;

namespace Common.Web
{
    public class FutureDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime > DateTime.Now ? ValidationResult.Success : new ValidationResult("A future date is required. " + dateTime.ToString("yyyy.MM.dd.hh:mm:ss"));
        }
    }

    public class PastDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime < DateTime.Now ? ValidationResult.Success : new ValidationResult("A past date is required. " + dateTime.ToString("yyyy.MM.dd.hh:mm:ss"));
        }
    }

    public class ZeroValue : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int num = (int)value;
            return num == 0 ? ValidationResult.Success : new ValidationResult("Zero value is required.");
        }
    }
}
