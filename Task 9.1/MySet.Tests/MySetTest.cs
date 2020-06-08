using System.Collections.Generic;
using NUnit.Framework;

namespace MySet.Tests
{
    public class Tests
    {
        [Test]
        public void ForeachIsCorrect()
        {
            MySet<int> set = new MySet<int>();
            set.Add(1);
            set.Add(3);
            set.Add(0);
            set.Add(2);
            set.Add(4);
            List<int> list = new List<int>();
            foreach (var item in set)
            {
                list.Add(item);
            }

            for (int i = 0; i != 5; ++i)
            {
                Assert.IsTrue(list.Contains(i));
            }

            Assert.IsFalse(list.Contains(6));
        }

        [Test]
        public void CountIsCorrect()
        {
            MySet<char> set = new MySet<char>();
            Assert.AreEqual(0, set.Count);
            set.Add('c');
            set.Add('a');
            set.Add('b');
            set.Add('d');
            Assert.AreEqual(4, set.Count);
            set.Remove('c');
            Assert.AreEqual(3, set.Count);
        }

        [Test]
        public void ClearIsCorrect()
        {
            MySet<string> set = new MySet<string>();
            set.Add("abc");
            set.Add("aaa");
            set.Add("bbb");
            set.Add("ccc");
            set.Clear();
            Assert.AreEqual(0, set.Count);
            Assert.IsFalse(set.Contains("aaa"));
        }

        [Test]
        public void AdditionIsCorrect()
        {
            MySet<int> set = new MySet<int>();
            set.Add(1);
            set.Add(3);
            set.Add(0);
            set.Add(2);
            set.Add(4);
            Assert.IsTrue(set.Contains(1));
            Assert.IsTrue(set.Contains(2));
            Assert.IsTrue(set.Contains(3));
            Assert.IsTrue(set.Contains(4));
            Assert.IsTrue(set.Contains(0));
            Assert.IsFalse(set.Contains(-1));
        }

        [Test]
        public void AdditionTheSameIsCorrect()
        {
            MySet<int> set = new MySet<int>();
            set.Add(1);
            Assert.IsFalse(set.Add(1));
            Assert.AreEqual(1, set.Count);
        }

        [Test]
        public void CopyToIsCorrect()
        {
            MySet<int> set = new MySet<int>();
            var array = new int[10];
            set.Add(0);
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.CopyTo(array, 0);
            for (int i = 0; i != 6; ++i)
            {
                Assert.AreEqual(array[i], i);
            }
        }

        [Test]
        public void ExceptWithIsCorrect()
        {
            MySet<int> set = new MySet<int>();
            set.Add(1);
            set.Add(3);
            set.Add(0);
            set.Add(2);
            set.Add(4);
            List<int> list = new List<int>() { 0, 1, 5 };
            set.ExceptWith(list);
            Assert.IsFalse(set.Contains(0));
            Assert.IsFalse(set.Contains(1));
            Assert.IsTrue(set.Contains(4));
        }

        [Test]
        public void IntersectWithIsCorrect()
        {
            MySet<int> set = new MySet<int> { 1, 3, 0, 2, 4 };
            List<int> list = new List<int>() { 0, 1, 5 };
            set.IntersectWith(list);
            Assert.IsTrue(set.Contains(0));
            Assert.IsTrue(set.Contains(1));
            Assert.IsFalse(set.Contains(5));
            Assert.IsFalse(set.Contains(3));
        }

        [Test]
        public void IsProperSubsetIsCorrect()
        {
            MySet<int> set = new MySet<int> { 1, 3, 0, 2, 4, 7, 9 };
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.IsTrue(set.IsProperSubsetOf(list));
            set.Add(10);
            Assert.IsFalse(set.IsProperSubsetOf(list));
        }

        [Test]
        public void IsProperSuperSetIsCorrect()
        {
            MySet<int> set = new MySet<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> list = new List<int>() { 1, 3, 0, 2, 4, 7, 9 };
            Assert.IsTrue(set.IsProperSupersetOf(list));
            list.Add(10);
            Assert.IsFalse(set.IsProperSupersetOf(list));
        }

        [Test]
        public void OverlapsIsCorrect()
        {
            MySet<char> set = new MySet<char>() { 'a', 'b', 'c', 'd' };
            List<char> list = new List<char>() { 'b', 'e', 'f' };
            Assert.IsTrue(set.Overlaps(list));
            set.Remove('b');
            Assert.IsFalse(set.Overlaps(list));
        }

        [Test]
        public void SetEqualsIsCorrect()
        {
            MySet<char> set = new MySet<char>() { 'a', 'b', 'c', 'd' };
            List<char> list = new List<char>() { 'a', 'c', 'd', 'b' };
            Assert.IsTrue(set.SetEquals(list));
            list.Remove('b');
            Assert.IsFalse(set.SetEquals(list));
        }

        [Test]
        public void SymmetricExceptIsCorrect()
        {
            MySet<int> set = new MySet<int>() { 0, 2, 4, 5, 6, 8 };
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 6, 7, 8 };
            set.SymmetricExceptWith(list);
            Assert.IsTrue(set.Contains(1));
            Assert.IsTrue(set.Contains(3));
            Assert.IsTrue(set.Contains(7));
            Assert.IsFalse(set.Contains(0));
            Assert.IsFalse(set.Contains(2));
            Assert.IsFalse(set.Contains(8));
        }

        [Test]
        public void UnionIsCorrect()
        {
            MySet<int> set = new MySet<int>() { 0, 2, 4, 5, 6, 8 };
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 6, 7, 8 };
            set.UnionWith(list);
            Assert.IsTrue(set.Contains(0));
            Assert.IsTrue(set.Contains(1));
            Assert.IsTrue(set.Contains(2));
            Assert.IsTrue(set.Contains(3));
            Assert.IsTrue(set.Contains(4));
            Assert.IsTrue(set.Contains(5));
            Assert.IsTrue(set.Contains(6));
            Assert.IsTrue(set.Contains(7));
            Assert.IsTrue(set.Contains(8));
            Assert.AreEqual(9, set.Count);
        }
    }
}