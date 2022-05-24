namespace ToDoApp.Repositories
{
    public interface IRepository<T> where T : new()
    {
        void Save(T obj);
        T Read();
    }
}