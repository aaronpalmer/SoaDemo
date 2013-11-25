using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using SoaDemo.Data.Common;

namespace SoaDemo.Business.Entities
{
    public class Cog : DbCog, IValidatableObject
    {

        public List<string> ProgramCodesList
        {
            get { return (new XElement(ProgramCodes)).Descendants("Code").Select(node => node.Value).ToList(); }
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
