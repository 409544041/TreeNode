using System;
using System.IO;
//to arxeio na exei int enan se kathe grammi
namespace TreeNodeApp
{

    class TreeNode
    {
        public int data;
        //pointers
        public TreeNode left;
        public TreeNode right;
    }

    class BinaryTree
    {
        public TreeNode root;

        public BinaryTree() //Δημιουργεί ένα κενό δέντρο ,οριζουμε τις πράξεις
        {
            root = null;
        }
        public void addNode(ref TreeNode node, int data)
        {
            if (node == null)
            {
                node = new TreeNode();  // Dhmiourgei ena neo komvo(node) tou dentrou αν ειναι null
                node.data = data;
                node.left = null;
                node.right = null;

            }
            else if (data < node.data) { addNode(ref node.left, data); }
            else if (data > node.data) { addNode(ref node.right, data); }
            else { Console.WriteLine("Το στοιχείο {0} υπάρχει ήδη!", node.data); }
        }
        //σειρά επίσκεψης κόμβων με αναδρομή
        public void inOrder(ref TreeNode i)
        {
            if (i != null)
            {
                inOrder(ref i.left);
                Console.WriteLine(i.data);
                inOrder(ref i.right);
            }
        }
        public void postOrder(ref TreeNode j)
        {
            if (j != null)
            {
                postOrder(ref j.left);
                postOrder(ref j.right);
                Console.WriteLine(j.data);
            }
        }
        public void preOrder(ref TreeNode i)
        {
            if (i != null)
            {
                Console.WriteLine(i.data);
                preOrder(ref i.left);
                preOrder(ref i.right);

            }
        }

        public bool find(TreeNode node, int data) // kάνει αναζήτηση
        {

            bool found = false;
            while (node != null && (!found))
            {
                if (node.data == data)
                {
                    found = true;
                }
                else if (data < node.data)
                {
                    node = node.left;
                }
                else
                {
                    node = node.right;
                }
            }
            return found;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                BinaryTree myTree = new BinaryTree();
                TreeNode node = new TreeNode();
                myTree.addNode(ref node, 1);
                myTree.addNode(ref node, 3);
                myTree.addNode(ref node, 4);
                myTree.addNode(ref node, 6);
                myTree.addNode(ref node, 25);
                myTree.addNode(ref node, 4);
                myTree.addNode(ref node, 67);
                myTree.addNode(ref node, 4);
                myTree.addNode(ref node, 78);
                myTree.addNode(ref node, 20);
                myTree.addNode(ref node, 5);
                myTree.addNode(ref node, 34);

                Console.WriteLine("In Order");
                Console.WriteLine("-----------");
                myTree.inOrder(ref node);

                Console.WriteLine("Post Order");
                Console.WriteLine("-----------");
                myTree.postOrder(ref node);

                Console.WriteLine("Pre Order");
                Console.WriteLine("-----------");
                myTree.preOrder(ref node);
            }



            catch (Exception e)
            {
                e.ToString();
            }

        }
    }

}