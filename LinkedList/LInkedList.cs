using System; 
class LinkedLIsts <T>
{
    private Node<T> Head;
    private Node<T> Tail;
    private int Length = 0;

    private string Chain = "Root: ";

    public LinkedLIsts () 
    {

    }

    public void Add(T Item) 
    {
        Node<T> NewNode = new Node<T>(Item);

        if (Head == null) 
        {
            Head = NewNode;
        }
        else
        {
            Tail.NextNode = NewNode;
        }

        Tail = NewNode;
        this.Length = this.Length + 1;
        this.Chain = this.Chain + "=> |" + NewNode.GetData() + "| ";
    }

    public void Remove(T Item)
    {
        Node<T> Current = Head;
        Node<T> Previous = Tail;

        while(Current != null)
        {
            if (Current.GetData().Equals(Item))
            {
                Previous.NextNode = Current.NextNode;
                if (Current.NextNode == null) 
                {
                    Tail = Previous;
                }
            }
            else
            {
                Head = Head.NextNode;
                if (Head == null)
                {
                    Tail = null;
                }
            }
            this.Length = this.Length =- 1;
            System.Console.WriteLine(Current.GetData() + " <- data");
        }
        Previous = Current;
        Current = Current.NextNode;
    }

    public void GetChain()
    {
        System.Console.WriteLine(this.Chain);
    }

    public int Size() {
        return this.Length;
    }
}
