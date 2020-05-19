using Dapper;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Hangfire.PostgreSql.Helpers
{
	/// <summary>
	/// See https://github.com/StackExchange/Dapper/issues/198#issuecomment-436513676
	/// </summary>
	public class InstantHandler : SqlMapper.TypeHandler<Instant>
	{
		public InstantHandler() { }

		public override void SetValue(IDbDataParameter parameter, Instant value)
		{
			parameter.Value = value;
		}

		// This is not necessary since Npgsql alredy provide the correct typed value
		public override Instant Parse(object value)
		{
			return (Instant)value;
		}
	}
}
