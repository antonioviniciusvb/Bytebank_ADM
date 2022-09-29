using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario, IBonificavel
    {
        public Auxiliar(string cpf, string nome) : base(cpf, nome, 2000)
        {
        }

        public double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public override void AumentaSalario()
        {
            Salario *= 1.1;
        }
    }
}
