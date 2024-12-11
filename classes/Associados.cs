using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class Associados
    {   
        //Atributos
        private string _cpf;
        private string _nome;
        private string _sexo;
        private string _logradouro;
        private string _estado;
        private string _cidade;
        private string _pais;
        private double _multa;

        //Propriedades
        public string CPF { 
            get { return _cpf; } 
            set { _cpf = value; } }
        public string Nome { 
            get { return _nome; } 
            set { _nome = value; }
        }
        public string Sexo { 
            get { return _sexo; } 
            set { _sexo = value; }
        }

        public string Logradouro { 
            get { return _logradouro; } 
            set { _logradouro = value; }
        }

        public string Estado { 
            get { return _estado; } 
            set { _estado = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string Pais { 
            get{ return _pais; } 
            set { _pais = value; }
        }
        public double Multa {
            get { return _multa; }
            set { _multa = value; }
        }

        //Construtor
        public Associados(string nome, string cpf, string sexo, string logradouro, string cidade, string estado, string pais)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Sexo = sexo;
            this.Logradouro = logradouro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;

        }

        //Metodos

        public bool IncluirMultas(double valor)
        {
            Multa = valor;
            return true;
        }

        public bool QuitarMultas(double valor)
        {   
            return true;
        }
    }
}
