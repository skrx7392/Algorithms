using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;

namespace Algorithms.Trees
{
  public static class BreadthFirstSearch
  {
    /// <exception cref="KeyNotFoundException">Requested data could not be found</exception>
    public static TreeNode<T> SearchBreadthFirst<T>(this TreeNode<T> root, T data) where T : IComparable<T>
    {
      Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
      if (root == null)
        return null;
      queue.Enqueue(root);
      while (queue.Peek() != null)
      {
        var node = queue.Dequeue();
        if (node.Data.CompareTo(data) == 0)
          return node;
        if (node.LeftNode != null)
          queue.Enqueue(node.LeftNode);
        if (node.RightNode != null)
          queue.Enqueue(node.RightNode);
      }

      throw new KeyNotFoundException("Requested data could not be found");
    }
  }
}
