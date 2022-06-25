using System.Collections.Generic;
using System.Linq;


namespace KolokwiumAF
{
    public class Tree
    {
        public List<Node> nodes = new List<Node>();

        public void addNext(Node node)
        {
            this.nodes.Add(node);
        }

        public Node toBegining()
        {
            return this.nodes.First();
        }

        public void remove(Node node)
        {
            this.nodes.Remove(node);
        }

    }
}
