using System;
using System.ComponentModel.DataAnnotations;
namespace RESTauranter {
    public class InThePast : RangeAttribute {
        public InThePast (): base (typeof (DateTime),
            DateTime.Now.AddYears (-100).ToString (),
            DateTime.Now.ToString ()) {
        }
        public override bool IsValid (object value) {
            return (((DateTime) value > (DateTime) Minimum) && ((DateTime) value < (DateTime) Maximum));
        }
    }
}

public class PastDated  : ValidationAttribute {
        private DateTime CurrentDate;

        public PastDated() {
            CurrentDate = DateTime.Now;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime setVal = (DateTime)value;
            if(setVal < CurrentDate) {
                return ValidationResult.Success;
            }
            return new ValidationResult("Date of visit must be dated for the past!");
        }
    }