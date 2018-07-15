using System; 
class LinkedLIsts <T>
{
    private T CurrentNode;
    private T NextNode;
    private int InitialArrayLength = 1;
    private T[] InitialArray = new T[0];

    public LinkedLIsts () 
    {

    }
    private T CreateNodeWithLink (T Item)
    {
        if (this.InitialArray.Length == 0) 
        {
            T NodeWithLink = new Node<T>().CreateNode(Item, default(T));
            return NodeWithLink;
        }
        else
        {
            T PreviousElem = this.InitialArray[this.InitialArray.Length - 1];            
            T NodeWithLink = new Node<T>().CreateNode(Item, PreviousElem);
            return NodeWithLink;
        }
    }
    private void ToEnlarge () 
    {
        T[] UpdatedArray = new T[this.InitialArray.Length + 1];
        for (int I = 0; I < this.InitialArray.Length; I++) 
        {
            UpdatedArray[I] = InitialArray[I];
        }
        this.InitialArray = UpdatedArray;
    }
    public void Add(T Item) 
    {
        T ArrayItem = CreateNodeWithLink(Item);
        if (this.InitialArray.Length != 0)
        {
            ToEnlarge();
            this.InitialArray[this.InitialArray.Length - 1] = ArrayItem;
        }
        else
        {
            ToEnlarge();
            this.InitialArray[0] = ArrayItem;
        }
    }
    public T Get(int Idx) 
    {
        return this.InitialArray[Idx];
    }
    public void Remove(int Idx) {
        T[] UpdatedArray = new T[this.InitialArray.Length - 1];
        for (int I = 0; I > this.InitialArray.Length; I++) 
        {
            if (Idx == I)
            {
                continue;
            }
            else 
            {
                UpdatedArray[I] = CreateNodeWithLink(this.InitialArray[I]);
            }
        }        
        this.InitialArray = UpdatedArray;
    }
    public int Size() {
        return this.InitialArray.Length;
    }
}
