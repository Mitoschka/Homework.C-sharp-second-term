using NUnit.Framework;

namespace MySet.Tests
{
    public class Tests
    {
        [Test]
        public void TestMethod1()
        {
            BinTree<int> binTree = new BinTree<int>();
            binTree.AddElementToTree(2);
            binTree.AddElementToTree(1);
            binTree.AddElementToTree(5);
            binTree.AddElementToTree(6);
            binTree.AddElementToTree(4);
            Assert.AreEqual(true, binTree.IsContain(2));
            Assert.AreEqual(true, binTree.IsContain(1));
            Assert.AreEqual(true, binTree.IsContain(5));
            Assert.AreEqual(true, binTree.IsContain(6));
            Assert.AreEqual(true, binTree.IsContain(4));
            Assert.AreEqual(false, binTree.IsContain(3));
            binTree.DeleteElement(2);
            binTree.DeleteElement(3);
            binTree.DeleteElement(6);
            binTree.DeleteElement(1);
            Assert.AreEqual(false, binTree.IsContain(2));
            Assert.AreEqual(false, binTree.IsContain(1));
            Assert.AreEqual(true, binTree.IsContain(5));
            Assert.AreEqual(false, binTree.IsContain(6));
            Assert.AreEqual(true, binTree.IsContain(4));
            Assert.AreEqual(false, binTree.IsContain(3));
        }
    }
}