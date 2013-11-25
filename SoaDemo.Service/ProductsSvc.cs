using System.Transactions;
using SoaDemo.Business.Repositories;
using SoaDemo.Service.Common.DataContracts;

namespace SoaDemo.Service
{
    public class ProductsSvc : IProductsSvc
    {
        public Product GetCog(int id)
        {
            Product product;
            using (var tran = new TransactionScope())
            {
                var repository = new CogRepository();
                product = repository.GetCog(id);
                tran.Complete();
            }
            return product;
        }

        public Product SaveCog(Product product)
        {
            using (var tran = new TransactionScope())
            {
                var repository = new CogRepository();
                product = repository.SaveCog(product);
                tran.Complete();
            }
            return product;
        }

        public bool DeleteCog(int id)
        {
            bool results;
            using (var tran = new TransactionScope())
            {
                var repository = new CogRepository();
                results = repository.DeleteCog(id);
                tran.Complete();
            }
            return results;
        }


        public Product GetSprocket(int value)
        {
            throw new System.NotImplementedException();
        }

        public Product SaveSprocket(Product product)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteSprocket(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetWidget(int value)
        {
            throw new System.NotImplementedException();
        }

        public Product SaveWidget(Product product)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteWidget(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
