// ViewModels/BookViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Автор")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Author { get; set; } = string.Empty;

        [Display(Name = "ISBN")]
        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression(@"^\d{3}-\d{10}$", ErrorMessage = "Формат: 000-0000000000")]
        public string ISBN { get; set; } = string.Empty;

        [Display(Name = "Жанр")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Год издания")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Range(1000, 2025, ErrorMessage = "Год должен быть между 1000 и 2025")]
        public int Year { get; set; } 
    }
}