namespace Assignment.AssignmentFour.Tasks.Task1;

public class MyStack<T>
{
    private List<T> myStackList = new List<T>();
    
    public int Count()
    {
        return myStackList.Count;
    }

    public T Pop()
    {
        if (Count() == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        
        T item = myStackList[Count() - 1];
        myStackList.RemoveAt(Count() - 1);
        return item;
    }

    public void Push(T item)
    {
        myStackList.Add(item);
        
    }
    
}