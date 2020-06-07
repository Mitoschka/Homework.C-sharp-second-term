using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySet
{
    public class BinTree<T>: IEnumerable<T> where T: IComparable<T>
    {
        class TreeElement
        {
            public T value;
            public TreeElement parent;
            public TreeElement left;
            public TreeElement right;
        }

        private TreeElement head;
        private int count;

        public void AddElementToTree(T value)
        {
            ++count;
            TreeElement newElement = new TreeElement
            {
                value = value
            };

            TreeElement cursor = head;
            if (cursor != null)
            {
                while (true)
                {
                    if (value.CompareTo(cursor.value) <= 0)
                    {
                        if (cursor.left == null)
                        {
                            cursor.left = newElement;
                            newElement.parent = cursor;
                            break;
                        }
                        cursor = cursor.left;
                    }
                    else if (value.CompareTo(cursor.value) > 0)
                    {
                        if (cursor.right == null)
                        {
                            cursor.right = newElement;
                            newElement.parent = cursor;
                            break;
                        }
                        cursor = cursor.right;
                    }
                }
            }
            else
            {
                head = newElement;
            }
        }

        private TreeElement MinimumElement(TreeElement treeElement)
        {
            if (treeElement.left == null)
            {
                return treeElement;
            }
            return MinimumElement(treeElement.left);
        }

        private TreeElement Next(TreeElement treeElement)
        {
            if (treeElement.right != null)
            {
                return MinimumElement(treeElement.right);
            }
            TreeElement tempElement = treeElement.parent;
            while (tempElement != null && treeElement == tempElement.right)
            {
                treeElement = tempElement;
                tempElement = tempElement.parent;
            }
            return tempElement;
        }

        public void DeleteElement(T valueToDelete)
        {
            if (IsContain(valueToDelete))
            {
                --count;
                DeleteElementFromTree(head, valueToDelete);
            }
        }

        private TreeElement DeleteElementFromTree(TreeElement treeElement, T valueToDelete)
        {
            if (treeElement == null)
            {
                return treeElement;
            }
            if (valueToDelete.CompareTo(treeElement.value) < 0)
            {
                treeElement.left = DeleteElementFromTree(treeElement.left, valueToDelete);
            }
            else if (valueToDelete.CompareTo(treeElement.value) > 0)
            {
                treeElement.right = DeleteElementFromTree(treeElement.right, valueToDelete);
            }
            else if (treeElement.left != null && treeElement.right != null)
            {
                TreeElement tempElement = MinimumElement(treeElement.right);
                treeElement.value = tempElement.value;
                treeElement.right = DeleteElementFromTree(treeElement.right, treeElement.value);
            }
            else
            {
                if (treeElement.left != null)
                {
                    TreeElement tempElement = treeElement;
                    treeElement = treeElement.left;
                }
                else if (treeElement.right != null)
                {
                    TreeElement tempElement = treeElement;
                    treeElement = treeElement.right;
                }
                else
                {
                    TreeElement tempElement = treeElement;
                    treeElement = null;
                }
            }
            return treeElement;
        }

        public int Count()
        {
            return count;
        }

        private void FromTreeToArray(TreeElement cursor, T[] array, ref int arrayIndex)
        {
            if (cursor.left != null)
            {
                FromTreeToArray(cursor.left, array, ref arrayIndex);
            }

            array[arrayIndex] = cursor.value;
            ++arrayIndex;

            if (cursor.right != null)
            {
                FromTreeToArray(cursor.right, array, ref arrayIndex);
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (head == null)
            {
                return;
            }

            int index = arrayIndex;

            FromTreeToArray(head, array, ref index);
        }

        public bool IsContain(T valueToChecked)
        {
            TreeElement cursor = head;
            if (cursor != null)
            {
                while (valueToChecked.CompareTo(cursor.value) != 0)
                {
                    if (valueToChecked.CompareTo(cursor.value) < 0)
                    {
                        if (cursor.left == null)
                        {
                            return false;
                        }
                        cursor = cursor.left;
                    }
                    else if (valueToChecked.CompareTo(cursor.value) > 0)
                    {
                        if (cursor.right == null)
                        {
                            return false;
                        }
                        cursor = cursor.right;
                    }
                }
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var stack = new Stack<TreeElement>();
            var current = head;
            while (stack.Count > 0 || current != null)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                else
                {
                    current = stack.Pop();
                    yield return current.value;
                    current = current.right;
                };
            }
        }
    }
}
