using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Global namespace.
/// </summary>
namespace MySet
{
    /// <summary>
    /// A class that implements the ADT "Set" based on a binary tree.
    /// </summary>
    public class MySet<T> : ISet<T> where T : IComparable<T>
    {
        private class SetElement
        {
            public T Value { get; set; }
            public SetElement Parent { get; set; }
            public SetElement Left { get; set; }
            public SetElement Right { get; set; }
        }

        private SetElement head;

        private int count;

        /// <summary>
        /// The number of elements in the set.
        /// </summary>
        public int Count => count;

        /// <summary>
        /// A value indicating whether the set is read-only.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Adds an item to the current set and returns a value indicating that the item was added successfully.
        /// </summary>
        public bool Add(T item)
        {
            ++count;
            var newElement = new SetElement
            {
                Value = item
            };

            SetElement cursor = head;
            if (cursor != null)
            {
                while (true)
                {
                    if (item.CompareTo(cursor.Value) < 0)
                    {
                        if (cursor.Left == null)
                        {
                            cursor.Left = newElement;
                            newElement.Parent = cursor;
                            break;
                        }
                        cursor = cursor.Left;
                    }
                    else if (item.CompareTo(cursor.Value) > 0)
                    {
                        if (cursor.Right == null)
                        {
                            cursor.Right = newElement;
                            newElement.Parent = cursor;
                            break;
                        }
                        cursor = cursor.Right;
                    }
                    else
                    {
                        --count;
                        return false;
                    }
                }
            }
            else
            {
                head = newElement;
            }
            return true;
        }

        /// <summary>
        /// Removes all elements from a set.
        /// </summary>
        public void Clear()
        {
            head = null;
            count = 0;
        }

        /// <summary>
        /// Determines if the set contains a specific value.
        /// </summary>
        public bool Contains(T item)
        {
            SetElement cursor = head;
            if (cursor != null)
            {
                while (item.CompareTo(cursor.Value) != 0)
                {
                    if (item.CompareTo(cursor.Value) < 0)
                    {
                        if (cursor.Left == null)
                        {
                            return false;
                        }
                        cursor = cursor.Left;
                    }
                    else if (item.CompareTo(cursor.Value) > 0)
                    {
                        if (cursor.Right == null)
                        {
                            return false;
                        }
                        cursor = cursor.Right;
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Copies the elements of a collection set to an Array, starting at the specified index of the Array.
        /// </summary>
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
            if (Count > array.Length - arrayIndex)
            {
                throw new ArgumentException();
            }

            foreach (var item in this)
            {
                array[arrayIndex] = item;
                ++arrayIndex;
            }
        }

        /// <summary>
        /// Removes all elements of the specified collection from the current set.
        /// </summary>
        public void ExceptWith(IEnumerable<T> other)
        {
            
            if (other == null)
            {
                throw new ArgumentNullException();
            }
            if (other == this)
            {
                this.Clear();
                return;
            }
            foreach (var item in other)
            {
                Remove(item);
            }
        }

        /// <summary>
        /// Modifies the current set so that it contains only elements that are also in the specified collection.
        /// </summary>
        public void IntersectWith(IEnumerable<T> other)
        {
            if (other == this)
            {
                return;
            }

            foreach (var item in this)
            {
                if (!other.Contains(item))
                {
                    Remove(item);
                }
            }
        }

        /// <summary>
        /// Determines whether the current set is a proper (strict) subset of the specified collection.
        /// </summary>
        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() <= Count)
            {
                return false;
            }

            foreach (var item in this)
            {
                if (!other.Contains<T>(item))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the current set is a proper (strict) subset of the specified collection.
        /// </summary>
        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() >= Count)
            {
                return false;
            }

            foreach (var item in other)
            {
                if (!Contains(item))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the collection is a subset of the specified collection.
        /// </summary>
        public bool IsSubsetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() < Count)
            {
                return false;
            }

            foreach (var item in this)
            {
                if (!other.Contains<T>(item))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the current set is a superset of the specified collection.
        /// </summary>
        public bool IsSupersetOf(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() > Count)
            {
                return false;
            }

            foreach (var item in other)
            {
                if (!Contains(item))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the current collection and the specified collection intersect.
        /// </summary>
        public bool Overlaps(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in other)
            {
                if (Contains(item))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Removes an item from the set.
        /// </summary>
        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }

            DeleteElementFromSet(head, item);
            --count;
            return true;
        }

        private SetElement MinimumElement(SetElement setElement)
        {
            if (setElement.Left == null)
            {
                return setElement;
            }
            return MinimumElement(setElement.Left);
        }

        private SetElement DeleteElementFromSet(SetElement setElement, T item)
        {
            if (setElement == null)
            {
                return setElement;
            }
            if (item.CompareTo(setElement.Value) < 0)
            {
                setElement.Left = DeleteElementFromSet(setElement.Left, item);
            }
            else if (item.CompareTo(setElement.Value) > 0)
            {
                setElement.Right = DeleteElementFromSet(setElement.Right, item);
            }
            else if (setElement.Left != null && setElement.Right != null)
            {
                SetElement tempElement = MinimumElement(setElement.Right);
                setElement.Value = tempElement.Value;
                setElement.Right = DeleteElementFromSet(setElement.Right, setElement.Value);
            }
            else
            {
                if (setElement.Left != null)
                {
                    SetElement tempElement = setElement;
                    setElement = setElement.Left;
                    if (head == tempElement)
                    {
                        head = setElement;
                    }
                }
                else if (setElement.Right != null)
                {
                    SetElement tempElement = setElement;
                    setElement = setElement.Right;
                    if (head == tempElement)
                    {
                        head = setElement;
                    }
                }
                else
                {
                    SetElement tempElement = setElement;
                    setElement = null;
                    if (head == tempElement)
                    {
                        head = setElement;
                    }
                }
            }
            return setElement;
        }

        /// <summary>
        /// Determines whether the current set and the specified collection contain the same elements.
        /// </summary>
        public bool SetEquals(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            if (other.Count<T>() != Count)
            {
                return false;
            }

            return IsSupersetOf(other);
        }

        /// <summary>
        /// Changes the current set so that it contains only elements that are either in it or in the specified collection, but not both there and there.
        /// </summary>
        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }
            if (other == this)
            {
                this.Clear();
                return;
            }

            foreach (var item in other)
            {
                if (Contains(item))
                {
                    Remove(item);
                }
                else
                {
                    Add(item);
                }
            }
        }

        /// <summary>
        /// Changes the current set so that it contains all the elements that are in the current set, in the specified collection, or both of them.
        /// </summary>
        public void UnionWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }
            if (other == this)
            {
                return;
            }

            foreach (var item in other)
            {
                if (!Contains(item))
                {
                    Add(item);
                }
            }
        }

        void ICollection<T>.Add(T item)
        {
            Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator for passing through a collection.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            var stack = new Stack<SetElement>();
            var current = head;
            while (stack.Count > 0 || current != null)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else
                {
                    current = stack.Pop();
                    yield return current.Value;
                    current = current.Right;
                };
            }
        }
    }
}
