namespace DIO.Series_Filmes.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId (int id);
         void Insere(T entidade);
         void Atualiza(int id, T entidade);
         void Exclui(int id);
         int ProximoId();
    }
}