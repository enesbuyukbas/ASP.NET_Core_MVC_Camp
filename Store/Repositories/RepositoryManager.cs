using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context)
        {
            _productRepository = productRepository;
            _context = context;
        }

        public IProductRepository Product => throw new NotImplementedException();

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}