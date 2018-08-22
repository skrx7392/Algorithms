using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;

namespace Algorithms.Trees
{
  public static class Traversal
  {
    public static void InOrderTraversal<T>(this TreeNode<T> node) where T : IComparable<T> 
    {
      if (node != null)
      {
        InOrderTraversal(node.LeftNode);
        // Set current node as visited;
        InOrderTraversal(node.RightNode);
      }
    }

    public static void PreOrderTraversal<T>(this TreeNode<T> node) where T : IComparable<T>
    {
      if (node != null)
      {
        // Set current node as visited
        PreOrderTraversal(node.LeftNode);
        PreOrderTraversal(node.RightNode);
      }
    }

    public static void PostOrderTraversal<T>(this TreeNode<T> node) where T : IComparable<T>
    {
      if (node != null)
      {
        PostOrderTraversal(node.LeftNode);
        PostOrderTraversal(node.RightNode);
        // Set current node as visited
      }
    }
  }
}
