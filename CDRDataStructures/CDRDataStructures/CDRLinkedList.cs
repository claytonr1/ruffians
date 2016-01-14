using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRDataStructures
{
    // to do:  methods to add and remove non-head nodes

    public class CDRLinkedList
    {
        private Node head;

        public CDRLinkedList()
        {
            head = null;
        }

        public void AddToStart(String itemName,int itemCount)
        {
            head = new Node(itemName, itemCount, head);
        }

        public bool DeleteHeadNode()
        {
            if (head != null)
            {
                head = head.GetLink();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            int count = 0;

            Node position = head;

            while (position != null)
            {
                count++;
                position = position.GetLink();
            }

            return count;
        }

        public bool Contains(String item)
        {
            return (Find(item) != null);
        }

        private Node Find(string target)
        {
            Node position = head;

            string itemAtPosition;
            
            while(position!=null)
            {
                itemAtPosition = position.GetItem();
                if (itemAtPosition.Equals(target))
                {
                    return position;
                }
                position = position.GetLink();
            }
            return null;
        }

        public void OutputList()
        {
            Node position = head;

            while(position!=null)
            {
                Console.WriteLine("{0} {1}",position.GetItem(),position.GetCount());
                position = position.GetLink();
            }

            
        }
    }
}
