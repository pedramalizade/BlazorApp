using MyBlazor.Libraries.ShoppingCart.Models;

namespace MyBlazor.Libraries.Storage
{
    public interface IStorageService
    {
        IList<ProductModel> products { get; }

        ShoppingCartModel ShoppingCart { get; }
    }
}
