using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Автор")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string Author { get; set; } = string.Empty;

        [Display(Name = "Год издания")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Range(1000, 2024, ErrorMessage = "Год должен быть между 1000 и 2024")]
        public int Year { get; set; }
    }
}