/* using System;

namespace MyApplication
{
       class Car
       {
           string color;
           int maxSpeed;
           public void speed(int givenspeed)
           {
               Console.WriteLine("car is going at speed of " + givenspeed);
           }

           static void Main(string[] args)
           {
               Car myObj = new Car();
               Car myobj2 = new Car();
               myObj.color = "red";
               myObj.maxSpeed = 200;
               myobj2.color = "blue";
               myobj2.maxSpeed = 180;

               Console.WriteLine(myObj.color);
               Console.WriteLine(myObj.maxSpeed);
               Console.WriteLine(myobj2.color);
               Console.WriteLine(myobj2.maxSpeed);
               myobj2.speed(120);
           }
       } */

/* class Person
 {
     private string name; // field
     public string Name   // property
     {
         get { return name; }
         set { name = value; }
     }
 }

 class Program
 {
     static void Main(string[] args)
     {
         Person myObj = new Person();
         myObj.Name = "Liam";
         Console.WriteLine(myObj.Name);
     }
 }*/

/*    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
*/


/*    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}*/

// Abstract class
/*    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }
    }
}
*/

/*//overloading and overriding
 * using System;

namespace MyApplication
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape created with default constructor.");
        }
        public Shape(string name)
        {
            Console.WriteLine($"Shape created with name: {name}");
        }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
        public void Draw(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Drawing a shape.");
            }
        }
    }
    class Circle : Shape
    {
        public Circle() : base()
        {
            Console.WriteLine("Circle created with default constructor.");
        }
        public Circle(string color) : base("Circle")
        {
            Console.WriteLine($"Circle created with color: {color}");
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
        public static Circle operator +(Circle c1, Circle c2)
        {
            Console.WriteLine("Combining two circles.");
            return new Circle();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape();
            Shape shape2 = new Shape("Rectangle");
            Circle circle1 = new Circle();
            Circle circle2 = new Circle("Red");
            shape1.Draw();
            shape1.Draw(3);
            circle1.Draw();
            Circle combinedCircle = circle1 + circle2;
        }
    }
}*/


/*//stack
  using System;
using System.Collections.Generic;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {
                int topElement = stack.Pop();
                Console.WriteLine(topElement);
            }
        }
    }
}*/

/*//circular queue
 * using System;
using System.Collections.Generic;

public class CircularQueue
{

    private int size, front, rear;

    private List<int> queue = new List<int>();

    CircularQueue(int size)
    {
        this.size = size;
        this.front = this.rear = -1;
    }

    public void enQueue(int data)
    {

        if ((front == 0 && rear == size - 1) ||
        (rear == (front - 1) % (size - 1)))
        {
            Console.Write("Queue is Full");
        }

        else if (front == -1)
        {
            front = 0;
            rear = 0;
            queue.Add(data);
        }

        else if (rear == size - 1 && front != 0)
        {
            rear = 0;
            queue[rear] = data;
        }

        else
        {
            rear = (rear + 1);

            if (front <= rear)
            {
                queue.Add(data);
            }

            else
            {
                queue[rear] = data;
            }
        }
    }

    public int deQueue()
    {
        int temp;

        if (front == -1)
        {
            Console.Write("Queue is Empty");

            return -1;
        }

        temp = queue[front];

        if (front == rear)
        {
            front = -1;
            rear = -1;
        }

        else if (front == size - 1)
        {
            front = 0;
        }
        else
        {
            front = front + 1;
        }

        return temp;
    }

    public void displayQueue()
    {

        if (front == -1)
        {
            Console.Write("Queue is Empty");
            return;
        }

        Console.Write("Elements in the circular queue are: ");

        if (rear >= front)
        {

            for (int i = front; i <= rear; i++)
            {
                Console.Write(queue[i]);
                Console.Write(" ");
            }
            Console.Write("\n");
        }

        else
        {

            for (int i = front; i < size; i++)
            {
                Console.Write(queue[i]);
                Console.Write(" ");
            }

            for (int i = 0; i <= rear; i++)
            {
                Console.Write(queue[i]);
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
    static public void Main()
    {
        CircularQueue q = new CircularQueue(5);
        q.enQueue(14);
        q.enQueue(22);
        q.enQueue(13);
        q.enQueue(-6);

        q.displayQueue();

        int x = q.deQueue();

        if (x != -1)
        {
            Console.Write("Deleted value = ");
            Console.Write(x + "\n");
        }

        x = q.deQueue();

        if (x != -1)
        {
            Console.Write("Deleted value = ");
            Console.Write(x + "\n");
        }

        q.displayQueue();

        q.enQueue(9);
        q.enQueue(20);
        q.enQueue(5);

        q.displayQueue();

        q.enQueue(20);
    }
}*/

