﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Arquiteto : PrestadorDeServicos, IAutenticavel, IBonificavel
    {
        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return Login == login && Senha == senha;
        }

        public double GetBonificacao()
        {
            return 1000;
        }
    }
}
