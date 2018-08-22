using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Nodes;

namespace Algorithms.Trees
{
    public static class Insert
    {
        public static void InsertInOrder<T>(this TreeNode<T>node, T newNodeData) where T : IComparable<T>
        {
            var comparison = newNodeData.CompareTo(node.Data);
            if (comparison <= 0)
            {
                if (node.LeftNode == null)
                    node.SetLeftChild(new TreeNode<T>(newNodeData));
                else
                    node.LeftNode.InsertInOrder(newNodeData);
            }
            else
            {
                if (node.RightNode == null)
                    node.SetRightChild(new TreeNode<T>(newNodeData));
                else
                    node.RightNode.InsertInOrder(newNodeData);
            }
        }

        public static void InsertNode<T>(this TreeNode<T> node, T newNodeData) where T : IComparable<T>
        {
            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(node);
            while (queue.Peek() != null)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.LeftNode == null)
                {
                    currentNode.SetLeftChild(new TreeNode<T>(newNodeData));
                    return;
                }
                else if (currentNode.RightNode == null)
                {
                    currentNode.SetRightChild(new TreeNode<T>(newNodeData));
                    return;
                }
                else
                {
                    queue.Enqueue(currentNode.LeftNode);
                    queue.Enqueue(currentNode.RightNode);
                }
            }
        }
    }
}
