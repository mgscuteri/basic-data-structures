using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace tests
{
    class SortHelper
    {
        public static List<int> MergeSort(List<int> unsorted)
        {
            if(unsorted.Count <= 1)
            {
                return unsorted;
            }

            var midPoint = unsorted.Count/2;

            List<int> left = new List<int> { };
            List<int> right = new List<int> { }; 

            for(int i = 0; i < midPoint; i++)
            {
                left.Add(unsorted[i]);
            }

            for(int i = midPoint; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int> { };

            if (left.Count == 0 || right.Count == 0)
            {
                result.AddRange(left);
                result.AddRange(right);
                return result;
            }

            int l = 0;
            int r = 0;

            //iterate through both lists
            while(l < left.Count || r < right.Count)
            {
                //avoid any index out of bounds exceptions
                if(l < left.Count && r < right.Count)
                {
                    //handle the case where there is no min (they are equal)
                    if (left[l] == right[r])
                    {
                        result.Add(left[l]);
                        result.Add(right[r]);
                        l++;
                        r++;
                        continue;
                    }

                    result.Add(Math.Min(left[l], right[r]));

                    if (left[l] < right[r])
                    {
                        l++;
                    }
                    else
                    {
                        r++;
                    }
                }
                //Handle final case where one value is null
                else
                {
                    if(l < left.Count)
                    {
                        result.Add(left[l]);
                        l++;
                    } 
                    if(r < right.Count)
                    {
                        result.Add(right[r]);
                        r++; 
                    }
                }
                               
            }

            return result;

        }

        public void LinqSort(List<int> unsorted)
        {
            unsorted.OrderBy(x => x);
            return ;
        }
    }
}
