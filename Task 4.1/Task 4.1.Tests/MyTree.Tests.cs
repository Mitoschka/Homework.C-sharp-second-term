using NUnit.Framework;

namespace Task_4._1.Tests
{
    public class MyTreeTests
    {
        MyTree myTree;

        [SetUp]
        public void Setup()
        {
            myTree = new MyTree();
        }

        [Test]
        public void NotEmtyPutExpressionToTreeTest()
        {
            myTree.PutExpressionToTree("+ 1 2");
            Assert.AreEqual(3, myTree.CountExpression());
        }

        [Test]
        public void EmtyPutExpressionToTreeTest()
        {
            Assert.Throws<NullException>(() => myTree.PutExpressionToTree(""));
        }
    }
}