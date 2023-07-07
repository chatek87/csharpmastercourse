namespace hw_InheritanceMiniProject.Interfaces;

public interface IRentable : IInventoryItem
{
    void Rent();
    void ReturnRental();
}
