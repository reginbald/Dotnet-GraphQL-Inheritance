using Dotnet_GraphQL_Inheritance.Interfaces;
using Dotnet_GraphQL_Inheritance.Models;
using Dotnet_GraphQL_Inheritance.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_GraphQL_Inheritance.Queries
{
    public class WeatherQuery : ObjectGraphType
    {
        public WeatherQuery()
        {
            this.Field<ListGraphType<ForecastType>>(
                "forecast",
                resolve: context => new List<Forecast>() {
                    new Forecast()
                    {
                        Weather = null
                    },
                    new Forecast()
                    {
                        Weather = new Raining()
                        {
                            Humidity = 100,
                            Floods = true
                        }
                    },
                    new Forecast()
                    {
                        Weather =
                        new Sunny()
                        {
                            Humidity = 0,
                            ClearSky = true
                        }
                    },
                    new Forecast()
                    {
                        Weather = new Raining()
                        {
                            Humidity = 30,
                            Floods = false
                        }
                    },
                    new Forecast()
                    {
                        Weather =
                            new Sunny()
                            {
                                Humidity = 20,
                                ClearSky = false
                            }
                    }
                });
        }
    }
}
