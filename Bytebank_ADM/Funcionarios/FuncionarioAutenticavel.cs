using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutentivel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutentivel(string cpf, string nome, int salario) : base(cpf, nome, salario)
        {

        }

        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return Login == login && Senha == senha;
        }
    }
}
