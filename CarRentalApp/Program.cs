using CarRentalApp.Models;

Ban sedan = new()
{
    Id = 1,
    Name = "Sedan"
};

Ban kupe = new()
{
    Id = 2,
    Name = "kupe"
};

Ban hecbek = new()
{
    Id = 3,
    Name = "Hecbek"
};

Marka alfa_romeo = new()
{
    Id = 1,
    Name = "Alfa Romeo"
};

Marka bmw = new()
{
    Id = 2,
    Name = "BMW"
};

Model giulia = new()
{
    Id = 1,
    Name = "Giulia",
    MarkaId = alfa_romeo.Id
};

Fuel benzin = new()
{
    Id = 1,
    Name = "Benzin"
};

Car car = new()
{
    Id = 1,
    BanId = sedan.Id,
    Fuel = benzin
};

Reservation reservation1 = new()
{
    Id = 1,
    Car = car,
    CustomerName = "Ali",
    CustomerSurname = "Shirinov",
    CustoemrFinCode = "fsagdvghasdghas",
    BirthDate = "10.08.1994",
    ReservationStartDate = "08.06.2023",
    ReservationEndDate = "18.06.2023"
};


Console.WriteLine(reservation1.CustomerName);