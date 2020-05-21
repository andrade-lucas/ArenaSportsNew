namespace Arena.Shared.Commands
{
    public interface ICommand<T> where T : class
    {
        bool Execute(T entity);
    }
}
