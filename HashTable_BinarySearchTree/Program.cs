using System;

namespace HashTable_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Binary Search Tree & HashTables******");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            
            binarySearch.Display();
        }
    }
}
