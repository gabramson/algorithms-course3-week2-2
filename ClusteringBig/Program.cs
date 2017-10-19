using System;
using System.IO;
using ClusterizeLib;

namespace ClusteringBig
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            var clusterizer = new Clusterizer();
            string line;
            var reader = new StreamReader("clustering_big.txt");
            while((line = reader.ReadLine()) != null)
            {
                i += 1;
                if (i % 1000 == 0)
                {
                    Console.WriteLine(i);
                }
                clusterizer.Add(line.Replace(" ", ""));
            }
            Console.WriteLine(clusterizer.DisjointSetsCount);
            Console.ReadKey();
        }
    }
}
