using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySet
{
    class MySet<T> : ISet<T> where T: IComparable<T>
    {
        private BinTree<T> binTree = new BinTree<T>();

        public int Count => binTree.Count();

        public bool IsReadOnly => false;

        public bool Add(T item)
        {
            binTree.AddElementToTree(item);
            return binTree.IsContain(item);
        }

        public void Clear()
        {
            binTree = new BinTree<T>();
        }

        public bool Contains(T item)
        {
            return binTree.IsContain(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (binTree.Count() > array.Length - arrayIndex)
            {
                throw new ArgumentException();
            }

            foreach (var item in binTree)
            {
                array[arrayIndex] = item;
                ++arrayIndex;
            }
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                binTree.DeleteElement(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            BinTree<T> newTree = new BinTree<T>();
            foreach (var item in other)
            {
                if (binTree.IsContain(item))
                {
                    newTree.AddElementToTree(item);
                }
            }

            binTree = newTree;
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() <= binTree.Count())
            {
                return false;
            }

            foreach (var item in binTree)
            {
                if (!other.Contains<T>(item))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() >= binTree.Count())
            {
                return false;
            }

            foreach (var item in other)
            {
                if (!binTree.IsContain(item))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() < binTree.Count())
            {
                return false;
            }

            foreach (var item in binTree)
            {
                if (!other.Contains<T>(item))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() > binTree.Count())
            {
                return false;
            }

            foreach (var item in other)
            {
                if (!binTree.IsContain(item))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in other)
            {
                if (binTree.IsContain(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool Remove(T item)
        {
            if (!binTree.IsContain(item))
            {
                return false;
            }

            binTree.DeleteElement(item);
            return !binTree.IsContain(item);
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() != binTree.Count())
            {
                return false;
            }

            return IsSupersetOf(other);
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
