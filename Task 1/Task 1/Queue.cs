using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Queue<T>
    {
        class QueueElement
        {
            private T value;
            private int priority;
            private QueueElement next;

            public T Value { get => value; set => this.value = value; }
            public int Priority { get => priority; set => priority = value; }
            public QueueElement Next { get => next; set => next = value; }
        }

        private QueueElement head;

        /// <summary>
        /// Добавляем элемент value в очередь с приоритетом priority
        /// </summary>
        /// <param name="value"></param>
        /// <param name="priority"></param>
        public void Enqueue(T value, int priority)
        {
            QueueElement newElement = new QueueElement();
            newElement.Value = value;
            newElement.Priority = priority;

            if (head == null)
            {
                head = newElement;
                return;
            }

            if (head.Priority > priority)
            {
                QueueElement temporary = head;
                head = newElement;
                newElement.Next = temporary;
                return;
            }

            QueueElement cursor = head;
            while (cursor.Next != null && cursor.Next.Priority < priority)
            {
                cursor = cursor.Next;
            }

            if (cursor.Next == null)
            {
                cursor.Next = newElement;
            }
            else
            {
                QueueElement temporary = cursor.Next;
                cursor.Next = newElement;
                newElement.Next = temporary;
            }
        }

        /// <summary>
        /// извлекаем элемент с самым высоким приоритетом
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (head == null)
            {
                throw new EmptyQueueException();
            }

            QueueElement cursor = head;
            if (cursor.Next == null)
            {
                T result = cursor.Value;
                head = null;
                return result;
            }

            while (cursor.Next.Next != null)
            {
                cursor = cursor.Next;
            }

            T value = cursor.Next.Value;
            cursor.Next = null;
            return value;
        }
    }
}