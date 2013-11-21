using System.Collections.Generic;
using System.Linq;
using SoaDemo.Common.Entities;

namespace SoaDemo.Data.Repositories
{
    public class CogRepository
    {
        public List<Cog> GetCogs(int? id)
        {
            var results = new List<Cog>();

            using (var entities = new SoaDemoEntities())
            {
                var cogs = entities.uspCogs_Get(null).ToList();
            }

            return results;
        }

        public void SaveCog(Cog cog)
        {
            using (var entities = new SoaDemoEntities())
            {
                var dbCog = entities.uspCogs_Get(cog.Id).FirstOrDefault();

                if (dbCog == null)
                {
                    // this should perform an insert
                    entities.Cogs.Add(cog);
                }
                else
                {
                    // this should perform an update
                    dbCog = cog;
                }

                entities.SaveChanges();

            }
        }

    }
}
