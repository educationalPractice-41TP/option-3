// Models/Book.cs
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        [Display(Name = "Название")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Автор обязателен")]
        [Display(Name = "Автор")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "ISBN обязателен")]
        [Display(Name = "ISBN")]
        [RegularExpression(@"^\d{3}-\d{10}$", ErrorMessage = "Формат: 000-0000000000")]
        public string ISBN { get; set; } = string.Empty;

        [Required(ErrorMessage = "Жанр обязателен")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Год обязателен")]
        [Display(Name = "Год издания")]
        [Range(1000, 2025, ErrorMessage = "Год должен быть между 1000 и 2025")]
        public int Year { get; set; }
    }
}