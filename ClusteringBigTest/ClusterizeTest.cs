using ClusterizeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClusteringBigTest
{
    [TestClass]
    public class ClusterizeTest
    {
        [TestMethod]
        public void TestClusterizer()
        {
            var clusterizer = new Clusterizer();
            clusterizer.Add("000000000000000000000000");
            clusterizer.Add("111000000000000000000000");
            clusterizer.Add("000000000000000000000111");
            clusterizer.Add("000000000000000000000101");
            Assert.AreEqual(2,clusterizer.DisjointSetsCount);
        }

    }
}
