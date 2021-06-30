using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro.entities
{
    class Pessoa
    {
        public Pessoa(string nome, string dataNascimento, string estadoCivil, string telefone, bool casaPropia, bool veiculo, char sexo)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            EstadoCivil = estadoCivil;
            Telefone = telefone;
            CasaPropia = casaPropia;
            Veiculo = veiculo;
            Sexo = sexo;
        }

        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropia { get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { get; set; }
    }
}
