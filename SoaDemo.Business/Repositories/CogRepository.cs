using System.Data.Objects;
using System.Linq;
using SoaDemo.Business.Entities;
using SoaDemo.Data.Common;
using SoaDemo.Service.Common.DataContracts;

namespace SoaDemo.Business.Repositories
{
    public class CogRepository
    {
        public Product GetCog(int id)
        {
            using (var entities = new SoaDemoEntities())
            {
                var dbCog = entities.uspCogs_Get(id).FirstOrDefault();
                if (dbCog == null) return null;

                var cog = (Cog)dbCog;

                return new Product
                       {
                           Id = cog.Id,
                           Name = cog.Name,
                           Description = cog.Description,
                           ProgramCodes = cog.ProgramCodesList
                       };
            }
        }

        public Product SaveCog(Product product)
        {
            var cog = Assembler.ProductToCog(product);

            using (var entities = new SoaDemoEntities())
            {
                var dbCog = entities.uspCogs_Get(cog.Id).FirstOrDefault();
                if (dbCog == null)
                {
                    var newId = new ObjectParameter("NewId", typeof (int));
                    var whatAmI = entities.uspCogs_Insert(cog.Name, cog.Description, newId);
                    cog.Id = (int)newId.Value;
                }

                return Assembler.CogToProduct(cog);
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
