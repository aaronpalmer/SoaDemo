using System;

namespace SoaDemo.Common.DTOs
{
    public class WidgetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}