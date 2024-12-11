using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class Emprestimo
    {
        private int _id;
        private DateTime _dataEmprestimo;
        private DateTime _dataDevolucao;
        private string _status;

        public int Id { get { return _id; } set { _id = value; } }

        public DateTime DateDevolucao { get { return _dataDevolucao; } set { } }

        public DateTime DataEmprestimo { get { return _dataEmprestimo; } set { } }

        public string Status { get { return _status; } set { _status = value; } }

        //Metodos

        public bool EfetivarEmprestimo()
        {
            return true;
        }

        public bool EfetivarDevolucao()
        {
            return true;
        }

        public string ImprimirReserva()
        {
            return "livro";
        }
    }
}
