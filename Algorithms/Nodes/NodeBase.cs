using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Nodes
{
  public class NodeBase<T> where T : IComparable<T>
  {
    public T Data { get; set; }
  }
}
