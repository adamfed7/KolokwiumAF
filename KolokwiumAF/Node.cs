using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumAF
{
    public class Node
    {
        int id;
        string name;
        Node parent;
        List<Node> children = new List<Node>();

        static int number = 0;

        public Node(string name)
        {
            this.name = name;
            this.id = number;
            number++;
            children = new List<Node>();
            parent = this;
        }

        public void addChild(Node node)
        {
            this.children.Add(node);
            foreach (var item in children)
            {
                item.parent = this;
            }
        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public Node getParent()
        {
            return this.parent;
        }

        public int count()
        {
            return this.children.Count();
        }

        public void remove()
        {
            this.children.Clear();
            this.name = null;
        }
    }
}
