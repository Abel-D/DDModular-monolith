using System.ComponentModel.DataAnnotations;

namespace Excellerent.Standard.Advanced.Shared.Application.Data.Seed
{
    public class BaseAuditModel
    {
        public BaseAuditModel()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
        [Key]
        public virtual Guid Guid { get; set; }
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedbyUserGuid { get; set; }
        public string Type { get; set; }
        public string TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public string AffectedColumns { get; set; }
        public string PrimaryKey { get; set; }
    }
}
