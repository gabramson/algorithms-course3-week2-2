using ClusterizeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClusteringBigTest
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void TestGenerator()
        {
            var numberGenerator = new NumberGenerator("100010001000100010001000");
            var mySequence = numberGenerator.GetEnumerator();
            mySequence.MoveNext();
            Assert.AreEqual(8947848, actual: mySequence.Current);
            mySequence.MoveNext();
            Assert.AreEqual(559240, actual: mySequence.Current);
            mySequence.MoveNext();
            Assert.AreEqual(13142152, actual: mySequence.Current);
        }
    }
}
