using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SoaDemo.Services.Common.DataContracts
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime? LastUpdatedDate { get; set; }

        [DataMember]
        public List<string> ProgramCodes { get; set; }

        [DataMember]
        public List<string> ErrorMessages { get; set; } 

    }
}