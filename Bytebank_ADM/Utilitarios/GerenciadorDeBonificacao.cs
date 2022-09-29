using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(IBonificavel funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
