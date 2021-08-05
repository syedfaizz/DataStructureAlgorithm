using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
        public class LinkedList
        {
            internal Node head;

            internal void Add(int data)
            {
                Node node = new Node(data);
                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} inserted into Linked List," + node.data);
            }

            internal void Display()
            {

                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("LinkedList is empty");
                    return;
                }
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }