using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilitarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

Util.PularLinhas();

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

Console.WriteLine($"Diretor - Bonificação: {diretor.GetBonificacao():c}");

GerenciadorDeBonificacao registrador = new();

registrador.Registrar(funcionario);

registrador.Registrar(diretor);

Util.PularLinhas(2);

Console.WriteLine($"Total de Bonificações: {registrador.GetBonificacao():c}");


Console.ReadKey();