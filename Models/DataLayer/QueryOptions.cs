using System;
using System.Linq.Expressions;

namespace MvcTravel.Models.DataLayer
{
	public class QueryOptions<T>
	{
		public Expression<Func<T, object>> OrderBy { get; set; }

		public Expression<Func<T, object>> ThenOrderBy { get; set; }

		public Expression<Func<T, bool>> Where { get; set; }

		private string[] includes;

		public string Includes
		{
			set => includes = value.Replace(" ", "").Split(',');
		}

		public string[] GetIncludes() => includes ?? new string[0];

		public bool HasWhere => Where != null;

		public bool HasOrderBy => OrderBy != null;

		public bool HasThenOrderBy => ThenOrderBy != null;
	}
}
