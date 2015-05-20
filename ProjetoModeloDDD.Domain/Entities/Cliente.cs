using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            this.Produtos = new List<Produto>();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
