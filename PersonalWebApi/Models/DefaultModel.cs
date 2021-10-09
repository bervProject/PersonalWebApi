using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebApi.Models
{
    public abstract class DefaultModel : IAuditable, IDraftable
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(216)]
        /**
        * Created By to persist username of creator
        */
        public string CreateBy { get; set; }
        [Required]
        public DateTimeOffset CreatedDate { get; set; }
        [MaxLength(216)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        [MaxLength(512)]
        public string DeletedBy { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public bool IsDraft { get; set; }
    }
}
