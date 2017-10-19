using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClusterizeLib
{
    public class UnionFind
    {
        private Dictionary<int, (int, int)> elementList = new Dictionary<int, (int, int)>();

        public int DisjointSetsCount
        {
            get
            {
                int count = 0;
                foreach (var element in elementList.Keys)
                {
                    if (elementList[element].Item1 == element)
                    {
                        count += 1;
                    }
                }
                return count;
            }
        }

        public void AddElement(int element, int root)
        {
            elementList.Add(element, (root,0));
        }

        public bool Contains(int element)
        {
            return elementList.ContainsKey(element);
        }

        public int Find(int element)
        {
            int currentElement = element;
            int currentParent = elementList[currentElement].Item1;
            while (currentParent != currentElement)
            {
                currentElement = currentParent;
                currentParent = elementList[currentElement].Item1;
            }
            currentElement = element;
            while (elementList[currentElement].Item1 != currentParent)
            {
                int saveElement = elementList[currentElement].Item1;
                elementList[currentElement] = (currentParent, elementList[currentElement].Item2);
                currentElement = saveElement;
            }
            return (currentParent);
        }

        public void Union(int first, int second)
        {
            int firstParent = Find(first);
            int secondParent = Find(second);
            if (elementList[firstParent].Item2 > elementList[secondParent].Item2)
            {
                elementList[secondParent] =( firstParent, elementList[secondParent].Item2);
            }
            else if (elementList[firstParent].Item2 < elementList[secondParent].Item2)
            {
                elementList[firstParent] = (secondParent, elementList[firstParent].Item2);
            }
            else
            {
                elementList[secondParent] = (firstParent, elementList[secondParent].Item2);
                elementList[firstParent] = (elementList[firstParent].Item1, elementList[firstParent].Item2+1);
            }
        }
    }
}
