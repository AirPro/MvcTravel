using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MvcTravel.Models.DataLayer
{
	public class QueryOptions<T>
	{
		public Expression<Func<T, object>> OrderBy { get; set; }

		public Expression<Func<T, object>> Where { get; set; }

		private string[] includes;

		public string Includes
		{
			set => includes = value.Replace(" ", "").Split(',');
		}

		public string[] GetIncludes() => includes ?? new string[0];

		public bool HasWhere => Where != null;

		public bool HasOrderBy => OrderBy != null;
	}
}
