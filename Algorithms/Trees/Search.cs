using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;

namespace Algorithms.Trees
{
  public static class Search
  {
    /// <exception cref="KeyNotFoundException">Requested data could not be found</exception>
    public static TreeNode<T> BreadthFirstSearch<T>(this TreeNode<T> root, T data) where T : IComparable<T>
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
      return null;
    }

    public static TreeNode<T> DepthFirstSearchIterative<T>(this TreeNode<T> root, T data) where T : IComparable<T>
    {
      var stack = new Stack<TreeNode<T>>();
      stack.Push(root);
      while (stack.Peek() != null)
      {
        var currentNode = stack.Pop();
        if (currentNode.Data.CompareTo(data) == 0)
          return currentNode;
        if (currentNode.RightNode != null)
          stack.Push(currentNode.RightNode);
        if (currentNode.LeftNode != null)
          stack.Push(currentNode.LeftNode);
      }
      return null;
    }

    /// <exception cref="KeyNotFoundException">Requested data could not be found</exception>
    public static TreeNode<T> DepthFirstSearchRecursive<T>(this TreeNode<T> node, T data) where T : IComparable<T>
    {
      if (node.Data.CompareTo(data) == 0)
        return node;
      var foundNode = node.LeftNode?.DepthFirstSearchRecursive(data);
      if (foundNode != null)
        return foundNode;
      return node.RightNode?.DepthFirstSearchRecursive(data);
    }
  }
}
