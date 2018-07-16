using System;
class StackBasedOnArray <T> 
{
    private T[] Stack = new T[0];

    private void ToEnlarge () 
    {
        T[] UpdatedStack = new T[this.Stack.Length + 1];
        for (int I = 0; I < this.Stack.Length; I++) 
        {
            UpdatedStack[I] = Stack[I];
        }
        this.Stack = UpdatedStack;
    }

    private void ToReduce ()
    {
        T[] UpdatedStack = new T[this.Stack.Length - 1];
        for (int I = 0; I < this.Stack.Length; I++) 
        {
            try 
            {
                UpdatedStack[I] = Stack[I];
            } 
            catch (IndexOutOfRangeException Ex) 
            {
                continue;
            }
            
        }
        this.Stack = UpdatedStack;
    }

    public void Push(T Item)
    {
        this.ToEnlarge();
        this.Stack[this.Stack.Length - 1] = Item;
    }

    public T Pop()
    {   
        try 
        {
            T Item = this.Stack[this.Stack.Length - 1];
            this.ToReduce(); 
            
            return Item;
        } 
        catch (IndexOutOfRangeException Ex) 
        {
            System.Console.WriteLine("Stack is empty!");
            return default(T);
        }
        
    }

    public int Size()
    {
        return this.Stack.Length;
    }
}