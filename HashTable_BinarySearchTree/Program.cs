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
            Console.WriteLine("1.Binary Search Tree\n2.HashTbleUC1 \n3. HashTable UC2\n4 .HashTableUC3 \n5 Exit ");
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
                    case 3:
                    MyMapNode<string, string> hashtable = new MyMapNode<string, string>(18);
                    hashtable.Add("0", "“Paranoids");
                    hashtable.Add("1", "are");
                    hashtable.Add("2", "not");
                    hashtable.Add("3", "paranoid");
                    hashtable.Add("4", "because");
                    hashtable.Add("5", "they");
                    hashtable.Add("6", "are");
                    hashtable.Add("7", "paranoid");
                    hashtable.Add("8", "but");
                    hashtable.Add("9", "because");
                    hashtable.Add("10", "they");
                    hashtable.Add("11", "keep");
                    hashtable.Add("12", "putting");
                    hashtable.Add("13", "themselves");
                    hashtable.Add("14", "deliberately");
                    hashtable.Add("15", "into");
                    hashtable.Add("16", "paranoid");
                    hashtable.Add("17", "avoidable");
                    hashtable.Add("18", "situations”");
                  
                    hashtable.Display();
                    hashtable.Frequency("paranoid");
                    break;
                    case 4:
                    MyMapNode<string, string> hashtable1 = new MyMapNode<string, string>(18);
                    hashtable1.Add("0", "“Paranoids");
                    hashtable1.Add("1", "are");
                    hashtable1.Add("2", "not");
                    hashtable1.Add("3", "paranoid");
                    hashtable1.Add("4", "because");
                    hashtable1.Add("5", "they");
                    hashtable1.Add("6", "are");
                    hashtable1.Add("7", "paranoid");
                    hashtable1.Add("8", "but");
                    hashtable1.Add("9", "because");
                    hashtable1.Add("10", "they");
                    hashtable1.Add("11", "keep");
                    hashtable1.Add("12", "putting");
                    hashtable1.Add("13", "themselves");
                    hashtable1.Add("14", "deliberately");
                    hashtable1.Add("15", "into");
                    hashtable1.Add("16", "paranoid");
                    hashtable1.Add("17", "avoidable");
                    hashtable1.Add("18", "situations”");
                   
                     hashtable1.Remove("17");
                    hashtable1.Display();
                    Console.WriteLine("17 Value Avoidable word is deleted");
                    
                    break;


                default:
                    Console.WriteLine("Select valid options only ");
                    break;

            }
        }
    }
}
