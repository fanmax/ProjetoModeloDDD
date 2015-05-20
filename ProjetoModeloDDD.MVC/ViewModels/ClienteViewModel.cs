using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha este campo")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres excedido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha este campo")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres excedido")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha este campo")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres excedido")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}