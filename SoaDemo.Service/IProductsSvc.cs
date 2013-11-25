﻿using System.ServiceModel;
using SoaDemo.Service.Common.DataContracts;

namespace SoaDemo.Service
{
    [ServiceContract]
    public interface IProductsSvc
    {
        [OperationContract]
        Product GetCog(int id);
        [OperationContract]
        Product SaveCog(Product product);
        [OperationContract]
        bool DeleteCog(int id);

        [OperationContract]
        Product GetSprocket(int value);
        [OperationContract]
        Product SaveSprocket(Product product);
        [OperationContract]
        bool DeleteSprocket(int id);

        [OperationContract]
        Product GetWidget(int value);
        [OperationContract]
        Product SaveWidget(Product product);
        [OperationContract]
        bool DeleteWidget(int id);

    }
}
