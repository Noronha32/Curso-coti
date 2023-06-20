using Exercício01.Entities;
using Exercício01.Repository;

var funcionarios = new Funcionarios();
var funcionariosrepository = new FuncionariosRepository();
funcionarios.IdFuncionario = Guid.NewGuid();

Console.Write("\t\t**************DADOS DO FUNCIONÁRIO**************\n\n");
Console.Write("Nome..............: ");
funcionarios.Nome = Console.ReadLine();
Console.Write("CPF...............: ");
funcionarios.Cpf = Console.ReadLine();
Console.Write("Matrícula.........: ");
funcionarios.Matricula = Console.ReadLine();
Console.Write("Data de Admissão..: ");
funcionarios.DtAdmissao = DateTime.Parse(Console.ReadLine());
Console.Write("Cargo.............: ");
funcionarios.Cargo = Console.ReadLine();
Console.Write("Salário em R$.....: ");
funcionarios.Salario = float.Parse(Console.ReadLine());

funcionariosrepository.ExportarDados(funcionarios);

Console.ReadKey();

