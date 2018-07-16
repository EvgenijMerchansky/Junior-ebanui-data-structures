using System.Collections.Generic;
using System;
class CustomQueue<T> {
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
    //private void ToReduce () 
    //{
    //    T[] UpdatedStore = new T[this.Store.Length - 1];
    //
    //    for (int I = 0; I < this.Store.Length; I++) 
    //    {
    //        try {
    //            UpdatedStore[I] = Store[I];
    //        } catch (IndexOutOfRangeException Ex) 
    //        {
    //            
    //        }
    //    }
    //    this.Store = UpdatedStore;
    //}

    private void QueueItemRemove ()
    {   
        T[] UpdatedStore = new T[this.Store.Length - 1];
        for (int I = 0; I < this.Store.Length; I++) 
        {
            if (this.CheckFirst) {

                UpdatedStore[I - 1] = this.Store[I];

            } else {
                this.CheckFirst = true;
                continue;
            }    
        }
        
        this.Store = UpdatedStore;
    }

    public void Add(T Item) 
    {
        this.ToEnlarge ();
        this.Store[this.Store.Length - 1] = Item;
    }

    public T Take() 
    {
        return this.Store[this.Store.Length];
    }

    //public T Peek()
    //{
    //    T Item = this.Store[this.Store.Length - 1];
    //    this.ToReduce();       
    //    return Item;
    //}

    public T Remove() 
    {
        this.QueueItemRemove();
        return this.Store[0];
    }

    public int QueueSize() {
        return this.Store.Length;
    }
}