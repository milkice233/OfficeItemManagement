using System;

namespace OfficeItemManagement.Data.Model
{
    public enum EExportStatus
    {
        Pending, Accepted,Rejected
    }
    public class Export
    {
        public int Id { get; set; }
        public User Initiator { get; set; }
        public EExportStatus Status { get; set; }
        public DateTime InitTime { get; set; }
        public DateTime ResponseTime { get; set; }
    }
}