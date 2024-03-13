namespace Tour.Application.Models.Entity;

public class PaymentItemEntity
{
    public int Id { get; set; }
    public PaymentEntity Payment { get; set; }
    public TravelPackageEntity TravelPackage { get; set; }
    public int Amount { get; set; }
}