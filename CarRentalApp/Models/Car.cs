namespace CarRentalApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Kilometer { get; set; }
        public decimal Price { get; set; }
        public string Year { get; set; }
        public bool IsRent { get; set; }
        public int BanId { get; set; }
        public int FuelId { get; set; }
        public int ModelId { get; set; }

        public Ban Ban { get; set; }
        public Fuel Fuel { get; set; }
        public Model Model { get; set; }
    }
}