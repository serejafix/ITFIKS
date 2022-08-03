using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_СookBook_DZ
{
    public class ReceptValidationName : ValidationRule
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
    public class ReceptValidationServingsCount : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int ServingsCount;

            if ((value == null) | !int.TryParse(value.ToString(), out ServingsCount))
                return new ValidationResult(false, "Is not a number");
            if (ServingsCount <= 0)
                return new ValidationResult(false, "Cannot be less than 0");

            return new ValidationResult(true, null);
        }
    }
    public class ReceptValidationCookingTime : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string CookingTime = value as string;

            if (string.IsNullOrEmpty(CookingTime))
            {
                return new ValidationResult(false, "Is empty!");
            }

            return new ValidationResult(true, null);
        }
    }
    public class ReceptValidationUnits : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string Units = value as string;


            if (string.IsNullOrEmpty(Units))
            {
                return new ValidationResult(false, "Is empty!");
            }

            return new ValidationResult(true, null);
        }
    }
    public class ReceptValidationCount : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int Count;

            if ((value == null) | !int.TryParse(value.ToString(), out Count))
                return new ValidationResult(false, "Is not a number");
            if (Count <= 0)
                return new ValidationResult(false, "Cannot be less than 0");

            return new ValidationResult(true, null);
        }
    }
}
