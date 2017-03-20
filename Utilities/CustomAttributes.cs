using System;
using System.ComponentModel.DataAnnotations;
namespace RESTauranter {
    public class InThePast : ValidationAttribute {
        private DateTime CurrentDate;

        public InThePast () {
            CurrentDate = DateTime.Now;
        }

        protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
            DateTime setVal = (DateTime) value;
            if (setVal < CurrentDate) {
                return ValidationResult.Success;
            }
            return new ValidationResult ("Date of visit must be in the past!");
        }
    }
}