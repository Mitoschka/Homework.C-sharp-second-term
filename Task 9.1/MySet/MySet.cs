using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MySet
{
    /// <summary>
    /// Класс, реализущий АТД "Множество" на основе двоичного дерева.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MySet<T> : ISet<T> where T : IComparable<T>
    {
        class SetElement
        {
            public T Value { get; set; }
            public SetElement Parent { get; set; }
            public SetElement Left { get; set; }
            public SetElement Right { get; set; }
        }

        private SetElement head;

        private int count;

        /// <summary>
        /// Количество элементов во множестве.
        /// </summary>
        public int Count => count;

        /// <summary>
        /// Значение, показывающее, доступно ли множество только для чтения.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Добавляет элемент в текущий набор и возвращает значение, указывающее, что элемент был добавлен успешно.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Add(T item)
        {
            ++count;
            SetElement newElement = new SetElement
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
        /// Удаляет все элементы из множества.
        /// </summary>
        public void Clear()
        {
            head = null;
            count = 0;
        }

        /// <summary>
        /// Определяет, содержит ли множество определенное значение.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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
        /// Копирует элементы коллекции множества в массив Array, начиная с указанного индекса массива Array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
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
        /// Удаляет все элементы указанной коллекции из текущего множества.
        /// </summary>
        /// <param name="other"></param>
        public void ExceptWith(IEnumerable<T> other)
        {
            foreach (var item in other)
            {
                Remove(item);
            }
        }

        /// <summary>
        /// Изменяет текущий набор, чтобы он содержал только элементы, которые также имеются в заданной коллекции.
        /// </summary>
        /// <param name="other"></param>
        public void IntersectWith(IEnumerable<T> other)
        {
            foreach (var item in this)
            {
                if (!other.Contains(item))
                {
                    Remove(item);
                }
            }
        }

        /// <summary>
        /// Определяет, является ли текущий набор должным (строгим) подмножеством заданной коллекции.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
        /// Определяет, является ли текущий набор должным (строгим) подмножеством заданной коллекции.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
        /// Определяет, является ли набор подмножеством заданной коллекции.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
        /// Определяет, является ли текущий набор надмножеством заданной коллекции.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
        /// Определяет, пересекаются ли текущий набор и указанная коллекция.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
        /// Удаляет элемент из множества.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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
        /// Определяет, содержат ли текущий набор и указанная коллекция одни и те же элементы.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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
        /// Изменяет текущий набор таким образом, чтобы он содержал только элементы, которые есть либо в нем, либо в указанной коллекции, но не одновременно там и там.
        /// </summary>
        /// <param name="other"></param>
        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
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
        /// Изменяет текущий набор так, чтобы он содержал все элементы, которые имеются в текущем наборе, в указанной коллекции либо в них обоих.
        /// </summary>
        /// <param name="other"></param>
        public void UnionWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
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
        /// Возвращает перечислитель для прохода по коллекции.
        /// </summary>
        /// <returns></returns>
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
