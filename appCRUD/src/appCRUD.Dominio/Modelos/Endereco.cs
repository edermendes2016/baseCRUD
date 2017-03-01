using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCRUD.Dominio.Modelos
{
    public class Endereco : Entidade
    {
        public Endereco()
        {
           
        }

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
