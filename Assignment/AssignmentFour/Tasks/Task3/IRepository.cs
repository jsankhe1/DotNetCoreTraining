namespace Assignment.AssignmentFour.Tasks.Task3;

public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);

}