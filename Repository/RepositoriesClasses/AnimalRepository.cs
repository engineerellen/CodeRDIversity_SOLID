
using Domain;
using Microsoft.Data.SqlClient;
using Repository.Context;
using Repository.Interfaces;

namespace Repository.RepositoriesClasses
{
    public class AnimalRepository : IRepository<Animal>
    {
        AnimalContext _context;

        public AnimalRepository(AnimalContext context)
        {
            _context = context;
        }

        public void Atualizar(Animal animal)
        {
            try
            {
                _context.Update(animal);
                _context.SaveChanges();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Excluir(Animal animal)
        {
            try
            {
                _context.Remove(animal);
                _context.SaveChanges();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inserir(Animal animal)
        {
            try
            {
                _context.Add(animal);
                _context.SaveChanges();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Animal Obter(Animal animal)
        {
            try
            {
                return _context.Animais.First(a => a.ID == animal.ID ||
                                               a.Descricao == animal.Descricao ||
                                               a.Raça == animal.Raça);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Animal> ObterTodos()
        {
            try
            {
                return _context.Animais.ToList();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
