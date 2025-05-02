using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    class Linear
    {
        public int Linearsearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index < n)
            {
                if (A[index] == key)

                    return index;
                index++;
            }
            
            return -1;

        }
          
          
         
    }
}
