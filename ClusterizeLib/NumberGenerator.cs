using System;
using System.Collections.Generic;

namespace ClusterizeLib
{
    public class NumberGenerator : IEnumerable<int>
    {
        public int BaseNumber { private set; get; }

        public NumberGenerator(string input)
        {
            BaseNumber = Convert.ToInt32(input, 2);
        }

        public IEnumerator<int> GetEnumerator()
        {
            int mask = 8388608;
            yield return BaseNumber;
            for (int i = 0; i<24; i += 1)
            {
                yield return BaseNumber ^ (mask >> i);
            }
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
