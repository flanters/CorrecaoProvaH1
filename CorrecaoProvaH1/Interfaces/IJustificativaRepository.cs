using CorrecaoProvaH1.Models;

namespace CorrecaoProvaH1.Interfaces
{
    public interface IJustificativaRepository
    {
        void Adicionar(Justificativa justificativa);
        IEnumerable<Justificativa> ListarTodas();
        bool Existe(string cpf, int turno);
    }


}
