using Domain;
using Repository.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class AnimalServices : IService<Animal>
    {
        IRepository<Animal> _repository;
        public AnimalServices(IRepository<Animal> repository) =>
            _repository = repository;

        public Animal Obter(Animal animal) =>
            _repository.Obter(animal);


        public List<Animal> ObterTodos() =>
            _repository.ObterTodos();


        public void Inserir(Animal animal) =>
            _repository.Inserir(animal);


        public void Atualizar(Animal animal) =>
            _repository.Atualizar(animal);

        public void Remover(Animal animal) =>
            _repository.Excluir(animal);
    }
}