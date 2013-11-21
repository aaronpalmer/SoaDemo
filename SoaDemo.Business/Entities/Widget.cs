using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoaDemo.Common.DTOs;

namespace SoaDemo.Business.Entities
{
    public class Widget : Common.Entities.Widget, IValidatableObject
    {
        // constructor to build object based on dto
        public Widget(WidgetDto widgetDto)
        {
            Id = widgetDto.Id;
            Name = widgetDto.Name;
            Description = widgetDto.Description;
            LastUpdatedDate = widgetDto.LastUpdatedDate;
        }

        // method to generate a dto from the object
        public WidgetDto GenerateDto()
        {
            return new WidgetDto { Id = Id, Name = Name, Description = Description, LastUpdatedDate = LastUpdatedDate};
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