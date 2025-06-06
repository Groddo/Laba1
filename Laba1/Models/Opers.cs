using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Laba1.Models
{
    public class Opers
    {
        [Required(ErrorMessage = "Впишите первый операнд")]
        public int? Oper1 { get; set; }

        [Required(ErrorMessage = "Впишите второй операнд")]
        public int? Oper2 { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите операцию")]
        public string? Operation {  get; set; }

        [Display(Name = "Результат вычислений")]        
        public float? Result { get; set; }
        

    }
}
