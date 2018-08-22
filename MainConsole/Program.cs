using System;
using System.Collections.Generic;
using System.IO;
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
      var root = new TreeNode<int>(0);
      for (int i = 0; i < 20; i++)
      {
        if (i != 00)
          root.InsertNode(i);
      }

      try
      {
        var nd5 = root.BreadthFirstSearch(5);
        var node5 = root.DepthFirstSearchIterative(5);
        Console.WriteLine(node5?.Data.ToString() ?? "Given element not found");
        var node20 = root.DepthFirstSearchRecursive(20);
        Console.WriteLine(node20?.Data.ToString() ?? "Given element not found");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

        Console.ReadLine();
    }
  }
}
