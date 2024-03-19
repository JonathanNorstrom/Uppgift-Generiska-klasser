using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CustomNameList<T>
{
    private List<T> items = new List<T>();
    // en metod som lägger till i listan
    public void Add(T item)
    {
        items.Add(item);
    }
    // en metod som tar bort från listan
    public void Remove(T item)
    {
        items.Remove(item);
    }

    public void Insert(int index, T item)
    {
        items.Insert(index, item);
    }
    // en metod för att sortera listan.
    public void Sort()
    {
        items.Sort();
    }

    public void Print()
    {
        foreach (T item in items)
        {
            Console.Write(item + " "); // skriver ut namn med mellan rum.
        }
        Console.WriteLine();
    }
}

