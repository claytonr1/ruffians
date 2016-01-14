using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRDataStructures
{
    public class Node
    {
        private string item;
        private int count;
        private Node link;

        public Node()
        {
            link = null;
            item = null;
            count = 0;
        }

        public Node(string newItem,int newCount, Node linkValue)
        {
            SetData(newItem, newCount);
            link = linkValue;
        }

        public void SetData(string newItem, int newCount)
        {
            item = newItem;
            count = newCount;
        }

        public void SetLink(Node newLink)
        {
            link = newLink;
        }

        public string GetItem()
        {
            return item;
        }

        public int GetCount()
        {
            return count;
        }

        public Node GetLink()
        {
            return link;
        }
    }
}
