using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Laba1.Models
{
    public class Opers
    {
        [Required(ErrorMessage = "Впишите первый операнд")]
        public int? Oper1 { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "Принимаются только целые числа")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Введите число в диапазоне от 0 до 9999")]
        [Required(ErrorMessage = "Впишите второй операнд")]
        public string? Oper2 { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите операцию")]
        public string? Operation {  get; set; }

        [Display(Name = "Результат вычислений")]        
        public float? Result { get; set; }
        

    }
}
