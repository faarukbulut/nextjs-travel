namespace travelApi.DbModel;

public class Hotel
{
    public int HotelId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string Address { get; set; }
    public double Rating { get; set; }
    public decimal PricePerNight { get; set; }
}
