using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Data.Seed
{
    public abstract class BaseEntity<T> where T : BaseAuditModel
    {
        [Key]
        public virtual Guid Guid { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedbyUserGuid { get; set; }
        public abstract T MapToModel();
        public abstract T MapToModel(T t);
        public BaseEntity()
        {

        }
        public BaseEntity(T auditModel)
        {
            Guid = auditModel.Guid;
            IsActive = auditModel.IsActive;
            CreatedbyUserGuid = auditModel.CreatedbyUserGuid;
            CreatedDate = auditModel.CreatedDate;
        }
    }
}
