using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Api.Models
{
    public class Usuario
    {
        public Usuario(string login, string senha)
        {
            Id = Guid.NewGuid();
            Login = login;
            Senha = senha;
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Documento { get; set; }
        public string Sexo { get; set; }
        public bool? IsPessoaFisica => Documento?.Length == 11;
    }
}
