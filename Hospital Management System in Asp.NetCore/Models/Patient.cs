using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management_System_in_Asp.NetCore.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
       [Column("PName",TypeName ="varchar(100)") ]
        public string Name { get; set; }
        public int Age { get; set; }
        [Column("PGender", TypeName = "varchar(50)")]
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}
