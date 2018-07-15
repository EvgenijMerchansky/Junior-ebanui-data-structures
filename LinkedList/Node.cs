using System;
 class Node<T>
 {
     private T CurrentNode;
     private T NextNode;
     public T CreateNode (T Item, T PreviousElem) 
     {
         if (PreviousElem == null) 
         {
             this.CurrentNode = Item;
             this.NextNode = default(T);
             return Item;
         } 
         else 
         {
             this.CurrentNode = PreviousElem;
             this.NextNode = Item; 
             return Item; 
         }
     }
     public T currentNode 
     {
         get
         {
             return this.CurrentNode;
         }
     }
     public T nextNode 
     {
         get
         {
             return this.NextNode;
         }
     }
 }