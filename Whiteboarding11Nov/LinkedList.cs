using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboarding11Nov
{
    public class Node
    {
        public Node next;
        public object data;
    }
    public class LinkedList
    {
        public Node head;

        public void PrintAllNodes()
        {
            Node curr = head;

            if (curr != null)
            {
                while (curr != null)
                {
                    Console.WriteLine(curr.data.ToString());
                    curr = curr.next;
                }
            }
        }
        public void AddFirst(object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;
                toAdd.next = head;
                head = toAdd;

            }

        }
        public void AddLast(object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;
                Node curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;


                }
                curr.next = toAdd;

            }
        }
        public void FindNth(int x)
        {
            Node lag = head;
            Node lead = head;

            for (int i = 1; i < x; i++)
            {
                lead = lead.next;
            }
            while (lead.next != null)
            {
                lag = lag.next;
                lead = lead.next;
            }
            Console.WriteLine(lag.data.ToString());

          
        }
       

        
    }
}
