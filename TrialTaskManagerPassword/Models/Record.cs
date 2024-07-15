using System.ComponentModel.DataAnnotations;

namespace TrialTaskManagerPassword.Models
{
    public class Record
    {
        public int Id { get; set; }

        /// <summary>
        /// Сайт или email
        /// </summary>

        public bool IsEmail {  get; set; }

        /// <summary>
        /// Ресурс Email адрес или сайт
        /// </summary>
       [Required(ErrorMessage = "Строка Source(наименования)  не может быть пуста")]
        public string? Source {  get; set; }
        
        /// <summary>
        /// Пароль
        /// </summary>
        [Required(ErrorMessage = "Строка Password(Пароль) не может быть пустым")]
        [StringLength(20, MinimumLength = 8)]
        public string? Password { get; set; }

        /// <summary>
        /// Дата последнего входа
        /// </summary>
        public DateTime? RecordingDate { get; set; }

    }
}
