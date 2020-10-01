    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace agendaMVC.Models
{
    public class Agenda
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public String Nome { get; set; }

        [Display(Name = "CPF (sem pontuação)")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        [RegularExpression(@"^.{11,}$", ErrorMessage = "Digite um CPF válido")]
        public long CPF { get; set; }

        
        [Required(ErrorMessage = "O campo de endereço é obrigatório")]
        public String Endereco { get; set; }

        [Required(ErrorMessage = "O campo de cidade é obrigatório")]
        public String Cidade { get; set; }

        [Required(ErrorMessage = "O campo do UF é obrigatório")]
        [MaxLength(2, ErrorMessage = "Digite um UF válido")]
        public String UF { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "O campo de Data de nascimento é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime? Aniversario { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um email válido")]
        [Required(ErrorMessage = "O Email é obrigatório!")]
        [Remote("EmailUnic","home",ErrorMessage ="Este E-mail já está cadastrado")]
        public String Email { get; set; }

        [Display(Name = "Celular (Com DDD)")]
        [Required(ErrorMessage = "O número de celular é obrigatório")]
        [RegularExpression(@"^.{11,}$", ErrorMessage = "Minímo de 11 número")]
        public long Celular { get; set; }
    }
}