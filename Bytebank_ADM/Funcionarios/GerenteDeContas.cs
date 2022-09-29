using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutentivel, IBonificavel
    {
        public GerenteDeContas(string cpf, string nome) : base(cpf, nome, 4000)
        {
        }

        public double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentaSalario()
        {
            Salario *= 1.05;
        }

    }
}
