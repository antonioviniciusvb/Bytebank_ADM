using Bytebank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

Funcionario funcionario = new(tipo: 2)
{
    Nome = "Vinicius",
    Cpf = "111.111.111-11",
    Salario = 6000
};

Console.WriteLine($"Bonificação: {funcionario.GetBonificacao():c}");
Console.ReadKey();