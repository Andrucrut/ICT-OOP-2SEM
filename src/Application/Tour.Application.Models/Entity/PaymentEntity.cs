namespace Tour.Application.Models.Entity;

public class PaymentEntity
{
    public int Id { get; set; }
    public User User { get; set; }
    public string PaymentMethod { get; set; }
    public DateTime PaymentDate { get; set; }
    public Status Status { get; set; }
}

enum Status 
{
    Paid,
    Canceled, 
    PaidPartiauly
}