﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoaDemo.Data;

namespace SoaDemo.Business.Entities
{
    public class Widget : DbWidget, IValidatableObject
    {
        // entity validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            // put validation logic here

            // we can also do stuff like this...
            Validator.TryValidateProperty(Name, new ValidationContext(this, null, null) { MemberName = "Name" }, results);

            return results;
        }
    }
}