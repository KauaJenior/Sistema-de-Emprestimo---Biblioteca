using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class Associados
    {
        private string _cpf;
        private string _nome;
        private string _sexo;
        private string _logradouro;
        private string _estado;
        private string _pais;
        private double _multa;

        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }

        public string Logradouro { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }
        public double Multa { get; set; }

    }
}
