using Dotnet_GraphQL_Inheritance.Interfaces;
using Dotnet_GraphQL_Inheritance.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_GraphQL_Inheritance.Types
{
    public class SunnyType : ObjectGraphType<Sunny>
    {
        public SunnyType()
        {
            Field(x => x.Humidity);
            Field(x => x.ClearSky);
            Interface<WeatherInterface>();
        }
    }
}
