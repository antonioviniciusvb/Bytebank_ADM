﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public new double GetBonificacao()
        {
            return Salario;
        }
    }
}