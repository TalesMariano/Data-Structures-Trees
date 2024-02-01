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

            Print(tree.Name);
            Print(tree.Root.Data);

            tree.Search(2);


            Console.ReadLine();
        }


        #region HelperMethodsRegion
        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        #endregion
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public Node Search(int target)
        {
            if(target == Data)
            {
                Console.WriteLine("Found it!");
                return this;
            }

            if (Left != null && Data > target)
                return Left.Search(target);

            if (Right != null && Data < target)
                return Right.Search(target);

            Console.WriteLine("Value not in the tree");
            return null;
        }
    }

    public class Tree
    {
        public Node Root { get; set; }
        public string Name { get; set; }

        public Tree(Node root, string name = "")
        {
            Root = root;
            Name = name;
        }

        public Node Search(int target)
        {
            return Root.Search(target);
        }
    }
}
