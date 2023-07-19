using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }

        public void CreateProduct(Product product) => Create(product);

        public IQueryable<Product> GetAllProdutcs(bool trackChanges) => FindAll(trackChanges);

        //interfaces
        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FinByCondition(p => p.Id.Equals(id),trackChanges);
        }
        

        

    }
}