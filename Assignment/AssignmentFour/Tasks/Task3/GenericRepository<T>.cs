namespace Assignment.AssignmentFour.Tasks.Task3;

/*
Implement a GenericRepository<T> class that implements an IRepository<T> interface that will have common CRUD operations
so that it can work with any data source such as SQL Server, Oracle, In-Memory Data, etc.
Make sure you have a type constraint on T where it should be of reference type and can be of type
Entity which has one property called Id. IRepository<T> should have the following methods:

void Add(T item)
void Remove(T item)
void Save()
IEnumerable<T> GetAll()
T GetById(int id)

 */
public class GenericRepository<T> : IRepository<T> where T : Entity
{
    // placeholder Datastorage, gonna use fake list like explained during the class 3 and 4.
    private List<T> _fakeStorage = new List<T>();
    // IDE suggests this should  be also readonly? Should ask in next class.

    public void Add(T item)
    {
        _fakeStorage.Add(item);
    }

    public void Remove(T item)
    {
        _fakeStorage.Remove(item);
    }

    public void Save()
    {
        // confused, maybe useful for real storages?
    }

    public IEnumerable<T> GetAll()
    {
        return _fakeStorage; // confused here
        // I think above works because List<T> is a generic collection that implements Ienumerable<T>
    }

    public T GetById(int id)
    {
        foreach (T entry in _fakeStorage)
        {
            if (entry.Id == id)
            {
                return entry;
            }
        }

        return null;
    }
}