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

    public class 