using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Nodes
{
  public class LinkedListNode<T> : NodeBase<T> where T : IComparable<T>
  {
    public LinkedListNode<T> NextNode { get; set; }
    public LinkedListNode<T> PreviousNode { get; set; }

    public LinkedListNode(T data)
    {
      this.Data = Data;
      this.NextNode = null;
      this.PreviousNode = null;
    }
  }
}
