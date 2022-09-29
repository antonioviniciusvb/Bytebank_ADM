using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Desenvolvedor:Funcionario, IBonificavel
    {

        public Desenvolvedor(string cpf, string nome):base(cpf,nome, 3000)
        {

        }

        public override void AumentaSalario()
        {
            Salario *= 0.15;
        }

        public double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
