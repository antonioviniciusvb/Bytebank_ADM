using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario, IBonificavel
    {
        public Designer(string cpf, string nome) : base(cpf, nome, 3000)
        {
        }

        public double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentaSalario()
        {
            Salario *= 1.11;
        }
    }
}
