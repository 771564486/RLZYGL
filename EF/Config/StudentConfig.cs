using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EF.Config
{
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
       public StudentConfig()
       {
           this.ToTable("Student");
           this.HasKey(e=>e.StuId);
           this.Property(e => e.StuName).HasMaxLength(20);
       }

    }
}
