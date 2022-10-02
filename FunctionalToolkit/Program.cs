using ImperativeVsDeclarative;
using PureFunctions;

var shoppingCart = new ShoppingCart();
shoppingCart.AddItem("apple");
Console.WriteLine(shoppingCart.GetDiscount());

shoppingCart.AddItem("book");
shoppingCart.GetItems().Remove("book");
Console.WriteLine(shoppingCart.GetDiscount());