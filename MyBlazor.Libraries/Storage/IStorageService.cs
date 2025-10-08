using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.Storage
{
    public interface IStorageService
    {
        IList<ProductModel> products { get; }
    }
}
