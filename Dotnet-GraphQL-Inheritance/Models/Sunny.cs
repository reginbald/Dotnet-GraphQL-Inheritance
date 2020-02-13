using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_GraphQL_Inheritance.Models
{
    public class Sunny : IWeather
    {
        public int Humidity { get; set; }
        public bool ClearSky{ get; set; }
    }
}
