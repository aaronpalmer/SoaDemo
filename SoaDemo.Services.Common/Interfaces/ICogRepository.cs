using SoaDemo.Services.Common.DataContracts;

namespace SoaDemo.Services.Common.Interfaces
{
    public interface ICogRepository
    {
        Product GetCog(int id);

        Product SaveCog(Product product);

        bool DeleteCog(int id);
    }
}
