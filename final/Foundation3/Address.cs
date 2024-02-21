public class Address
{
    public string StreetAddress { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }

    public Address(string streetAddress, string city, string state, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {State}, {Country}";
    }
}
