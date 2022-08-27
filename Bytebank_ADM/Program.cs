using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilitarios;
using System.Security.Cryptography;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

Util.PularLinhas();

Funcionario funcionario = new(nome: "Antonio Vinicius", cpf: "111.111.111-11", salario: 11000);

Diretor diretor = new(nome: "Bill Gates", cpf: "155.141.178-81", salario: 45236);

diretor.AumentaSalario();


Console.WriteLine($"Funcionário - Bonificação: {funcionario.GetBonificacao():c}");
Console.WriteLine($"Nome: {funcionario.Nome}" + Environment.NewLine +
                  $"Cpf: {funcionario.Cpf}" + Environment.NewLine +
                  $"Salario: {funcionario.Salario:c}");

Util.PularLinhas(2);

Console.WriteLine($"Diretor - Bonificação: {diretor.GetBonificacao():c}");
Console.WriteLine($"Nome: {diretor.Nome}" + Environment.NewLine +
                  $"Cpf: {diretor.Cpf}" + Environment.NewLine +
                  $"Salario: {diretor.Salario:c}");

GerenciadorDeBonificacao registrador = new();

registrador.Registrar(funcionario);

registrador.Registrar(diretor);

Util.PularLinhas(2);

Console.WriteLine($"Total de Bonificações: {registrador.GetBonificacao():c}");

Console.WriteLine(Funcionario.TotalFuncionarios);


Console.ReadKey();