namespace WPFApp.Models.Abstracts;

internal interface IAdress
{
    string StreetName { get; set; }
    string PostalCode { get; set; }
    string City { get; set; }

}

internal abstract class Adress : IAdress
{
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
}

