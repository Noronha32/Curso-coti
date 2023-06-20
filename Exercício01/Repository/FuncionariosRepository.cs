using Exercício01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01.Repository
{
    public class FuncionariosRepository
    {
        public void ExportarDados(Funcionarios funcionarios)
        {
            var streamWrite = new StreamWriter("c:\\temp\\dados.json", true);

            streamWrite.WriteLine("ID do Funcionário.............: " + funcionarios.IdFuncionario);
            streamWrite.WriteLine("Nome..........................: " + funcionarios.Nome);
            streamWrite.WriteLine("CPF...........................: " + funcionarios.Cpf);
            streamWrite.WriteLine("Matrícula.....................: " + funcionarios.Matricula);
            streamWrite.WriteLine("Data de Admissão..............: " + funcionarios.DtAdmissao);
            streamWrite.WriteLine("Cargo.........................: " + funcionarios.Cargo);
            streamWrite.WriteLine("Salário.......................: " + funcionarios.Salario);
            streamWrite.WriteLine("...............................\n");

            streamWrite.Close();


        }
    }
}
