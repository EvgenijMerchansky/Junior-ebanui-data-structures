using System;
 class Node<T>
 {
    private T Data;
    public Node (T Data) 
    {
        this.Data = Data;
    }

    public T GetData()
    {
        return this.Data;
    }

    public Node<T> NextNode { get; set; }
 }