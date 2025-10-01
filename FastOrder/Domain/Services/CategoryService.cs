using FastOrder.Domain.Data;
using FastOrder.Domain.Data.Repositories;
using FastOrder.Domain.Data.Repositories.Abstractions;
using FastOrder.Domain.Models;

namespace FastOrder.Domain.Services
{
    public class CategoryService
    {
        //exemplo sem criar o repositorio especifico
        private readonly IGenericRepository<Category, Guid> _repository;

        public CategoryService(AppDbContext context)
        {
            // Repositório para Category (Entidade) com Chave Primária Guid (TKey)
            _repository = new GenericRepository<Category, Guid>(context);
        }
    }
}
