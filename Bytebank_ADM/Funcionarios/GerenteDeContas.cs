using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf, string nome) : base(cpf, nome, 4000)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentaSalario()
        {
            Salario *= 1.05;
        }
    }
}
