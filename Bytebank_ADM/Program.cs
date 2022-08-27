using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilitarios;
using System.Security.Cryptography;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

Util.PularLinhas();

Designer designer = new(nome: "Antonio Vinicius", cpf: "111.111.111-11");

Diretor diretor = new(nome: "Bill Gates", cpf: "155.141.178-81");

Auxiliar auxiliar = new(nome: "Carlos Neves", cpf: "475.176.171-99");

GerenteDeContas gerente = new(nome: "Carla Nunes", cpf: "143.222.777-33");

diretor.AumentaSalario();

auxiliar.AumentaSalario();

designer.AumentaSalario();

gerente.AumentaSalario();

Console.WriteLine($"Designer - Bonificação: {designer.GetBonificacao():c}");
Console.WriteLine($"Nome: {designer.Nome}" + Environment.NewLine +
                  $"Cpf: {designer.Cpf}" + Environment.NewLine +
                  $"Salario: {designer.Salario:c}");

Util.PularLinhas(2);

Console.WriteLine($"Diretor - Bonificação: {diretor.GetBonificacao():c}");
Console.WriteLine($"Nome: {diretor.Nome}" + Environment.NewLine +
                  $"Cpf: {diretor.Cpf}" + Environment.NewLine +
                  $"Salario: {diretor.Salario:c}");

Util.PularLinhas(2);

Console.WriteLine($"Auxiliar - Bonificação: {auxiliar.GetBonificacao():c}");
Console.WriteLine($"Nome: {auxiliar.Nome}" + Environment.NewLine +
                  $"Cpf: {auxiliar.Cpf}" + Environment.NewLine +
                  $"Salario: {auxiliar.Salario:c}");


Util.PularLinhas(2);

Console.WriteLine($"Gerente - Bonificação: {gerente.GetBonificacao():c}");
Console.WriteLine($"Nome: {gerente.Nome}" + Environment.NewLine +
                  $"Cpf: {gerente.Cpf}" + Environment.NewLine +
                  $"Salario: {gerente.Salario:c}");



GerenciadorDeBonificacao registrador = new();

registrador.Registrar(designer);

registrador.Registrar(diretor);

Util.PularLinhas(2);

Console.WriteLine($"Total de Bonificações: {registrador.GetBonificacao():c}");

Console.WriteLine(Funcionario.TotalFuncionarios);


Console.ReadKey();