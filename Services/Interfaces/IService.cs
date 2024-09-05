namespace Services.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Obter(TEntity entity);
        List<TEntity> ObterTodos();

        void Inserir(TEntity entity);

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);
    }
}
