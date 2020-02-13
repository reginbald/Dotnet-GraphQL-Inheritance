using Dotnet_GraphQL_Inheritance.Interfaces;
using Dotnet_GraphQL_Inheritance.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_GraphQL_Inheritance.Types
{
    public class ForecastType : ObjectGraphType<Forecast>
    {
        public ForecastType()
        {
            Field(x => x.Weather, type: typeof(WeatherInterface));
        }
    }
}
