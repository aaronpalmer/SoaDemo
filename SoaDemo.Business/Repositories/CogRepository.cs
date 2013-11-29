using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects;
using System.Linq;
using SoaDemo.Data;
using SoaDemo.Services.Common.DataContracts;
using SoaDemo.Services.Common.Interfaces;

namespace SoaDemo.Business.Repositories
{
    public class CogRepository : ICogRepository
    {
        public Product GetCog(int id)
        {
            using (var entities = new SoaDemoEntities())
            {
                var dbCog = entities.uspCogs_Get(id).FirstOrDefault();

                return dbCog == null 
                    ? new Product {ErrorMessages = new List<string> { string.Format("Cog '{0}' does not exist.", id)}} 
                    : ProductAssembler.CreateProduct(dbCog);
            }
        }

        public Product SaveCog(Product product)
        {
            var cog = ProductAssembler.CreateCog(product);

            // validation -- if we don't pass validation, tag validation results onto the input product and return it
            var validationContext = new ValidationContext(cog);
            var validationResults = cog.Validate(validationContext).ToList();

            if (validationResults.Any())
            {
                product.ErrorMessages = new List<string>();
                foreach (var validationResult in validationResults)
                {
                    if (validationResult != null) product.ErrorMessages.Add(validationResult.ErrorMessage);
                }
                return product;
            }

            using (var entities = new SoaDemoEntities())
            {
                var dbCog = entities.uspCogs_Get(cog.Id).FirstOrDefault();

                // optimistic concurrency check would go here, pseudo-code:

                //if (dbCog.Timestamp <> cog.Timestamp)  

                // We can't just do a > comparison because of the possibility of time differences between server nodes
                // a <> comparison accounts for any change in timestamp

                //{
                //  product.ErrorMessages.Add("So sorry, someone else got to this one first.");
                //  return product;
                //}

                if (dbCog == null)
                {
                    var newId = new ObjectParameter("NewId", typeof (int));
                    entities.uspCogs_Insert(cog.Name, cog.Description, newId);
                    cog.Id = (int) newId.Value;
                }
                else
                {
                    entities.uspCogs_Update(cog.Id, cog.Name, cog.Description);
                }

                return ProductAssembler.CreateProduct(cog);
            }
        }

        public bool DeleteCog(int id)
        {
            using (var entities = new SoaDemoEntities())
            {
                var dbCog = entities.uspCogs_Get(id).FirstOrDefault();
                if (dbCog == null) return true;

                entities.uspCogs_Delete(id);
            }
            return true;
        }
    }
}
