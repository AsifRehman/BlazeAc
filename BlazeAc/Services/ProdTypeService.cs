using BlazeAc.Data;
using System.Collections.Generic;
using System.Linq;

namespace BlazeAc.Services
{
    public class ProductTypeService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductTypeService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<ProductType> Get()
        {
            return _dbContext.ProductTypes.ToList();
        }

        public int GetMaxType(byte categ)
        {
            try
            {
                int maxType = _dbContext.ProductTypes.Where(p => p.ProdCategId == categ).Max(p => p.ProdTypeId);
                return maxType + 1;
            }
            catch (System.Exception)
            {
                return int.Parse(categ.ToString() + "1");
            }

        }

        public void Delete(int id)
        {
            var ProductType = _dbContext.ProductTypes.FirstOrDefault(x => x.ProdTypeId == id);
            if (ProductType != null)
            {
                _dbContext.ProductTypes.Remove(ProductType);
                _dbContext.SaveChanges();
            }
        }

        public ProductType GetById(short id)
        {
            var ProductType = _dbContext.ProductTypes.SingleOrDefault(x => x.ProdTypeId == id);
            return ProductType;
        }

        public List<ProductType> GetProductTypes()
        {
            return _dbContext.ProductTypes.ToList();
        }

        public void Save(ProductType productType)
        {
            if (_dbContext.ProductTypes.FirstOrDefault(c => c.ProdTypeId == productType.ProdTypeId) != null)
            {
                _dbContext.ProductTypes.Update(productType);
                _dbContext.SaveChanges();

            }
            else
            {
                _dbContext.ProductTypes.Add(productType);
                _dbContext.SaveChanges();
            }
        }

    }
}