using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Anthill.Infastructure.Entities
{
    public class UserQuestion
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указано вопрос")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Недопустимая длина вопроса")]
        public string Question { get; set; }
    }
}
