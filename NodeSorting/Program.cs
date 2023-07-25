using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security;

namespace NodeSorting
{
    internal class Program
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        public class LinkedList
        {
            public Node Head;

            public LinkedList()
            {
                Head = null;
            }

            public void Add(int data)               //   ||null|null||
            {                                       //   ||10|null|| 
                var node = new Node(data);          //   ||10|null|| ->||15|null||
                if (Head == null)
                {
                    Head = node;
                }
                else
                {
                    var currentNode = Head;
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = node;
                }

            }

            public void Delete(int data)
            {
                var node = new Node(data);  //      10 - 15 - 20 - 25 - 30
                if (Head == null)
                {
                    return;
                }
                if (node.Data == Head.Data)
                {
                    Head = Head.Next;
                }
                else
                {
                    var current = Head;
                    while (current.Next != null)
                    {
                        if (current.Next.Data == data)
                        {
                            current.Next = current.Next.Next;
                            return;
                        }
                        current = current.Next;
                    }
                }
            }

            public void Update(int oldData, int newData)
            {                                              //10 ,15,20 ,30 ,40
                var node = new Node(newData);              //10    ,50 ,30 ,40
                if (Head == null)
                {
                    return;
                }
                var current = Head;
                while (current.Data != null)
                {
                    if (current.Data == oldData)
                    {
                        current.Data = newData;
                        return;
                    }
                    current = current.Next;
                }
            }
            public void AddNodeToMidde(int data)
            {
                // sıralı olduğunu düşünüyoruz !!!!
                var node = new Node(data);
                if (Head == null)
                {
                    Head = node;
                    return;
                }

                //   40
                if (Head.Next == null)         // 10, 
                {
                    if (Head.Data > data)
                    {
                        node.Next = Head;
                        Head = node;
                    }
                    else
                    {
                        Head.Next = node;

                    }
                    return;
                }              //          40
                var current = Head;
                while (current.Data != null)  // 10,20,30, ___, 50
                {
                    if (current.Next == null)
                    {
                        current.Next = node;
                        return;
                    }
                    if (current.Next.Data < data)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        node.Next = current.Next;
                        current.Next = node;
                        return;
                    }
                }


            }

            public void Display()
            {
                var node = Head;

                while (node != null)
                {
                    Console.Write(node.Data.ToString() + " ");
                    node = node.Next;
                }
            }

        }
        static void Main(string[] args)
        {
            var linked = new LinkedList();
            // linked.Add(10);
            // linked.Add(20);
            // linked.Add(30);
            //// linked.Add(40);
            // linked.Add(50);
            // linked.Add(60);


            //add node to middel

            linked.AddNodeToMidde(40);
            linked.AddNodeToMidde(19);
            linked.AddNodeToMidde(10);
            linked.AddNodeToMidde(9);
            linked.AddNodeToMidde(70);
            linked.AddNodeToMidde(66);
            linked.AddNodeToMidde(0);
            linked.AddNodeToMidde(20);
            linked.AddNodeToMidde(2);

            //---Update
            //linked.Update(10,1);
            //linked.Update(20,2);
            //linked.Update(30,3);

            linked.Display();

            Console.ReadKey();
        }
    }
}
