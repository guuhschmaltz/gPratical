using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gPratical.Classes
{
    public abstract class Usuario
    {
        public class Unit
        {
            [Required(ErrorMessage = "Nome do Cliente é obrigatório")]
            [StringLength(100, ErrorMessage = "Nome do Cliente deve ter no máximo 100 caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Data de nascimento é obrigatório, use o formato de datas no padrão dia/mês/ano")]
            [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
            public DateTime DataDeNascimento { get; set; }

            [Required(ErrorMessage = "Numero de Telefone é obrigatorio")]
            [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Insira um numero de telefone válido, favor inserir apenas a numeração")]
            public string Telefone { get; set; }

            [Required(ErrorMessage = "Cargo é obrigatório")]
            [StringLength(50, ErrorMessage = "Cargo deve ter no máximo 50 caracteres")]
            public string Cargo { get; set; }

            [StringLength(20, MinimumLength = 2, ErrorMessage = "Setor não foi inserido.")]
            [Required(ErrorMessage = "Setor é obrigatório")]
            public string Setor { get; set; }

            [Required(ErrorMessage = "Endereco é obrigatório")]
            [StringLength(100, ErrorMessage = "Endereco deve ter no máximo 100 caracteres")]
            public string Endereco { get; set; }

            [Required(ErrorMessage = "Estado é obrigatório")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "Cidade deve deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Genero é obrigatório")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Genero deve ter no mínimo 3 digitos")]
            public string Genero { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }
        }
        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
    }
}
