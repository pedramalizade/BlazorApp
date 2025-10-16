namespace MyBlazor.Libraries.ShoppingCart.Models
{
    public class ShoppingCartModel
    {
        public IList<ShoppingCartItemModel> Items { get; }
        public ShoppingCartModel()
        {
            Items = new List<ShoppingCartItemModel>();
        }
    }
}
