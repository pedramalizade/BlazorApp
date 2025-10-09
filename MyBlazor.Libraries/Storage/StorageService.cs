using MyBlazor.Libraries.Product.Models;

namespace MyBlazor.Libraries.Storage
{
    public class StorageService : IStorageService
    {
        public IList<ProductModel> products { get; private set; }

        public StorageService()
        {
            products = new List<ProductModel>();

            AddProduct(new ProductModel("motor", "motor", 21000, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("Car", "Car", 94000, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("Mobile", "Mobile", 84000, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("Home", "Home", 34000, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("LapTop", "LapTop", 71000, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("PC", "PC", 46000, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("IMac", "IMac", 50000, "Copilot_20251007_233327.jpg"));
            AddProduct(new ProductModel("Book", "Book", 69000, "Copilot_20251007_233327.jpg"));
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
