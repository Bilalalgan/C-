using C__1.Entity;

namespace C__1.DataAccess.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category[] GetCategories();
    }
}

