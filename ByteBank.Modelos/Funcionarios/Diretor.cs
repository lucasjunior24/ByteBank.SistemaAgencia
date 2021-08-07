namespace Modelos.Funcionarios
{
    public class Diretor : FuncionarioAutenticado
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
