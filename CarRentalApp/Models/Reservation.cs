namespace CarRentalApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustoemrFinCode { get; set; }
        public string BirthDate { get; set; }
        public string ReservationStartDate { get; set; }
        public string ReservationEndDate { get; set; }

    }
}
