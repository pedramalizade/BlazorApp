namespace MyBlazor.Libraries.Product.Models
{
    public interface IProductAddToCart
    {
        public ProductModel? Product { get; set; }
        public int? Quantity { get; set; }
        void AddToCart();
    }
}
