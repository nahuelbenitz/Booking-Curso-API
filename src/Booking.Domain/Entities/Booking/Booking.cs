namespace Booking.Domain.Entities.Booking
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
    }
}
