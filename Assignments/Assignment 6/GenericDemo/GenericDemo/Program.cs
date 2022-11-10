


GenericCollection<string> genericCollection = new GenericCollection<string>(3);
genericCollection.Add("Hello");
genericCollection.Add("World");
genericCollection.Add("!");

// Swap two items
genericCollection.Swap(0, 1);

// Print out the items in the list
for (int i = 0; i < genericCollection.Size(); i++)
{
    Console.WriteLine("item: "+genericCollection.GetItem(i));
}

Console.ReadLine();



// Create a generic collection class using array
public class GenericCollection<T> 
{
    private T[] array;
    private int nextIndex = 0;

    public GenericCollection(int size)
    {
        array = new T[size];
    }

    public void Add(T item)
    {
        array[nextIndex] = item;
        nextIndex++;
    }

    // Get item at given index
    public T GetItem(int index)
    {
        return array[index];
    }

    // Set item at given index method
    public void SetItem(int index, T item)
    {
        array[index] = item;
    }
    
    // Swap two items method
    public void Swap(int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
    // get size of array
    public int Size()
    {
        return array.Length;
    }
}