
namespace SimpleERP.Repository.Generic
{
	public class GenericRepository<T, T1> : IGenericRepository<T, T1> where T : class where T1 : class
	{
		public Task<(T Entity1, T1 Entity2)> Add(T entity)
		{
			throw new NotImplementedException();
		}

		public Task Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public Task Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
