using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private int count = 0;
        public LinkedList(T value)
        {
            head = new Node<T>(value);
            count++;
        }

        public void Add(T value)
        {
            var newNode = new Node<T>(value);
            if(head.Next == null)
            {
                head.Next = newNode;
            }
            else
            {
                var temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newNode;
            }

            count++;
        }

        public void Remove(T value)
        {
            bool found = false;
            if(head.Value.Equals(value))
            {
                head = head.Next;
                found = true;
            }
            else
            {
                var temp = head.Next;
                var previous = head;
                while (temp != null )
                {
                    if (temp.Value.Equals(value))
                    {
                        previous.Next = temp.Next;
                        found = true;
                        break;
                    }
                    else
                    {
                        previous = temp;
                        temp = temp.Next;
                    }
                }
            }

            if (found)
            {
                count--;
            }
        }
    }

    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;

        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
