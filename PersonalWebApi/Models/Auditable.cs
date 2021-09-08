using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebApi.Models
{

    /**
    * Abstract class to define about audit columns
    */
    public abstract class Auditable
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(216)]
        /**
        * Created By to persist username of creator
        */
        public string CreateBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [MaxLength(216)]
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        [MaxLength(512)]
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }

}