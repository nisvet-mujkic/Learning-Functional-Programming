namespace PureFunctions
{
    public class ShoppingCart
    {
        public static int GetDiscount(List<string> items) => 
            items.Contains("book") ? 5 : 0;
    }
}