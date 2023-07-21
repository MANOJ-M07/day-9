using System;
using System.Collections.Generic;

public class LargeDataCollection<T> : IDisposable
{
    private List<T> dataCollection;

    // Constructor to initialize the collection with initial data
    public LargeDataCollection(IEnumerable<T> initialData)
    {
        dataCollection = new List<T>(initialData);
    }

    // Method to add elements to the collection
    public void AddElement(T element)
    {
        dataCollection.Add(element);
    }

    // Method to remove elements from the collection
    public bool RemoveElement(T element)
    {
        return dataCollection.Remove(element);
    }

    // Method to access elements in the collection by index
    public T GetElement(int index)
    {
        if (index >= 0 && index < dataCollection.Count)
        {
            return dataCollection[index];
        }
        throw new IndexOutOfRangeException("Index is out of range.");
    }

    // Implementing the IDisposable interface to release resources
    private bool disposed = false;

    public int Count { get; internal set; }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Release any managed resources here, if any.
                dataCollection.Clear();
                dataCollection = null;
            }

            // Release any unmanaged resources here, if any.
            // (none in this case)

            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Finalizer (destructor) - called by the Garbage Collector
    ~LargeDataCollection()
    {
        Dispose(false);
    }
}
