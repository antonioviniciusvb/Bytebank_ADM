using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutentivel, IBonificavel
    {
        public Diretor(string cpf, string nome):base(cpf, nome, 5000)
        {

        }

        public double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }

    }
}
