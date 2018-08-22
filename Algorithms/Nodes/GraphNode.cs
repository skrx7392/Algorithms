using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Nodes
{
  public class GraphNode<T> : NodeBase<T> where T:IComparable<T>
  {
    public List<GraphNode<T>> AdjacentNodes { get; set; }
    public bool Visited { get; set; }
    public GraphNode(T data)
    {
      this.AdjacentNodes = new List<GraphNode<T>>();
      this.Data = data;
    }
  }
}
