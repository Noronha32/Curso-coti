using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01.Entities
{
    public class Funcionarios
    {
        private Guid _idfuncionario;
        private string _nome;
        private string _cpf;
        private string _matricula;
        private DateTime _dtadmissao;
        private string _cargo;
        private float _salario;

        public Guid IdFuncionario 
        { 
           set { _idfuncionario = value; }
           get { return _idfuncionario; }
        }

        public string Nome
        {
            set {_nome = value; }
            get {return _nome; }
        }

        public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }

        public string Matricula
        {
            set { _matricula = value; }
            get { return _matricula; }
        }
        
        public DateTime DtAdmissao
        {
            set { _dtadmissao = value; }
            get { return _dtadmissao; }
        }

        public string Cargo
        {
            set { _cargo = value; }
            get { return _cargo; }
        }

        public float Salario
        {
            set { _salario = value; }
            get { return _salario; }
        }
    }
}
