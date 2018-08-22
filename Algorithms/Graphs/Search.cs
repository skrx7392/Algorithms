using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;

namespace Algorithms.Graphs
{
  public static class Search
  {
    public static GraphNode<T> BreadthFirstSearch<T>(this GraphNode<T> root, T data) where T : IComparable<T>
    {
      var queue = new Queue<GraphNode<T>>();
      queue.Enqueue(root);
      while (queue.Peek() != null)
      {
        var currentNode = queue.Dequeue();
        if (currentNode.Data.CompareTo(data) == 0)
          return currentNode;
        foreach (var adjacentNode in currentNode.AdjacentNodes)
        {
          queue.Enqueue(adjacentNode);
        }
      }
      return null;
    }

    public static GraphNode<T> DepthFirstSearchIterative<T>(this GraphNode<T> root, T data) where T : IComparable<T>
    {
      var stack = new Stack<GraphNode<T>>();
      stack.Push(root);
      while (stack.Peek() != null)
      {
        var currentNode = stack.Pop();
        if (currentNode.Data.CompareTo(data) == 0)
          return currentNode;
        foreach (var adjacentNode in currentNode.AdjacentNodes)
        {
          stack.Push(adjacentNode);
        }
      }
      return null;
    }

    // Imperfect... Needs more refactoring
    public static GraphNode<T> DepthFirstSearchRecursive<T>(this GraphNode<T> node, T data, List<GraphNode<T>> queuedNodes = null) where T : IComparable<T>
    {
      if(queuedNodes == null)
        queuedNodes = new List<GraphNode<T>>();
      if (queuedNodes.Contains(node))
        queuedNodes.Remove(node);
      node.Visited = true;
      if (node.Data.CompareTo(data) == 0)
        return node;
      queuedNodes.AddRange(node.AdjacentNodes.Where(p=>!p.Visited && !queuedNodes.Any(w=>w==p)));
      GraphNode<T> returnNode = null;
      foreach (var adjacentNode in node.AdjacentNodes.Where(p=>queuedNodes.Any(w=>w==p)))
      {
        if (returnNode == null)
          returnNode = adjacentNode.DepthFirstSearchRecursive(data, queuedNodes);
        else
          return returnNode;
      }
      return returnNode;
    }
  }
}
