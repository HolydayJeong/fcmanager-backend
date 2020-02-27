using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fc_manager_backend_da.Models
{
    public class Code : BaseEntity
    {
        [ForeignKey("Code")]
        public int? ParentCodeId {get;set;}
        public virtual Code ParentCode {get;set;}
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
