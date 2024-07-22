namespace SimpleERP.Repository.Generic
{
	public interface IGenericRepository<T, T1> where T : class where T1 : class
	{
		Task<(T Entity1, T1 Entity2)> Add(T entity);
		Task Update(T entity);
		Task Delete(T entity);
	}
}
