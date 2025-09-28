using FastOrder.Domain.Data.Repositories.Abstractions;
using FastOrder.Domain.Models;

namespace FastOrder.Domain.Data.Repositories
{
    //usando o generctRepository como composição e escolhendo o que vai ser implementado
    //desta forma limita quais metodos podem ser usados para essa classe
    public class UserRepository : IUserRepository
    {
        private readonly IGenericRepository<User> _genericRepository;

        public UserRepository(IGenericRepository<User> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return _genericRepository.GetAllAsync();
        }
    }
}
