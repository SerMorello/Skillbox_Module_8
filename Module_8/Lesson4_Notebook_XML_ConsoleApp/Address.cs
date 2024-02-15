public class Address
{
    string Street { get; set; }
    string HouseNumber { get; set; }
    string FlatNumbe { get; set; }

    public Address(string street, string houseNumber, string flatNumbe)
    {
        Street = street;
        HouseNumber = houseNumber;
        FlatNumbe = flatNumbe;
    }
}