using bytebank;
using Bytebank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

Funcionario funcionario = new()
{
    Nome = "Vinicius",
    Cpf = "111.111.111-11",
    Salario = 6000
};

Diretor diretor = new()
{
    Nome = "Bill Gates",
    Cpf = "155.141.178-81",
    Salario = 500000
};

Console.WriteLine($"Funcionário - Bonificação: {funcionario.GetBonificacao():c}");

Util.PularLinhas(2);

Console.WriteLine($"Diretor - Bonificação: {diretor.GetBonificacao():c}");

Console.ReadKey();