using System.Collections;
using System.Collections.Generic;

namespace OfficeItemManagement.Data.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public ProductionRegion Region { get; set; }
        public string Specification { get; set; }
        public string Model { get; set; }
        public string Picture { get; set; }
        public ICollection<Export> ExportRecords { get; set; }
        public ICollection<Import> ImportRecords { get; set; }
    }
}