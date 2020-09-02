namespace Libraries.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public int Age { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public int Gid { get; set; }

        public virtual grades grades { get; set; }
    }
}
