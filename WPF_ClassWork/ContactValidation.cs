using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_ClassWork
{
    
    public class ContactValidationFirstName : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string FirstName = value as string;
            if (string.IsNullOrEmpty(FirstName))
            {
                return new ValidationResult(false, "Is empty!");
            }
            return new ValidationResult(true, null);

        }
    }
    public class ContactValidationLastName : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string LastName = value as string;
            if (string.IsNullOrEmpty(LastName))
            {
                return new ValidationResult(false, "Is empty!");
            }

            return new ValidationResult(true, null);

        }
    }
    public class ContactValidationCompany : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string Company = value as string;

            if (string.IsNullOrEmpty(Company))
            {
                return new ValidationResult(false, "Is empty!");
            }

            return new ValidationResult(true, null);
        }
    }
    public class ContactValidationEmail : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string Email = value as string;
            if (string.IsNullOrEmpty(Email))
            {
                return new ValidationResult(false, "Is empty!");
            }
            return new ValidationResult(true, null);
        }
    }
    public class ContactValidationNumber : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            string Number = value as string;

            if (string.IsNullOrEmpty(Number))
            {
                return new ValidationResult(false, "Is empty!");
            }

            return new ValidationResult(true, null);

        }
    }
}
