namespace Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> ObterTodos();

        TEntity Obter(TEntity entity);

        void Inserir(TEntity entity);

        void Atualizar(TEntity entity);

        void Excluir(TEntity entity);
    }
}
