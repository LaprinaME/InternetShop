using System.ComponentModel.DataAnnotations;

namespace InternetShop.Models
{
    public class Роль
    {
        [Key]
        public int Код_Роли { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование_роли { get; set; }
    }
}

