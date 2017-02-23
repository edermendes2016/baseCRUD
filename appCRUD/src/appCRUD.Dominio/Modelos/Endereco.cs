using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCRUD.Dominio.Modelos
{
    class Endereco
    {
        public Endereco()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
    }
}
