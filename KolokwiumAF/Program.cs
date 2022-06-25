using System;

namespace KolokwiumAF
{
    class Program
    {
        static void Main(string[] args)
        {
            Node dziadek = new Node("Dziadek");

            Node ojciec1 = new Node("Ojciec1");
            Node ojciec2 = new Node("Ojciec2");
            Node ojciec3 = new Node("Ojciec3");

            dziadek.addChild(ojciec1);
            dziadek.addChild(ojciec2);
            dziadek.addChild(ojciec3);

            Node syn11 = new Node("syn11");
            Node syn12 = new Node("syn12");

            ojciec1.addChild(syn11);
            ojciec1.addChild(syn12);


            Node syn21 = new Node("syn21");

            ojciec2.addChild(syn21);


            Tree tree = new Tree();

            tree.addNext(dziadek);
            tree.addNext(ojciec1);
            tree.addNext(ojciec2);
            tree.addNext(ojciec3);
            tree.addNext(syn11);
            tree.addNext(syn12);
            tree.addNext(syn21);

            Console.WriteLine("---------Elementy w drzewie--------------");
            foreach (Node node in tree.nodes)
            {
                Console.WriteLine("Nazwa: " + node.getName() + " --------- id: " + node.getId());
            }

            Console.WriteLine("-------------------------------------------------------------");

            foreach (Node node in tree.nodes)
            {
                Console.WriteLine("Nazwa: " + node.getName() + " ---------- ilosc dzieci: " + node.count());
            }

            Console.WriteLine("-------------------------------------------------------------");

            
            foreach (Node node in tree.nodes)
            {
                Console.WriteLine("Node: " + node.getName() + " ---------- jego rodzic: " + node.getParent().getName());
            }

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Poczatek korzeni: " + tree.toBegining().getName());

            Console.WriteLine("--------------------------------------------------------------");

            
        }
    }
}
