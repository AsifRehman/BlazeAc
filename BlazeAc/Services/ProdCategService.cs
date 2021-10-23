using BlazeAc.Data;
using System.Collections.Generic;
using System.Linq;

namespace BlazeAc.Services
{
    public class ProductCategService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductCategService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<ProductCateg> Get()
        {
            return _dbContext.ProductCategs.ToList();
        }

        public void Delete(short id)
        {
            var ProductCateg = _dbContext.ProductCategs.FirstOrDefault(x => x.ProdCategId == id);
            if (ProductCateg != null)
            {
                _dbContext.ProductCategs.Remove(ProductCateg);
                _dbContext.SaveChanges();
            }
        }

        public ProductCateg GetById(short id)
        {
            var ProductCateg = _dbContext.ProductCategs.SingleOrDefault(x => x.ProdCategId == id);
            return ProductCateg;
        }

        public List<ProductCateg> GetProductCategs()
        {
            return _dbContext.ProductCategs.ToList();
        }

        public void Save(ProductCateg productCateg)
        {
            if (_dbContext.ProductCategs.FirstOrDefault(c => c.ProdCategId == productCateg.ProdCategId) != null)
            {
                _dbContext.ProductCategs.Update(productCateg);
                _dbContext.SaveChanges();

            }
            else
            {
                _dbContext.ProductCategs.Add(productCateg);
                _dbContext.SaveChanges();
            }
        }

    }
}