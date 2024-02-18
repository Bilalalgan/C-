using C__1.Entity;

namespace C__1.DataAccess.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        Product[] GetProductsByCategory(int id);
        Product[] GetPopularProduct();
    }
}

