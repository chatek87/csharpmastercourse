using hw_InheritanceMiniProject.Interfaces;

namespace hw_InheritanceMiniProject.Models;

public class BookModel : InventoryItemModel, IPurchasable
{
    public int NumberOfPages { get; set; }

    public void Purchase()
    {
        QuantityInStock--;
        Console.WriteLine("This book has been purchased");
    }
}
