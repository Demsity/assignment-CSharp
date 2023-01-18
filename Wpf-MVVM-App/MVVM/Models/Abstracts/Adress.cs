using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM_App.MVVM.Models.Abstracts
{
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

}
