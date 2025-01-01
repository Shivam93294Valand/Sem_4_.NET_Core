using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1.Create an ArrayList for StudentName and perform following operations:
            //a.Add() - To Add new student in list
            //b.Remove() - To Remove Student with specified index
            //c.RemoveRange() - To Remove student with specified range.
            //d.Clear() - To clear all the student from the list
            //ArrayList StudentName = new ArrayList();
            //StudentName.Add("abc");
            //StudentName.Add("xyz");
            //StudentName.Add("abc1");
            //StudentName.Add("xyz1");
            //StudentName.Add("abc2");
            //StudentName.Add("xyz2");
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After adding all student");
            //}

            //StudentName.Remove("abc");
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After removing 0 index student");
            //}

            //StudentName.RemoveRange(3, 2);
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After removing 3rd index to 2 student range");
            //}

            //StudentName.Clear();
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After clear students");
            //}

            //2.Create a List for StudentName and perform following operations:
            //a.Add() - To Add new student in list
            //b.Remove() - To Remove Student with specified index
            //c.RemoveRange() - To Remove student with specified range.
            //d.Clear() - To clear all the student from the list
            //List<string> StudentName = new List<string>();
            //StudentName.Add("abc");
            //StudentName.Add("xyz");
            //StudentName.Add("abc1");
            //StudentName.Add("xyz1");
            //StudentName.Add("abc2");
            //StudentName.Add("xyz2");
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After adding all student");
            //}

            //StudentName.Remove("abc");
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After removing 0 index student");
            //}

            //StudentName.RemoveRange(3, 2);
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After removing 3rd index to 2 student range");
            //}

            //StudentName.Clear();
            //foreach (string i in StudentName)
            //{
            //    Console.WriteLine(i + " After clear students");
            //}

            //3.Create a Stack which takes integer values and perform following operations:
            //a.Push() - To Add new item in stack
            //b.Pop() - To Remove item from the stack
            //c.Peek() – To Return the top item from the stack.
            //d.Contains() - To Checks whether an item exists in the stack or not.
            //e.Clear() - To clear items from stack
            //Stack stack = new Stack();
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item + " After pop");
            //}
            //stack.Peek();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item + " Atfer peek");
            //}
            //bool con = stack.Contains(3);
            //stack.Clear();
            //Console.WriteLine("stack is contains 3 = " + con);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Create a Queue which takes integer values and perform following operations:
            //a.Enqueue() - Adds an item into the queue.
            //b.Dequeue() - Returns an item from the beginning of the queue and
            // removes it from the queue.
            //c.Peek() - Returns an first item from the queue without removing it.
            //d.Contains() - Checks whether an item is in the queue or not
            //e.Clear() - Removes all the items from the queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine("After insert elements in queue:");
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //queue.Dequeue();
            //queue.Dequeue();
            //Console.WriteLine("After dequeue 2 elements :");
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //int p = queue.Peek();
            //Console.WriteLine(p + " is on peek");

            //bool isContains = queue.Contains(4);
            //Console.WriteLine(isContains + " is contains 4");

            //queue.Clear();


            //5.Create a Dictionary collection class object and preform following operations:
            //a.Add: Adds a key-value pair.
            //b.Remove: Removes a key-value pair by key.
            //c.ContainsKey: Checks if a key exists in the hashtable.
            //d.ContainsValue: Checks if a value exists in the hashtable.
            //e.Clear: Removes all key-value pairs.
            //Dictionary<int,string> map = new Dictionary<int,string>();
            //map.Add(1, "a1");
            //map.Add(2, "b1");
            //map.Add(3, "c1");
            //map.Add(4, "d1");
            //foreach (var key in map)
            //{
            //    Console.WriteLine(key);
            //}

            //map.Remove(1);
            //Console.WriteLine("After removing 1 key and value :");
            //foreach (var key in map)
            //{
            //    Console.WriteLine(key);
            //}

            //bool isContainsKey = map.ContainsKey(1);
            //Console.WriteLine(isContainsKey + " is Contais 1 key");

            //bool isContainsVal = map.ContainsValue("c1");
            //Console.WriteLine(isContainsVal + " is Contains c1 value");

            //map.Clear();

            //6.Create a Hashtable collection class object and preform following operations:
            //a.Add: Adds a key-value pair.
            //b.Remove: Removes a key-value pair by key.
            //c.ContainsKey: Checks if a key exists in the hashtable.
            //d.ContainsValue: Checks if a value exists in the hashtable.
            //e.Clear: Removes all key-value pairs.
            Hashtable ht = new Hashtable();
            ht.Add("a", 1);
            ht.Add("b", 2);
            ht.Add("c", 3);
            ht.Add("d", 4);
            Console.WriteLine("After adding items:");
            foreach (DictionaryEntry s in ht)
            {
                Console.WriteLine($"Key: {s.Key}, Value: {s.Value}");
            }

            ht.Remove("a");
            Console.WriteLine("After removing a :");
            foreach (DictionaryEntry s in ht)
            {
                Console.WriteLine($"Key: {s.Key}, Value: {s.Value}");
            }

            bool isContainsKey = ht.ContainsKey("a");
            Console.WriteLine(isContainsKey + " is contains \"a\"");

            bool isContainsVal = ht.ContainsValue(2);
            Console.WriteLine(isContainsVal + " is contains 2");

            ht.Clear();
        }
    }
}