using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="nome"></param>
        public Funcionario(string cpf, string nome, double salario)
        {
            Cpf = cpf;
            Nome = nome;
            Salario = salario;
            TotalFuncionarios++;
        }

        public static int TotalFuncionarios { get; private set; }

        public string Nome { get;private set; }

        public string Cpf { get; private set; }

        public double Salario { get;protected set; }

        /// <summary>
        /// Método para aumentar sálario de funcionario s
        /// </summary>
        public abstract void AumentaSalario();


    }
}
