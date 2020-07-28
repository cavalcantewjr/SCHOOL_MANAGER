using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class School
    {
        [Key]
        public int IdEscola { get; set; }

        [Required(ErrorMessage = "Nome da escola deve ser informado.")]
        public string nomeEscola { get; set; }
        [Required(ErrorMessage = "Endereço deve ser informado.")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Bairro deve ser informado.")]
        public string Bairro { get; set; }
        public List<ClassRoom> Turma { get; set; }

    }
}
