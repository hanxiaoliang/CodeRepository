namespace Hanxl.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<sys_dept> sys_dept { get; set; }
        public virtual DbSet<sys_role> sys_role { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sys_dept>()
                .Property(e => e.DeptName)
                .IsUnicode(false);

            modelBuilder.Entity<sys_dept>()
                .Property(e => e.DeptRemark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.RoleRemark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.UserRemark)
                .IsUnicode(false);
        }
    }
}
