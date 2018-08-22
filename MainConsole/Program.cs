using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Graphs;
using Algorithms.Nodes;
using Algorithms.Trees;

namespace MainConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      var rootNode = new GraphNode<int>(0);
      var node1 = new GraphNode<int>(1) {AdjacentNodes = new List<GraphNode<int>>() {rootNode}};
      var node2 = new GraphNode<int>(2) {AdjacentNodes = new List<GraphNode<int>>() {node1}};
      var node3 = new GraphNode<int>(3) {AdjacentNodes = new List<GraphNode<int>>() {node1}};
      var node4 = new GraphNode<int>(4) {AdjacentNodes = new List<GraphNode<int>>() {node2, node3}};
      var node5 = new GraphNode<int>(5) {AdjacentNodes = new List<GraphNode<int>>() {rootNode, node3, node4}};
      rootNode.InsertNode(node1);
      rootNode.InsertNode(node2);
      rootNode.InsertNode(node3);
      rootNode.InsertNode(node4);
      rootNode.InsertNode(node5);

      var n5_bfs = rootNode.BreadthFirstSearch(5);
      var n5_dfsr = rootNode.DepthFirstSearchRecursive(5);
      var n5_dfsi = rootNode.DepthFirstSearchIterative(5);



      Console.ReadLine();
    }
  }
}
