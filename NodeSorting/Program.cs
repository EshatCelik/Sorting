using System;
using System.Collections.Generic;
using System.Globalization;

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
                if (Head==null)
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
                        if (current.Next.Data==data)
                        {
                            current.Next=current.Next.Next;
                            return;
                        }
                        current=current.Next;
                    }
                }
            }

            public void Update(int oldData,int newData)
            {                                              //10 ,15,20 ,30 ,40
                var node = new Node(newData);              //10    ,50 ,30 ,40
                if (Head==null)
                {
                    return;
                }
                var current = Head;
                while (current.Data!=null)
                {
                    if (current.Data==oldData)
                    {
                        current.Data = newData;
                        return;
                    }
                    current=current.Next;
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
            linked.Add(10);
            linked.Add(15);
            linked.Add(20);
            linked.Add(25);
            linked.Add(30);
            linked.Add(35);

            //---Silme
            linked.Update(10,1);
            linked.Update(20,2);
            linked.Update(30,3);

            linked.Display();

            Console.ReadKey();
        }
    }
}
