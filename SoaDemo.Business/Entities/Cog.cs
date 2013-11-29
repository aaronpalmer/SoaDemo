using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using SoaDemo.Data;

namespace SoaDemo.Business.Entities
{
    public class Cog : DbCog, IValidatableObject
    {

        public List<string> ProgramCodesList
        {
            get
            {
                return (XElement.Parse(ProgramCodes)).Descendants("Code").Where(x => !String.IsNullOrEmpty(x.Value)).Select(node => node.Value).ToList();
            }
        }

        // entity validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            // put validation logic here

            if (Name == "error" || Name == "blah")
            {
                results.Add(new ValidationResult(string.Format("Name cannot be: '{0}'", Name)));
            }

            return results;
        }



    }
}
