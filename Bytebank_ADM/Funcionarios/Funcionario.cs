using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Funcionario
    {

        //public Funcionario(int tipo)
        //{
        //    Tipo = tipo;
        //}

        // 0 - funcionario
        // 1 - diretor
        // 2 - designer
        //public int Tipo { get; private set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }

        /// <summary>
        /// Método para obter a Bonificação do Funcionario
        /// </summary>
        /// <returns></returns>
        public double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
