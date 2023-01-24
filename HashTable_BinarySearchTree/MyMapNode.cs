using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable_BinarySearchTree
{
    class MyMapNode<K, V>//placeholder key,value string
    {
        private readonly int size;//global
        private readonly LinkedList<KeyValue<K, V>>[] items;//global array type linked list
        public MyMapNode(int size)//local//value is 5
        {
            this.size = size;//5 initiallize
            this.items = new LinkedList<KeyValue<K, V>>[size]; //passing size 5//item pointing to array which is non primitive so it is null
            //set up completed
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);  // |-5| =5 |3|=3 |-3|=3//methid
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };//ex.key 0,value welcome

            linkedList.AddLast(item);//if we have same position for 2 key values the this are added in linkedlist not in array
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);//passing same position
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        protected int GetArrayPosition(K key)
        {
            var hashCode = key.GetHashCode();
            int position = key.GetHashCode() % size;//5//return rem//GetHashCode is used to get hashcode //here we generate hashcode with particular key
            return Math.Abs(position);//abs used for making no.positive


        }

       
        public void Display()
        {
            
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                    foreach (var element in linkedList)
                    {
                        string s = element.ToString();
                        if (s != null)
                            Console.WriteLine(element.Key + " " + element.Value);
                    }
            }
        }
        public int Frequency(V value)
        {
            int count = 0;
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                {
                    foreach (var element in linkedList)
                    {
                        if (element.Value.Equals(value))
                            count++;
                    }
                }
            }
            Console.WriteLine("The frequency of " + value + " is: " + count);
            return count;
        }


        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];// at positin 2 in array is null
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();//one object is created
                items[position] = linkedList;//store address stored in linkedlist Object in positin 
            }
            return linkedList;//returns the address of linkedlist
            //linkedlist is local variable so after completion it will be deleted from stack
        }
    }

    public struct KeyValue<k, v>    // struct is a value type
    {

        public k Key { get; set; }
        public v Value { get; set; }
    }

}
