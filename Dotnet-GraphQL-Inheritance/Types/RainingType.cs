using Dotnet_GraphQL_Inheritance.Interfaces;
using Dotnet_GraphQL_Inheritance.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_GraphQL_Inheritance.Types
{
    public class RainingType : ObjectGraphType<Raining>
    {
        public RainingType()
        {
            Field(x => x.Humidity);
            Field(x => x.Floods);
            Interface<WeatherInterface>();
        }
    }
}
