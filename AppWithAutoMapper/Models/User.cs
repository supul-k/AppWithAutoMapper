using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWithAutoMapper.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", TypeName = "nvarchar(100)")]
        public int Id { get; set; }

        [Column("FirstName", TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Required]
        [Column("Email", TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column("Password", TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
