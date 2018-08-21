using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Nodes
{
  public class TreeNode<T> : NodeBase<T> where T : IComparable<T>
  {
    public TreeNode<T> LeftNode { get; set; }
    public TreeNode<T> RightNode { get; set; }
    public TreeNode<T> ParentNode { get; set; }

    public TreeNode(T data)
    {
      this.Data = data;
    }

    public void SetLeftChild(TreeNode<T> leftChild)
    {
      this.LeftNode = leftChild;
      if (LeftNode != null)
      {
        LeftNode.ParentNode = this;
      }
    }

    public void SetRightChild(TreeNode<T> rightChild)
    {
      this.RightNode = rightChild;
      if (RightNode != null)
      {
        RightNode.ParentNode = this;
      }
    }

    public void InsertInOrder(T newNodeData)
    {
      var comparison = newNodeData.CompareTo(Data);
      if (comparison <= 0)
      {
        if (LeftNode == null)
          SetLeftChild(new TreeNode<T>(newNodeData));
        else
          LeftNode.InsertInOrder(newNodeData);
      }
      else
      {
        if (RightNode == null)
          SetRightChild(new TreeNode<T>(newNodeData));
        else
          RightNode.InsertInOrder(newNodeData);
      }
    }

  }
}
