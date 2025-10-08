using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.Storage
{
    public class StorageService : IStorageService
    {
        public IList<ProductModel> products { get; private set; }

        public StorageService()
        {
            products = new List<ProductModel>();

            AddProduct(new ProductModel("sasa", "sasas", 21, "ewew", "dsdsd"));
            AddProduct(new ProductModel("sasa", "sasas", 21, "ewew", "dsdsd"));
            AddProduct(new ProductModel("sasa", "sasas", 21, "ewew", "dsdsd"));
            AddProduct(new ProductModel("sasa", "sasas", 21, "ewew", "dsdsd"));
        }

        private void AddProduct(ProductModel product) 
        {
            if (!products.Any(p => p.Sku == product.Sku)) 
            {
                products.Add(product);
            }
        }
    }
}
