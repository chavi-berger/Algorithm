using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class Q2
    {
        List<int> arr;
        List<int> countArr;
        int all;
        int count = 0, countAll = 0;

        public Q2()
        {
            arr = new List<int>();
            countArr = new List<int>();
        }

        public void Set(int key, int val)
        {
            arr[key] = val;
            countArr[key] = count++;
        }

        public int Get(int key)
        {
            if (countArr[key] > countAll)
                return arr[key];
            return all;
        }

        public void SetAll(int val)
        {
            all = val;
            countAll = count++;
        }
    }
}