/*// prirority queue
 using System;

public class item
{
    public int value;
    public int priority;
};
public class GFG
{

    static item[] pr = new item[10];

    static int size = -1;
    static void enqueue(int value, int priority)
    {
        size++;

        pr[size] = new item();
        pr[size].value = value;
        pr[size].priority = priority;
    }

    static int peek()
    {
        int highestPriority = int.MinValue;
        int ind = -1;

        for (int i = 0; i <= size; i++)
        {

            if (highestPriority == pr[i].priority && ind > -1
                && pr[ind].value < pr[i].value)
            {
                highestPriority = pr[i].priority;
                ind = i;
            }
            else if (highestPriority < pr[i].priority)
            {
                highestPriority = pr[i].priority;
                ind = i;
            }
        }

        return ind;
    }

    static void dequeue()
    {
        int ind = peek();

        for (int i = ind; i < size; i++)
        {
            pr[i] = pr[i + 1];
        }

        size--;
    }

    public static void Main(string[] args)
    {
        enqueue(10, 2);
        enqueue(14, 4);
        enqueue(16, 4);
        enqueue(12, 3);

        int ind = peek();

        Console.WriteLine(pr[ind].value);

        dequeue();

        ind = peek();
        Console.WriteLine(pr[ind].value);

        dequeue();

        ind = peek();
        Console.WriteLine(pr[ind].value);
    }
}*/

/*// prepend append
  using System;
using System.Linq;
namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            // Prepend a new element
            int[] prependedArray = arr.Prepend(0).ToArray();

            // Append a new element
            int[] appendedArray = arr.Append(4).ToArray();

            // Output the results
            Console.WriteLine("Prepend result:");
            Console.WriteLine(string.Join(", ", prependedArray));

            Console.WriteLine("Append result:");
            Console.WriteLine(string.Join(", ", appendedArray));
        }
    }
}*/


/* //enquedeque pushpop
using System;
namespace Queueue
{
   public class Enqdeq
    {
        public int[] arr;
        public int top;
        public int rear;

       public Enqdeq(int x) { 
            arr = new int[x];
            top = 0;
            rear = -1;
        }
        public void Enque(int v)
        {
            rear++;
            arr[rear] = v;
        }
        public int Deque()
        {
            int value = arr[top];   
            top++;
            return value;
        }

    }
    public class pushpop
    {
        public int[] arr1;
        public int top;

        public pushpop(int x)
        {
            arr1 = new int[x];
            top = -1;
        }
        public void Push(int val)
        {
            top++;
            arr1[top] = val;
        }
        public int Pop()
        {
            int value = arr1[top];
            top--;
            return value;
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            var queue = new Enqdeq(4);
            queue.Enque(1);
            queue.Enque(2); 
            queue.Enque(3);
            queue.Enque(6);
            foreach (var i in queue.arr)
            {
                Console.WriteLine(i);
            }

            int dequeval = queue.Deque();
            Console.WriteLine("dequed value " + dequeval);
            dequeval = queue.Deque();
            Console.WriteLine("dequed value " + dequeval);
            dequeval = queue.Deque();
            Console.WriteLine("dequed value " + dequeval);
            dequeval = queue.Deque();
            Console.WriteLine("dequed value " + dequeval);

            var stack = new pushpop(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            foreach (var i in stack.arr1)
            {
                Console.WriteLine(i);
            }
            int popvalue = stack.Pop();
            Console.WriteLine("poped value: " + popvalue);
            popvalue = stack.Pop();
            Console.WriteLine("poped value: " + popvalue);
        }
    }
}
*/


/* //linked list
 using System;
using System.Collections.Generic;

class GFG
{

    static public void Main()
    {

        LinkedList<String> my_list = new LinkedList<String>();

        my_list.AddLast("Zoya");
        my_list.AddLast("Shilpa");
        my_list.AddLast("Rohit");
        my_list.AddLast("Rohan");
        my_list.AddLast("Juhi");
        my_list.AddLast("Zoya");

        Console.WriteLine("Best students of XYZ " +
                        "university initially:");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Best students of XYZ" +
                        " university in 2000:");

        my_list.Remove(my_list.First);

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Best students of XYZ" +
                        " university in 2001:");

        my_list.Remove("Rohit");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        my_list.Clear();
        Console.WriteLine("Number of students: {0}",
                                    my_list.Count);
    }
}*/


