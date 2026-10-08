using CorrecaoProvaH1.Interfaces;

using CorrecaoProvaH1.Models;

namespace CorrecaoProvaH1.Repositories
{


    public class JustificativaRepository : IJustificativaRepository
    {
        private readonly List<Justificativa> _justificativas = new();

        public void Adicionar(Justificativa justificativa)
        {
            if (Existe(justificativa.CPF, justificativa.Turno))
                throw new Exception("Já existe justificativa para este eleitor neste turno.");
            _justificativas.Add(justificativa);
        }

        public IEnumerable<Justificativa> ListarTodas() => _justificativas;

        public bool Existe(string cpf, int turno) =>
            _justificativas.Any(j => j.CPF == cpf && j.Turno == turno);
    }


}
