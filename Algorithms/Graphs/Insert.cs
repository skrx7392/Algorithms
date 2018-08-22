using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;

namespace Algorithms.Graphs
{
  public static class Insert
  {
    public static void InsertNode<T>(this GraphNode<T> root, GraphNode<T> newNode) where T : IComparable<T>
    {
      foreach (var node in newNode.AdjacentNodes)
      {
        var adjacentNode = root.BreadthFirstSearch(node.Data);
        if(adjacentNode == null)
          throw new Exception($"Neighbor node {node.Data.ToString()} not found");
        adjacentNode.AdjacentNodes.Add(newNode);
      }
    }
  }
}
