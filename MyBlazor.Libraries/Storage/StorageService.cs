using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.Storage
{
    public class StorageService : IStorageService
    {
        public IList<ProductModel> products { get; private set; }

        public StorageService()
        {
            products = new List<ProductModel>();

            AddProduct(new ProductModel("sasa", "sasas", 21, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("sgsa", "sasas", 21, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("wasa", "sasas", 21, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("rasa", "sasas", 21, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("tasa", "sasas", 21, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("hasa", "sasas", 21, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("dasa", "sjkas", 21, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("sasa", "sasas", 21, "Copilot_20251007_233327.jpg"));
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
