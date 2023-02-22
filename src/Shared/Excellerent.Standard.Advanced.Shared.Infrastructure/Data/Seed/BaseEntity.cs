using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Data.Seed
{
    public abstract class BaseEntity<T> where T : BaseAuditModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Guid { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedbyUserGuid { get; set; }
        public abstract T MapToModel(T t);
        public abstract T MapToEntity();

        public bool IsTransient()
        {
            return Guid == default;
        }
    }
}

