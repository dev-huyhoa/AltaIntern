using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manager.Models
{
    [Table("ScoreType")]

    public class ScoreTypeModel
    {
        [Key]
        public int ScoreTypeId { get; set; }

        [Display(Name = "Tên Loại Điểm"), StringLength(20)]
        public string ScoreTypeName { get; set; }

        [Display(Name = "Hệ Số")]
        public int ScoreTypeCoefficient { get; set; }
    }
}
