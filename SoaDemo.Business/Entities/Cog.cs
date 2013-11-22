using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoaDemo.Common.DTOs;

namespace SoaDemo.Business.Entities
{
    public class Cog : Common.Entities.Cog, IValidatableObject
    {
        // constructor to build object based on dto
        public Cog(CogDto cogDto)
        {
            Id = cogDto.Id;
            Name = cogDto.Name;
            Description = cogDto.Description;
        }



        // method to generate a dto from the object
        public CogDto GenerateDto()
        {
            return new CogDto {Id = Id, Name = Name, Description = Description};
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
