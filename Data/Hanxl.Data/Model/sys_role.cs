namespace Hanxl.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("code_repository.sys_role")]
    public partial class sys_role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Required]
        [StringLength(100)]
        public string RoleName { get; set; }

        [StringLength(255)]
        public string RoleRemark { get; set; }

        public DateTime? AddTime { get; set; }

        public int? AddUserId { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int? UpdateUserId { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsDeleted { get; set; }
    }
}
