using System.ComponentModel.DataAnnotations;

namespace TrialTaskManagerPassword.Models
{
    public class Record
    {
        public int Id { get; set; }

        /// <summary>
        /// Ресурс (Сайт или email)
        /// </summary>

        public string? Source {  get; set; }

        /// <summary>
        /// Полный адресс Email или сайт
        /// </summary>
       [Required(ErrorMessage = "Строка AddressSource(наименования)  не может быть пуста")]
        public string? AddressSource {  get; set; }
        
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
