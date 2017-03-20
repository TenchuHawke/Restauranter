using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RESTauranter.Models {
    public class Review 
    // : IValidatableObject
     {
        public int ReviewId { get; set; }
        [Required]
        [MinLength(2)]
        public string ReviewerName { get; set; }
                [Required]
        [MinLength(2)]
        public string RestarauntName { get; set; }
                [Required]
        [Range(0,5)]
        public int Stars { get; set; }
        [Required]
        [MinLengthAttribute(10)]
        public string Content { get; set; }

        public int Helpful { get; set; }
        public int Unhelpful { get; set; }
        [Required]
        [InThePast]
        public DateTime DateOfVisit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        // {
        //     throw new NotImplementedException();
        // }
    }
}