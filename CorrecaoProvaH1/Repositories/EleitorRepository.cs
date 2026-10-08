using CorrecaoProvaH1.Interfaces;

namespace CorrecaoProvaH1.Repositories
{

    public class EleitorRepository : IEleitorRepository
    {
        private readonly List<Eleitor> _eleitores = new();

        public void Adicionar(Eleitor eleitor)
        {
            if (_eleitores.Any(e => e.CPF == eleitor.CPF))
                throw new Exception("Já existe eleitor com este CPF.");
            _eleitores.Add(eleitor);
        }

        public Eleitor ObterPorCPF(string cpf) => _eleitores.FirstOrDefault(e => e.CPF == cpf);

        public IEnumerable<Eleitor> ListarTodos() => _eleitores;
    }


}
