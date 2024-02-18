using System;
using C__1.DataAccess.Abstract;
using C__1.DataAccess.Concrete;
using C__1.Entity;

namespace C__1
{
    class ProductManager : IProductRepository
    {
        IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Create(Product entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetPopularProduct()
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var productDal = new EfProductDal();
            // var productDal = new MySQLProductDal();
            // productDal.Create(new Product());
            
            // var productDal = new ProductManager(new EfProductDal());
            var productDal = new ProductManager(new MySQLProductDal());
            productDal.Create(new Product());
        }
    }
}
