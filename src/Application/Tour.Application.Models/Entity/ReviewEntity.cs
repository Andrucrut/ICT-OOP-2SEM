namespace Tour.Application.Models.Entity;

public class ReviewEntity
{
    public int Id { get; set; }
    public TravelPackageEntity TravelPackageId { get; set; }
    public string AuthorName { get; set; }
    public string Text { get; set; }
    public int Rating { get; set; }
}