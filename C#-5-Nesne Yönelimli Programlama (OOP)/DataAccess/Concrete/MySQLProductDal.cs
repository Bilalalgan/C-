using System;
using C__1.DataAccess.Abstract;
using C__1.Entity;

namespace C__1.DataAccess.Concrete
{
    public class MySQLProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            Console.WriteLine("MySQLProduct - Create");

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
}