/* //hashset
using System;
using System.Collections.Generic;
class GFG
{

    static public void Main()
    {

        HashSet<string> myhash1 = new HashSet<string>();


        myhash1.Add("C");
        myhash1.Add("C++");
        myhash1.Add("C#");
        myhash1.Add("Java");
        myhash1.Add("Ruby");
        Console.WriteLine("Elements of myhash1:");

        foreach (var val in myhash1)
        {
            Console.WriteLine(val);
        }
        HashSet<int> myhash2 = new HashSet<int>() {10,
                            100,1000,10000,100000,100,10};

        // Display elements of myhash2
        Console.WriteLine("Elements of myhash2:");
        foreach (var value in myhash2)
        {
            Console.WriteLine(value);
        }
    }
}*/


/*// array vs arraylist vs list
using System;
using System.Collections;
using System.Collections.Generic;
class arraylist
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 }; //array

        Console.WriteLine("printing array");
        foreach(int i in arr)
{
            Console.WriteLine(i);
        }
        ArrayList arrayList = new ArrayList(); // arraylist
        arrayList.Add(5);
        arrayList.Add(4);
        arrayList.Add("Taha");
        arrayList.Add("F@st");
        arrayList.Add(1);
        Console.WriteLine("printing arrayList");
        foreach (var arrl in arrayList)
        {
            Console.WriteLine(arrl); 
        }
        List<int> newlist = new List<int>();
        newlist.Add(7);
        newlist.Add(8);
        newlist.Add(9);
        int capacity = newlist.Count;
        Console.WriteLine("printing list with capacity: " + capacity);
        foreach (int j in newlist)
        {
            Console.WriteLine(j);
        }
    }
}*/

/*//Sorting algorithms
using System;
class Sortings
{
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
            n--; 
        } while (swapped);
    }
    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    static void MergeSort(int[] array)
    {
        if (array.Length < 2)
            return;

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, right.Length);

        MergeSort(left);
        MergeSort(right);

        Merge(array, left, right);
    }

    static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                array[k++] = left[i++];
            else
                array[k++] = right[j++];
        }

        while (i < left.Length)
            array[k++] = left[i++];

        while (j < right.Length)
            array[k++] = right[j++];
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1;
    }
    static void CountingSort(int[] array)
    {
        if (array.Length == 0)
            return;
        int max = array[0];
        int min = array[0];
        foreach (int num in array)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[array.Length];

        foreach (int num in array)
        {
            count[num - min]++;
        }
        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            while (count[i] > 0)
            {
                output[index++] = i + min;
                count[i]--;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = output[i];
        }
    }


    public static void Main()
    {
        int[] array = { 7, 4, 1, 5, 3 };
        BubbleSort(array);
        Console.WriteLine("sorting array by bubble sort: ");
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
        int[] array2 = { 7, 4, 1, 5, 3 };
        InsertionSort(array2);
        Console.WriteLine("sorting array by insertion sort: ");
        foreach (int i in array2)
        {
            Console.WriteLine(i);
        }
        int[] array3 = { 7, 4, 1, 5, 3 };
        MergeSort(array3);
        Console.WriteLine("sorting array by Merge sort: ");
        foreach (int i in array3)
        {
            Console.WriteLine(i);
        }
        int[] array4 = { 7, 4, 1, 5, 3 };
        QuickSort(array4, 0, (array4.Length - 1));
        Console.WriteLine("sorting array by Quick sort: ");
        foreach (int i in array4)
        {
            Console.WriteLine(i);
        }
        int[] array5 = { 7, 4, 1, 5, 3 };
        CountingSort(array5);
        Console.WriteLine("sorting array by Counting sort: ");
        foreach (int i in array5)
        {
            Console.WriteLine(i);
        }
    }

}*/

