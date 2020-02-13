using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_GraphQL_Inheritance.Models
{
    public class Forecast
    {
        public IWeather Weather { get; set; }
    }
}
