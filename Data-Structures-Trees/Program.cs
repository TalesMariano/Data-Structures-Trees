using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree( new Node(2), "my tree");

            Console.WriteLine("Hello World");

            Print(tree.name);
            Print(tree.root.data);
            Console.ReadLine();
        }

        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(int value)
        {
            Console.WriteLine(value);
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int _data)
        {
            data = _data;
        }
    }

    public class Tree
    {
        public Node root;
        public string name;

        public Tree(Node _root, string _name)
        {
            root = _root;
            name = _name;
        }
    }
}