/* // searching algorithms
using System;

class Sorting
{
    public static int Linearsearch(int[] arr, int key)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == key)
            {
                return i; 
            }
        }
        return -1; 
    }
    static int BinarySearch(int[] arr, int x)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == x)
                return mid;

            if (arr[mid] < x)
                low = mid + 1;

            else
                high = mid - 1;
        }

        return -1;
    }
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int result = Linearsearch(arr, 7);
        if (result == -1)
        {
            Console.WriteLine("Searched key is not present in the array");
        }
        else
        {
            Console.WriteLine("by linear searching algorithm, Searched element is present at index: " + result);
        }
        result =BinarySearch(arr, 7);
        if (result == -1)
        {
            Console.WriteLine("Searched key is not present in the array");
        }
        else
        {
            Console.WriteLine("by binary searching algorithm, Searched element is present at index: " + result);
        }
    }
}*/

/*//linked list implementation custom functions
using System;
class Linkedlistnode
{
    public int Data { get; set; }
    public Linkedlistnode next { get; set; }
    public Linkedlistnode(int x)
    {
        Data = x;
        next = null;
    }
}
class Linkedlist
{
    public Linkedlistnode head;

    public void Insertstart(int data)
    {
        Linkedlistnode newnode = new Linkedlistnode(data);
        newnode.next = head;
        head = newnode;
    }
    public void insertend(int data)
    {
        Linkedlistnode newnode = new Linkedlistnode(data);
        if (head == null)
        {
            head = newnode;
            return;
        }
        Linkedlistnode current = head;
        while (current.next != null)
        {
            current = current.next;
        }
        current.next = newnode;
    }
    public void Deletenode(int key)
    {
        Linkedlistnode current = head;
        Linkedlistnode previous = null;
        if (current != null && current.Data == key)
        {
            head = current.next;
            
        }
        while(current != null && current.Data != key)
        {
            previous = current;
            current = current.next;
        }
        if (current == null)
        {
            Console.WriteLine("Node not found to be deleted.");
            return;
        }
        previous.next = current.next;
    }
    public bool Searchnode(int key)
    {
        Linkedlistnode current = head;
        while (current != null)
        {
            if(current.Data == key)
            {
                return true;
            }
            current = current.next;
        }
        return false;
    }
    public void Displaynode()
    {
        Linkedlistnode current = head;

        Console.WriteLine("displaying linklist");
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}
class mainprogram
{
    static void Main(string[] args)
    {
        Linkedlist list = new Linkedlist();
        list.Insertstart(5);
        list.insertend(6); 
        list.insertend(7);
        list.Insertstart(4);
        list.Displaynode();
        list.Deletenode(6);
        list.Displaynode();
        bool found = list.Searchnode(4);
        Console.WriteLine("Is 30 in the list? " + (found ? "Yes" : "No"));
    }
}*/

/*//Dictionary implementation using custom functions
using System;
using System.Collections.Generic;
class Dictionary<TKey, TValue>
{
    private class Node
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
    private List<Node> nodes;
    public Dictionary()
    {
        nodes = new List<Node>();
    }
    public void Add(TKey key, TValue value)
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            if (nodes[i].Key.Equals(key))
            {
                nodes[i].Value = value;
                return;
            }
        }
        nodes.Add(new Node(key, value));
    }
    public bool Remove(TKey key)
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            if (nodes[i].Key.Equals(key))
            {
                nodes.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
    public bool ContainsKey(TKey key)
    {
        foreach (var node in nodes)
        {
            if (node.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }
    public TValue GetValue(TKey key)
    {
        foreach (var node in nodes)
        {
            if (node.Key.Equals(key))
            {
                return node.Value;
            }
        }
        throw new KeyNotFoundException("Key not found.");
    }
    public void Display()
    {
        foreach (var node in nodes)
        {
            Console.WriteLine($"{node.Key}: {node.Value}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("taha", 22);
        dict.Add("ahmed", 25);
        dict.Add("ali", 31);
        dict.Add("Charlie", 35);
        Console.WriteLine("Dictionary contents:");
        dict.Display();
        dict.Add("taha", 31);
        Console.WriteLine("After updating taha's age:");
        dict.Display();
        bool containsali = dict.ContainsKey("ali");
        Console.WriteLine("Contains key 'ali': " + (containsali ? "Yes" : "No"));
        try
        {
            int value = dict.GetValue("ahmed");
            Console.WriteLine("ahmed's age: " + value);
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        bool removed = dict.Remove("Charlie");
        Console.WriteLine("Removed Charlie: " + (removed ? "Yes" : "No"));
        Console.WriteLine("After removing Charlie:");
        dict.Display();
    }
}
*/

