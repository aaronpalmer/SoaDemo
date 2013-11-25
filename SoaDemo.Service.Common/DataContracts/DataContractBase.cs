using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SoaDemo.Service.Common.DataContracts
{
    [DataContract]
    public class DataContractBase
    {
        [DataMember]
        public List<ValidationResult> ValidationResults { get; set; }
    }
}