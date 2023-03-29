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
                    //binarySearch.Insert(11);
                    //binarySearch.Insert(65);
                    //binarySearch.Insert(3);
                    //binarySearch.Insert(16);
                    //binarySearch.Insert(63);
                    //binarySearch.Insert(67);
                    binarySearch.Display();
                    Console.WriteLine("_______________________");
                    binarySearch.GetSize();
                    Console.WriteLine("__________________");
                    bool result = binarySearch.IfExists(67, binarySearch);
                    Console.WriteLine(result);
                    Console.ReadKey();
                    break;
                   
              
                case 2:
                    MyMapNode<string, int> myMap1 = new MyMapNode<string, int>(6);
                    string sentence = "To be or not to be";
                    CountNumbOfOccurence(sentence);
                    break;
                case 3:
                    String paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(paragraph);
                    break;
                case 4:
                    MyMapNode<string, int> myMap = new MyMapNode<string, int>(6);
                    String Para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] Words = Para.Split(" ");
                    foreach (string word in Words)
                    {
                        int Value =myMap .Get(word);
                        if (Value == default)
                            Value = 1;
                        else Value++;
                      myMap.Add(word, Value);
                    }
                    int Frequency = myMap.Get("paranoid");
                    Console.WriteLine("\"paranoid\" comes {0} times in the given paragraph", Frequency);
                    Frequency = myMap.Get("are");
                    Console.WriteLine("\"are\" comes {0} times in the given paragraph", Frequency);
                    Frequency = myMap.Get("they");
                    Console.WriteLine("\"they\" comes {0} times in the given paragraph", Frequency);
                    break;

                default:
                    Console.WriteLine("Select valid options only ");
                    break;

            }
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Displaying after add operation");
            hashTabe.Display();
            string s = "or";
            string r = "avoidable";
            hashTabe.Remove(r);
            hashTabe.Remove(s);
            Console.WriteLine("After removed an item {0}", s);
            Console.WriteLine("After removed an item {0}", r);

            hashTabe.Display();
        }
    }
}
