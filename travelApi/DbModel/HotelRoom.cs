namespace travelApi.DbModel;

public class HotelRoom
{
    public int HotelRoomId { get; set; }
    public int HotelId { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public string Amenties { get; set; }
    public bool IsAvailable { get; set; }
}
