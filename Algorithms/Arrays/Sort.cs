using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
  public static class Sort
  {
    #region MergeSort
    public static void MergeSort(this IEnumerable<int> list)
    {
      int[] helper = new int[list.Count()];
      MergeSort(list.ToArray(), helper, 0, list.Count()-1);
    }

    private static void MergeSort(int[] array, int[] helper, int low, int high)
    {
      if (low<high)
      {
        var middle = (low + high) / 2;
        MergeSort(array, helper,  low, middle);
        MergeSort(array, helper, middle+1, high);
        Merge(array, helper, low, middle, high);
      }
    }

    private static void Merge(int[] array, int[] helper, int low, int middle, int high)
    {
      for (int i = low; i <= high; i++)
      {
        helper[i] = array[i];
      }

      int helperLeft = low;
      int helperRight = middle + 1;
      int current = low;

      while (helperLeft <= middle && helperRight <= high)
      {
        if (helper[helperLeft] <= helper[helperRight])
        {
          array[current] = helper[helperLeft];
          helperLeft++;
        }
        else
        {
          array[current] = helper[helperRight];
          helperRight++;
        }

        current++;
      }

      int remaining = middle - helperLeft;
      for (int i = 0; i <= remaining; i++)
      {
        array[current + i] = helper[helperLeft + i];
      }
    }
    #endregion
  }
}
