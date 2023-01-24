using System;
using System.Collections;

namespace HashTable_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Binary Search Tree & HashTables******");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Binary Search Tree\n2.HashTble \n.Exit ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Insert(22);
                    binarySearch.Insert(40);
                    binarySearch.Insert(60);
                    binarySearch.Insert(95);
                    binarySearch.Insert(11);
                    binarySearch.Insert(65);
                    binarySearch.Insert(3);
                    binarySearch.Insert(16);
                    binarySearch.Insert(63);
                    binarySearch.Insert(67);
                    binarySearch.Display();
                    Console.WriteLine("_______________________");
                    binarySearch.GetSize();
                    Console.WriteLine("__________________");
                    bool result = binarySearch.IfExists(67, binarySearch);
                    Console.WriteLine(result);
                    Console.ReadKey();
                    break;
                    case 2:
                    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

                    hash.Add("0", "To");
                    hash.Add("1", "be");
                    hash.Add("2", "or");
                    hash.Add("3", "not");
                    hash.Add("4", "to");
                    hash.Add("5", "be");
                    hash.Display();
                    string getword = hash.Get("3");
                    Console.WriteLine("4th index value is : " + getword);
                    break; 
                default:
                    Console.WriteLine("Select valid options only ");
                    break;

            }
        }
    }
}
