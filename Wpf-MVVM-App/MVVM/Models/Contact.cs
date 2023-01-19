using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_App.MVVM.Models.Abstracts;

namespace Wpf_MVVM_App.MVVM.Models
{

    internal interface IContact : IAdress
    {
        Guid Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }


    }
    public class Contact : IContact, IAdress
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string StreetName { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public string FullName => $"{FirstName} {LastName}";

        public string FullAdress => $"{StreetName}, {PostalCode} {City}";
    }
}

