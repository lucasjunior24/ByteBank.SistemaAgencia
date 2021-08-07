using ByteBank.Models;

namespace Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticado : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticado(double salario, string cpf) : base(salario, cpf)
        {
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
