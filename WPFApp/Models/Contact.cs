using System;
using WPFApp.Models.Abstracts;

namespace WPFApp.Models;

internal interface IContact : IAdress
{
    Guid Id { get; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string PhoneNumber { get; set; }


}
internal class Contact : IContact, IAdress
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    public string DisplayName => $"{FirstName} {LastName}";
    public string FullAdress => $"{StreetName}, {PostalCode.Insert(3, " ")} {City}";
}

