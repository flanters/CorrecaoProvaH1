namespace CorrecaoProvaH1.Interfaces
{
    public interface IEleitorRepository
    {

        void Adicionar(Eleitor eleitor);
        Eleitor ObterPorCPF(string cpf);
        IEnumerable<Eleitor> ListarTodos();
    }
}
