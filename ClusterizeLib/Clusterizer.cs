using System;
using System.Collections.Generic;
using System.Text;

namespace ClusterizeLib
{
    public class Clusterizer
    {
        private UnionFind unionFind = new UnionFind();

        public int DisjointSetsCount { get { return unionFind.DisjointSetsCount; } }

        public void Add(string input)
        {
            var baseNumber = Convert.ToInt32(input, 2);
            var root = baseNumber;
            var numberGenerator = new NumberGenerator(input);

            foreach ( var num in numberGenerator)
            {
                if (unionFind.Contains(num))
                {
                    var newRoot = unionFind.Find(num);
                    unionFind.Union(newRoot, root);
                    root = newRoot;
                }
                else
                {
                    unionFind.AddElement(num, root);
                }
            }
        }
    }
}
