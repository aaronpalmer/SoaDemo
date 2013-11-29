using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using SoaDemo.Business.Entities;
using SoaDemo.Data;
using SoaDemo.Services.Common.DataContracts;

namespace SoaDemo.Business
{
    public static class ProductAssembler
    {
        public static Product CreateProduct(Cog cog)
        {
            return new Product
            {
                Description = cog.Description,
                Id = cog.Id,
                Name = cog.Name,
                ProgramCodes = cog.ProgramCodesList,
            };
        }
        public static Product CreateProduct(DbCog dbCog)
        {
            return new Product
            {
                Description = dbCog.Description,
                Id = dbCog.Id,
                Name = dbCog.Name,
                ProgramCodes = ProgramCodeXmlStringToList(dbCog.ProgramCodes)
            };
        }
        public static Product CreateProduct(Sprocket sprocket)
        {
            return new Product
            {
                Description = sprocket.Description,
                Id = sprocket.Id,
                Name = sprocket.Name
            };
        }
        public static Product CreateProduct(DbSprocket dbSprocket)
        {
            return new Product
            {
                Description = dbSprocket.Description,
                Id = dbSprocket.Id,
                Name = dbSprocket.Name
            };
        }
        public static Product CreateProduct(Widget widget)
        {
            return new Product
            {
                Description = widget.Description,
                Id = widget.Id,
                Name = widget.Name,
                LastUpdatedDate = widget.LastUpdatedDate
            };
        }
        public static Product CreateProduct(DbWidget dbWidget)
        {
            return new Product
            {
                Description = dbWidget.Description,
                Id = dbWidget.Id,
                Name = dbWidget.Name,
                LastUpdatedDate = dbWidget.LastUpdatedDate
            };
        }
        
        public static Cog CreateCog(Product product)
        {
            return new Cog
                      {
                          Description = product.Description,
                          Id = product.Id,
                          Name = product.Name,
                          ProgramCodes = ProgramCodeListToXmlString(product.ProgramCodes)
                      };
        }
        public static Cog CreateCog(DbCog dbCog)
        {
            return new Cog
            {
                Description = dbCog.Description,
                Id = dbCog.Id,
                Name = dbCog.Name,
                ProgramCodes = dbCog.ProgramCodes
            };
        }
        public static DbCog CreateDbCog(Cog cog)
        {
            return new DbCog
            {
                Description = cog.Description,
                Id = cog.Id,
                Name = cog.Name,
                ProgramCodes = cog.ProgramCodes
            };
        }

        public static Sprocket CreateSprocket(Product product)
        {
            return new Sprocket
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name
            };
        }
        public static Sprocket CreateSprocket(DbSprocket dbSprocket)
        {
            return new Sprocket
            {
                Description = dbSprocket.Description,
                Id = dbSprocket.Id,
                Name = dbSprocket.Name
            };
        }
        public static DbSprocket CreateDbSprocket(Sprocket sprocket)
        {
            return new DbSprocket
            {
                Description = sprocket.Description,
                Id = sprocket.Id,
                Name = sprocket.Name
            };
        }

        public static Widget CreateWidget(Product product)
        {
            return new Widget
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                LastUpdatedDate = product.LastUpdatedDate
            };
        }
        public static Widget CreateWidget(DbWidget dbWidget)
        {
            return new Widget
            {
                Description = dbWidget.Description,
                Id = dbWidget.Id,
                Name = dbWidget.Name,
                LastUpdatedDate = dbWidget.LastUpdatedDate
            };
        }
        public static DbWidget CreateDbWidget(Widget widget)
        {
            return new DbWidget
            {
                Description = widget.Description,
                Id = widget.Id,
                Name = widget.Name,
                LastUpdatedDate = widget.LastUpdatedDate
            };
        }

        // private methods
        private static string ProgramCodeListToXmlString(IEnumerable<string> programCodeList)
        {
            // transform program code list into xml string for underlying db entity
            var programCodes = new XElement("ProgramCodes");
            if (programCodeList != null)
            {
                foreach (var code in programCodeList)
                {
                    programCodes.SetElementValue("Code", code);
                }
            }
            return programCodes.ToString();
        }
        private static List<string> ProgramCodeXmlStringToList(string programCodeXmlString)
        {
            return (XElement.Parse(programCodeXmlString)).Descendants("Code").Where(x => !String.IsNullOrEmpty(x.Value)).Select(node => node.Value).ToList();
        }
    }
}
