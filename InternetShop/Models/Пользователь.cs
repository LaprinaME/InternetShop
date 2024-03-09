using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Models
{
    [Table("Пользователи")]
    public class Пользователь
    {
        [Column("Код_Пользователя")]
        public int Код_Пользователя { get; set; }

        [Column("Логин")]
        public string Логин { get; set; }

        [Column("Пароль")]
        public string Пароль { get; set; }

        [Column("Код_Роли")]
        public int Код_Роли { get; set; }

        [ForeignKey("Код_Роли")]
        public Роль Роль { get; set; }
    }
}
