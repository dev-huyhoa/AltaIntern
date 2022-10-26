using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manager.Models
{
    [Table("Role")]

    public class RoleModel
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
