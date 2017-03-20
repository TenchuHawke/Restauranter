using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RESTauranter.Models {
    public class Review 
    // : IValidatableObject
     {
        public int idReviews { get; set; }
        [Required]
        [MinLength(2)]
        public string ReviewerName { get; set; }
                [Required]
        [MinLength(2)]
        public string RestarauntName { get; set; }
                [Required]
        [Range(0,5)]
        public sbyte Stars { get; set; }
        [RequiredAttribute]
        [MinLengthAttribute(10)]
        public string Content { get; set; }

        public int Helpful { get; set; }
        public int Unhelpful { get; set; }
        [RequiredAttribute]
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