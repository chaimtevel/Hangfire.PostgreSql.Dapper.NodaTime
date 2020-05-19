using Dapper.NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.PostgreSql.Helpers
{
    public static class DapperNodaTimeHelpers
    {
        public static void AddDapperNodaTime()
        {
            DapperNodaTimeSetup.Register();
            Dapper.SqlMapper.AddTypeHandler(new Helpers.InstantHandler());
        }
    }
}
