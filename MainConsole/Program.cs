using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;
using Algorithms.Trees;

namespace MainConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      var root = new TreeNode<int>(3);
      for (int i = 0; i < 7; i++)
      {
        if (i != 3)
          root.InsertInOrder(i);
      }

      try
      {
        var nd5 = root.BreadthFirstSearch(5);
        var node5 = root.DepthFirstSearchRecursive(5);
        Console.WriteLine(node5.Data);
        var node20 = root.DepthFirstSearchRecursive(20);
        Console.WriteLine(node20.Data);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
