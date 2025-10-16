namespace MyBlazor.Libraries.ShoppingCart
{
    public interface IShoppingCartService
    {
        ShoppingCartModel Get();
        void AddProduct(ProductModel product, int quantity);
        void DeleteProduct(ShoppingCartItemModel item);
        int Count();
        bool HasProduct(string sku);
    }
}
