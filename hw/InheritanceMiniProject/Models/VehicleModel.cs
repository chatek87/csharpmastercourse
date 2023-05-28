using hw_InheritanceMiniProject.Interfaces;

namespace hw_InheritanceMiniProject.Models;

public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
{
    public decimal DealerFee { get; set; }

    public void Purchase()
    {
        QuantityInStock--;
        Console.WriteLine("This vehicle has been purchased");
    }

    public void Rent()
    {
        QuantityInStock--;
        Console.WriteLine("This vehicle has been rented");
    }

    public void ReturnRental()
    {
        QuantityInStock++;
        Console.WriteLine("This vehicle has been returned");
    }
}
