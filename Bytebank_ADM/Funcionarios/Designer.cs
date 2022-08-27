﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf, string nome, double salario) : base(cpf, nome, 3000)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 1.17;
        }

        public override void AumentaSalario()
        {
            Salario *= 1.11;
        }
    }
}
