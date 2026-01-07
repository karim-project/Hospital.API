using Hospital.core.Features.Doctors.Commands.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Doctors.Commands.Validation
{
    public class CustomLengthAttribute : ValidationAttribute
    {
        private readonly int _minLenght;
        private readonly int _maxlenght;

        public CustomLengthAttribute(int minLenght, int maxlenght)
        {
            _minLenght = minLenght;
            _maxlenght = maxlenght;
        }
        public override bool IsValid(object? value)
        {
            if (value is string result)
            {
                if (result.Length >= _minLenght && result.Length <= _maxlenght)
                    return true;
            }
            return false;
        }
        public override string FormatErrorMessage(string name)
        {
            return $"the field {name} must be between {_minLenght} and {_maxlenght}";
        }
    }
}
