using Dotnet_GraphQL_Inheritance.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_GraphQL_Inheritance.Interfaces
{
    public class WeatherInterface : InterfaceGraphType<IWeather>
    {
        public WeatherInterface()
        {
            Field(x => x.Humidity);
        }
    }
}
