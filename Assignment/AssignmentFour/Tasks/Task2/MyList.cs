namespace Assignment.AssignmentFour.Tasks.Task2;

/*
   Create a Generic List data structure MyList<T> that can store any data type. Implement the following methods:

   void Add(T element)
   T Remove(int index)
   bool Contains(T element)
   void Clear()
   void InsertAt(T element, int index)
   void DeleteAt(int index)
   T Find(int index)
*/
public class MyList<T>
{
    private List<T> _myList = new List<T>();
    public int Count => _myList.Count;

    public void Add(T element)
    {
        _myList.Add(element);
    }

    public T Remove(int index)
    {
        if (index > Count - 1 || index < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            T item = _myList[index];
            _myList.RemoveAt(index);
            return item;
        }
    }

    public bool Contains(T element)
    {
        if (_myList.Contains(element))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Clear()
    {
        _myList.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index == Count  || index < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else

        {
            _myList.Insert(index, element);
        }
    }

    public void DeleteAt(int index)
    {
        if (index > Count - 1 || index < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            _myList.RemoveAt(index);
        }
    }

    public T Find(int index)
    {
        if (index > Count - 1 || index < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            return _myList[index];
        }
    }
}