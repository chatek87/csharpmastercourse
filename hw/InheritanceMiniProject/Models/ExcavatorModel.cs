using hw_InheritanceMiniProject.Interfaces;

namespace hw_InheritanceMiniProject.Models;

public class ExcavatorModel : InventoryItemModel, IRentable
{
    public void Dig()
    {
        Console.WriteLine("I am digging");
    }

    public void Rent()
    {
        QuantityInStock--;
        Console.WriteLine($"{ProductName} #{InventoryID} has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock++;
        Console.WriteLine($"{ProductName} #{InventoryID} has been returned");
    }
}