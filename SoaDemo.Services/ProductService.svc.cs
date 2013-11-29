using System;
using System.Transactions;
using Microsoft.Practices.Unity;
using SoaDemo.Services.Common.DataContracts;
using SoaDemo.Services.Common.Interfaces;

namespace SoaDemo.Services
{
    public class ProductService : IProductService
    {
        [Dependency]
        public ICogRepository CogRepository { get; set; }

        public Product GetCog(int id)
        {
            Product results;
            using (var tran = new TransactionScope())
            {
                results = CogRepository.GetCog(id);
                tran.Complete();
            }

            return results;
        }

        public Product SaveCog(Product product)
        {
            Product results;
            using (var tran = new TransactionScope())
            {
                results = CogRepository.SaveCog(product);
                tran.Complete();
            }

            return results;

        }

        public bool DeleteCog(int id)
        {
            bool results;
            using (var tran = new TransactionScope())
            {
                results = CogRepository.DeleteCog(id);
                tran.Complete();
            }

            return results;
        }

        public Product GetSprocket(int value)
        {
            throw new NotImplementedException();
        }

        public Product SaveSprocket(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSprocket(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetWidget(int value)
        {
            throw new NotImplementedException();
        }

        public Product SaveWidget(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWidget(int id)
        {
            throw new NotImplementedException();
        }
    }
}
