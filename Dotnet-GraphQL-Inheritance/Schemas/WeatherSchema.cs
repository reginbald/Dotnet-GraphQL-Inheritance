using System;
using Dotnet_GraphQL_Inheritance.Queries;
using Dotnet_GraphQL_Inheritance.Types;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet_GraphQL_Inheritance
{
    public class WeatherSchema : Schema
    {
        public WeatherSchema()
        {
            this.Query = new WeatherQuery();

            this.RegisterType<RainingType>();
            this.RegisterType<SunnyType>();
        }
    }
}
