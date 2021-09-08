
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebApi.Models
{
    public class Blog : Auditable
    {
        [Required]
        [MaxLength(1024)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [MaxLength(128)]
        [Required]
        public string Icon { get; set; }
        [MaxLength(1024)]
        [Required]
        public string Link { get; set; }
    }
}