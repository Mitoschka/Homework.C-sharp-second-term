using System;
using NUnit.Framework;

namespace Task_4._1.Tests
{
    public class MyTreeTests
    {
        private MyTree myTree;

        [SetUp]
        public void Setup()
        {
            myTree = new MyTree();
        }

        [Test]
        public void NotEmtyPutExpressionToTreeTest()
        {
            myTree.PutExpressionToTree("( / ( - 8 2 ) 2 )");
            Assert.AreEqual(3, myTree.CountExpression());
        }

        [Test]
        public void EmtyPutExpressionToTreeTest()
        {
            Assert.Throws<NullException>(() => myTree.PutExpressionToTree(""));
        }

        [Test]
        public void DivideBeZeroTest()
        {
            myTree.PutExpressionToTree("/ 10 - 5 5");
            Assert.Throws<DivideByZeroException>(() => myTree.CountExpression());
        }

        [Test]
        public void ShouldThrowExceptionWenWeAddedOnlyOperand()
        {
            Assert.Throws<InvalidOperationException>(() => myTree.PutExpressionToTree("2"));
        }

        [Test]
        public void ShouldThrowExceptionWenWeAddedOnlyOperator()
        {
            Assert.Throws<InvalidOperationException>(() => myTree.PutExpressionToTree("+"));
        }

        [Test]
        public void ShouldThrowExceptionWenWeAddedMoreOperand()
        {
            Assert.Throws<InvalidOperationException>(() => myTree.PutExpressionToTree("2 3 4"));
        }

        [Test]
        public void ShouldThrowExceptionWenWeAddedMoreOperator()
        {
            myTree.PutExpressionToTree("/ + -");
            Assert.Throws<InvalidOperationException>(() => myTree.CountExpression());
        }

        [Test]
        public void ShouldThrowExceptionWeànWeAddedMoreOperator()
        {
            myTree.PutExpressionToTree("/ 5 + 3 ");
            Assert.Throws<InvalidOperationException>(() => myTree.CountExpression());
        }
    }
}