using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoaDemo.Common.DTOs;

namespace SoaDemo.Business.Entities
{
    public class Sprocket : Common.Entities.Sprocket , IValidatableObject
    {
        // constructor to build object based on dto
        public Sprocket(SprocketDto sprocketDto)
        {
            Id = sprocketDto.Id;
            Name = sprocketDto.Name;
            Description = sprocketDto.Description;
        }

        // method to generate a dto from the object
        public SprocketDto GenerateDto()
        {
            return new SprocketDto { Id = Id, Name = Name, Description = Description };
        }

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