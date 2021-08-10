using ByteBank.Modelos;

namespace Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticado : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticado(double salario, string cpf) : base(salario, cpf)
        {
        }
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
