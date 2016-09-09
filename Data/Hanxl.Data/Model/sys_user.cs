namespace Hanxl.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("code_repository.sys_user")]
    public partial class sys_user
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        public int? DeptId { get; set; }

        public int? RoleId { get; set; }

        [StringLength(255)]
        public string UserRemark { get; set; }

        public DateTime? AddTime { get; set; }

        public int? AddUserId { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int? UpdateUserId { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsDeleted { get; set; }
    }
}
