using System;

class Deque<T> {
    private T[] Store = new T[0];
    bool CheckFirst = false;
    private void ToEnlarge () 
    {
        T[] UpdatedStore = new T[this.Store.Length + 1];
        for (int I = 0; I < this.Store.Length; I++) 
        {
            UpdatedStore[I] = Store[I];
        }
        this.Store = UpdatedStore;
    }

    private void ElementsMigration (T Item)
    {
        T[] UpdatedStore = new T[this.Store.Length];
        for (int I = 0; I < this.Store.Length; I++) 
        {
            try
            {
                UpdatedStore[I + 1] = Store[I];
            } 
            catch (IndexOutOfRangeException Ex) 
            {
                continue;
            }
        }
        UpdatedStore[0] = Item;
        this.Store = UpdatedStore;
    }

    private void ToReduce ()
    {
        T[] UpdatedStore = new T[this.Store.Length - 1];
        for (int I = 0; I < this.Store.Length; I++) 
        {
            try 
            {
                UpdatedStore[I] = Store[I];
            } 
            catch (IndexOutOfRangeException Ex) 
            {
                continue;
            }
            
        }
        this.Store = UpdatedStore;
    }

    private void ToUnshift ()
    {
        T[] UpdatedStore = new T[this.Store.Length - 1];
        for (int I = 0; I < this.Store.Length; I++) 
        {
            try 
            {
                UpdatedStore[I] = Store[I + 1];
            } 
            catch (IndexOutOfRangeException Ex) 
            {
                continue;
            }
            
        }
        this.Store = UpdatedStore;
    }

    public T TakeLast() 
    {
        return this.Store[this.Store.Length - 1];
    }

    public T TakeFirst() 
    {
        return this.Store[0];
    }

    public void Push(T Item) 
    {
        this.ToEnlarge ();
        this.Store[this.Store.Length - 1] = Item;
    }

    public void Shift(T Item) 
    {
        ToEnlarge ();
        ElementsMigration(Item);
    }

    public void Pop() 
    {
        this.ToReduce();
    }

    public void Unshift() 
    {
        this.ToUnshift();
    }

    public int DequeSize() {
        return this.Store.Length;
    }
}