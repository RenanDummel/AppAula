using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entidade
{
    public class Usuarios
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Guid CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
