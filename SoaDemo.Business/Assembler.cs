using System.Collections.Generic;
using System.Xml.Linq;
using SoaDemo.Business.Entities;
using SoaDemo.Service.Common.DataContracts;

namespace SoaDemo.Business
{
    public static class Assembler
    {
        // Cog mappings
        public static Cog ProductToCog(Product dto)
        {
            return new Cog
                      {
                          Description = dto.Description,
                          Id = dto.Id,
                          Name = dto.Name,
                          ProgramCodes = ProgramCodeListToXmlString(dto.ProgramCodes)
                      };
        }
        public static Product CogToProduct(Cog cog)
        {
            return new Product
                   {
                       Description = cog.Description,
                       Id = cog.Id,
                       Name = cog.Name,
                       ProgramCodes = cog.ProgramCodesList
                   };
        }

        // Sprocket mappings
        public static Sprocket ProductToSprocket(Product dto)
        {
            return new Sprocket
            {
                Description = dto.Description,
                Id = dto.Id,
                Name = dto.Name
            };
        }
        public static Product SprocketToProduct(Sprocket sprocket)
        {
            return new Product
            {
                Description = sprocket.Description,
                Id = sprocket.Id,
                Name = sprocket.Name
            };
        }

        //Widget mappings
        public static Widget ProductToWidget(Product dto)
        {
            return new Widget
            {
                Description = dto.Description,
                Id = dto.Id,
                Name = dto.Name,
                LastUpdatedDate = dto.LastUpdatedDate
            };
        }
        public static Product WidgetToProduct(Widget widget)
        {
            return new Product
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
            foreach (var code in programCodeList)
            {
                programCodes.SetElementValue("Code", code);
            }
            return programCodes.ToString();
        } 
    }
}
