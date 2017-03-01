using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCRUD.Dominio.Modelos
{
    public class Usuario : Entidade
    {
        public Usuario()
        {
           Enderecos = new List<Endereco>();
        }

        
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
