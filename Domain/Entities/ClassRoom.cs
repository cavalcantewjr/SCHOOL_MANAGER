using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class ClassRoom
    {
        [Key]
        public int Id_ClassRoom { get; set; }
        [Required(ErrorMessage = "Nome da turma deve ser informado.")]
        public string ClassName { get; set; }
        [Required(ErrorMessage = "Nome da escola deve ser informado.")]
        public School School { get; set; }
    }
}
