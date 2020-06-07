using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example_Kursach.repo
{
    public class BaseRepository<TEntity>
    {
		private List<TEntity> _cachedEntities = new List<TEntity>();
		private readonly string _tableName;
		private readonly PropertyInfo _keyProp;
		private readonly Func<TEntity, int> _keySelector;

		public event Action<string> OnErrorOccured;

		private const string _connection = @"Data Source=PERIIT\MY_INSTANCE;Initial Catalog=kursach;Integrated Security=True";


		public BaseRepository(string tableName, Expression<Func<TEntity, int>> keySelector)
		{
			_tableName = tableName;
			if (!(keySelector.Body is MemberExpression propSelector) || !(propSelector.Member is PropertyInfo prop))
				throw new ArgumentException("Invalid key selector");
			_keyProp = prop;
			_keySelector = keySelector.Compile();
		}

		public virtual void GetValues(string query = null)
		{
			if (query == null)
				query = $"select * from [{_tableName}]";
			using (var connection = new SqlConnection(_connection))
			{
				connection.Open();
				var result = connection.Query<TEntity>(query)
					.ToList();
				connection.Close();
				_cachedEntities = result;
			}
		}

		public virtual void Insert(TEntity entity, bool useCahce = true)
		{
			var sb = new StringBuilder($"insert into [{_tableName}] (");
			var props = entity.GetType().GetProperties()
				.Where(value => value.Name != _keyProp.Name)
				.ToArray();

			for (var i = 0; i < props.Length; i++)
			{
				sb.Append("[");
				sb.Append(props[i].Name);
				sb.Append("]");
				if (i != props.Length - 1)
					sb.Append(" ,");
			}

			sb.Append($") output inserted.[{_keyProp.Name}]");


			sb.Append(" values (");
			for (var i = 0; i < props.Length; i++)
			{
				sb.Append($"@param{i}");
				if (i != props.Length - 1)
					sb.Append(" ,");
			}
			sb.Append(")");

			var query = sb.ToString();

			var sqlParams = props.Select((value, index) => new SqlParameter()
			{
				Value = value.GetValue(entity),
				ParameterName = $"@param{index}"
			})
			.ToArray();

			using (var connection = new SqlConnection(_connection))
			{
				connection.Open();

				using (var command = connection.CreateCommand())
				{
					command.CommandText = query;
					command.Parameters.AddRange(sqlParams);
					HandleErrorable(connection, () =>
					{
						int newId = 0;
						using (var reader = command.ExecuteReader())
							while (reader.Read())
								newId = reader.GetInt32(0);

						if (useCahce)
						{
							_keyProp.SetValue(entity, newId);
							_cachedEntities.Add(entity);
						}
						else
							GetValues();
					});
				}
			}
		}

		private void HandleErrorable(SqlConnection connection, Action action)
		{
			try
			{
				action?.Invoke();
			}
			catch (Exception ex)
			{
				OnErrorOccured?.Invoke(ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		//public virtual void DeleteEnity(TEntity entity, bool useCache = true)
		//{
		//	var query = $"delete from {_tableName} where {_keyProp.Name} = {_keySelector(entity)}";
		//	using (var connection = new SqlConnection(_connection))
		//	{
		//		connection.Open();
		//		HandleErrorable(connection, () =>
		//		{
		//			connection.Execute(query);
		//			if (useCache)
		//				_cachedEntities.Remove(entity);
		//			else
		//				GetValues();
		//		});
		//	}
		//}

		public IEnumerable<TEntity> Values => _cachedEntities;
	}
}
