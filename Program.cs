using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace summary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variable
            int var1 = 24;
            float var2 = 24.544f; // you should end the value with f
            // double var3 = 24.569;

            /*
            char var4 = 'a';
            bool var5 = false;
            string var6 = "fffff";
            */

            // var var7 = 'g';
            // var var8 = 5.55;
            // var var9 = "Hello";

            // const double PI = 3.14;
            // const string myName = "Yahia"; 

            // Printing on Console
            Console.Write("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("var1={0};y={1}",var1,var2); // To display a formatted string

            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}",name);

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old",age);

            // ++x; --x; prefix
            // x++; x--; postfix
            


            // Conditions and Loops

            // if-else statement
            if (var1>3){   // >=, <=, ==, !=
                Console.WriteLine("var1 is bigger than 3 - if-else statement");
            }
            else if(var1==3){
                Console.WriteLine("var1 is equal 3 - if-else statement");
            }
            else{
                Console.WriteLine("var1 is smaller than 3 - if-else statement");
            }

            // switch statement
            switch (var1)
            {
                case 5:
                    Console.WriteLine("var1 equal 5 - switch statement");
                    break;
                case 12:
                    Console.WriteLine("var1 equal 12 - switch statement");
                    break;
                case 24:
                    Console.WriteLine("var1 equal 24 - switch statement");
                    break;
                default:
                    Console.WriteLine("Default Case - switch statement");
                    break;
            }

            // while loop
            while (var1<30)
            {
                 Console.WriteLine("var1 equal {0} - while loop", var1);
                 var1++;
            }

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i equals {0} - for loop",i);
            }

            // do-while loop
            do
            {
                Console.WriteLine("var1 equal {0} - do-while loop", var1);
            } while (var1<30);

            // ? Conditional Operator 
            string msg;
            msg = (age>18)? "Your age is Bigger than 15 - Conditional Operator":"Your age is Smaller than 18 - Conditional Operator";
            Console.WriteLine(msg );



            // Methods 

            /*<return type> name(type1 par1, type2 par2, … , typeN parN)
            {
              List of statements
            }*/

            int Sqr(int x)
            {
                int result = x*x;
                return result;
            }
            Sqr(6);
            Console.WriteLine("{0} - Methods",Sqr(5));

            void SayHi(){   // void for non return methods
                Console.WriteLine("Hi - Method");
            }
            SayHi();

            Print(5); // Accessed directly because of using static word

            Person p1 = new Person();
            Person p2 = new Person();
            p1.SayHi();
            Console.WriteLine("Class Variable accessed directly without an object using static word, count ={0}",Person.count);



            // Arrays

            int [] array1 = new int[]{3,8,9,7,1}; // Declaring an array of integers that holds 5 integers
            int [] array2 = {3,8,9,7,1}; // Declaring an array of integers
            // array2[5]=8; // Wrong, because ARRAYS IN C# DO NOT GROW

            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine(array2[i]);
            }

            foreach (var i in array2)  // Best practice to accesss all elements in array
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();


            int [,] array3 = {{2,3},{5,6},{4,6}}; // Declaring Multidimensional Array (Matrix)

            Console.WriteLine("length of multidimensional array= {0}",array3.Length); // length of multidimensional array equals all the elements
            Console.WriteLine("Dimensions of multidimensional array= {0}",array3.Rank); // Dimensions of multidimensional array using Rank

            Console.WriteLine("Max value= {0}",array2.Max()); // Max value of array
            Console.WriteLine("Min value= {0}",array2.Min()); // Min value of array
            Console.WriteLine("Sum value= {0}",array2.Sum()); // Sum of array values

            foreach (var item in array3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            int [][] jaggedArr = new int[][]{  // Declaring Jagged Array (Array of Arrays)
                new int[]{1,5,8},
                new int[]{5,9},
                new int[]{5,7,8,6}
            };
            Console.WriteLine("jagged array length ={0}",jaggedArr.Length);


            int a = (int)Days.Tue;
            int b = (int)Days.Wed;
            Console.WriteLine("Enums {0}, {1}",a,b);



            // Collections
            // List<T>
            // SortedList<TKey, TValue>
            // Stack<T>
            // Queue<T>
            // Dictionary<TKey, TValue>
            // Hashset<T>
            

            // List<T>
            /*
            - Count - A property that gets the number of elements contained in the list
            - Item[int i] - Gets or sets the element in the list at the index i. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the index value inside the brackets
            - Add(T t) - Adds an element t to the end of the list
            - RemoveAt(int index) - Removes the element at the specified position (index) from the list
            - Sort() - Sorts elements in the list
            - Capacity - A property that gets the number of elements the list can hold before needing to be resized.
            - Clear() - Removes all the elements from the list
            - TrimExcess() - Sets the capacity to the actual number of elements in the list. This is useful when trying to reduce memory overhead
            - AddRange(IEnumerable coll) - Adds the elements of collection coll with elements of the same type as List<T> to the end of the list. IEnumerable is the collections interface that supports simple iteration over the collection
            - Insert(int i, T t) - Inserts an element t at a specific index i in the list
            - InsertRange(int i, IEnumerable coll) - Inserts the elements of a collection coll at a specified index i in the list. IEnumerable is the collections interface that supports simple iteration over the collection
            - Remove(T t) - Removes the first occurrence of the object t from the list
            - RemoveRange(int i, int count) - Removes a specified number of elements count from the list starting at a specified index i
            - Contains(T t) - Returns true if the specified element t is present in the list
            - IndexOf(T t) - Returns the index of the first occurrence of the element t in the list
            - Reverse() - Reverses the order of the elements in the list
            - ToArray() - Copies the elements of the list into a new array 
            */

            List<int> li = new List<int>(); 
            li.Add(5);
            Console.WriteLine("List {0}",li[0]);


            // SortedList<K, V>
            /*
            - Count - Gets the number of key/value pairs contained in the sorted list
            - Item[K key] - Gets or sets the value associated the specified key contained in the sorted list. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the key, value
            - Keys - Gets a sorted and indexed collection containing only the keys in the sorted list
            - Add(K key, V value) - Adds an element with a specific key, value pair into the sorted list
            - Remove(K key) - Removes the element with the specific key, value pair associated with the specified key from the sorted list
            - Values - Gets a sorted and indexed collection of the values in the sorted list
            - Clear() - Removes all the elements from the sorted list
            - ContainsKey(K key) - Returns true when the specified key is present in the sorted list
            - ContainsValue(V value) - Returns true when a specified value is present in the sorted list
            - IndexOfKey(K key) - Returns the index of the specified key within the sorted list
            - IndexOfValue(V value) - Returns the index of the specified value within the sorted list
            */

            SortedList<string, int> pupil = new SortedList<string, int>();
            pupil.Add("Bob", 11);
            pupil.Add("Ann", 9);
            pupil.Add("Mike", 12);
            pupil.Remove("Ann");
            foreach (string s in pupil.Keys){
                Console.WriteLine(s + ": " + pupil[s]);
            }


            // Stack<T>
            /*
            - Count - Returns the number of elements in the stack
            - Peek() - Returns the element at the top of the stack without removing it
            - Pop() - Returns the element at the top of the stack and removes it from the stack
            - Push(T t) - Inserts an element t at the top of the stack
            - Clear() - Removes all the elements from the stack
            - Contains(T t) - Returns true when the element t is present in the stack
            - ToArray() - Copies the stack into a new array
            */

            Stack<int> st = new Stack<int>();
            st.Push(11);
            st.Push(42);
            st.Pop();


            // Queue<T>
            /*
            - Count - Gets the number of elements in the queue
            - Dequeue() - Returns the object at the beginning of the queue and also removes it
            - Enqueue(T t) - Adds the object t to the end of the queue
            - Clear() - Removes all objects from the queue
            - Contains(T t) - Returns true when the element t is present in the queue
            - Peek() - Returns the object at the beginning of the queue without removing it
            - ToArray() - Copies the queue into a new array
            */

            Queue<string> q = new Queue<string>();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            foreach (string s in q){
                Console.Write(s + " ");
            }


            // Dictionary<U, V>
            /*
            - Count - Gets the number of key/value pairs contained in the dictionary
            - Item[K key] - Gets the value associated with the specified key in the dictionary. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and key value
            - Keys - Gets an indexed collection containing only the keys contained in the dictionary
            - Add(K key, V value) - Adds the key, value pair to the dictionary
            - Remove(K key) - Removes the key/value pair related to the specified key from the dictionary
            - Values - Gets an indexed collection containing only the values in the dictionary
            - Clear() - Removes all the key/value pairs from the dictionary
            - ContainsKey(K key) - Returns true if the specified key is present in the dictionary
            - ContainsValue(V value) - Returns true if the specified value is present in the dictionary
            */


            // HashSet<T>
            /*
            - Count - Returns the number of values in the hash set
            - Add(T t) - Adds a value (t) to the hash set
            - IsSubsetOf(ICollection c) - Returns true if the hash set is a subset of the specified collection (c)
            - Remove(T t) - Removes the value (t) from the hash set
            - Clear() - Removes all the elements form the hash set
            - Contains(T t) - Returns true when a value (t) is present in the hash set
            - ToString() - Creates a string from the hash set
            - IsSupersetOf(ICollection c) - Returns true if the hash set is a superset of the specified collection
            - UnionWith(ICollection c) - Applies set union operation on the hash set and the specified collection (c)
            - IntersectWith(ICollection c) - Applies set intersection operation on the hash set and the specified collection (c)
            - ExceptWith(ICollection c) - Applies set difference operation on the hash set and the specified collection (c)
            */



            // Exceptions
            int x, y;
            int result = 0;
            Console.WriteLine("Choose a number");
            x = Convert.ToInt32(Console.Read());
            y = 0;
            
            try {
                result = x / y;
                Console.WriteLine(result);
            }
            // catch (DivideByZeroException e) {    // FileNotFoundException, FormatException, IndexOutOfRangeException, InvalidOperationException, OutOfMemoryException
            //     Console.WriteLine("Cannot divide by 0");
            // }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("finally result = {0}",result);
            }



            // Generics
            static void Swap<T>(ref T a, ref T b) {  // <T> Generics allow the reuse of code across different types
                T temp = a;
                a = b;
                b = temp;
            }
            int first =4, second = 9;
            Swap<int>(ref first, ref second);

            string third= "Hello", fourth="World";
            Swap<string>(ref third, ref fourth);



            // Files
            string str = "Some text";
            File.WriteAllText("test.txt", str);
            string text = File.ReadAllText("test.txt");
            Console.WriteLine(text);

            /*
            - AppendAllText() - appends text to the end of the file.
            - Create() - creates a file in the specified location.
            - Delete() - deletes the specified file.
            - Exists() - determines whether the specified file exists.
            - Copy() - copies a file to a new location.
            - Move() - moves a specified file to a new location
            */
     
        }
        static void Print(int x){   // Adding static word to make it belongs to the classs and accesssed directly
            Console.WriteLine("{0} - Method",x);
        }



        // Enums
        enum Days{Sun, Mon, Tue, Wed=6, Thu, Fri, Sat};
    }



    // Classes
    class Person{
        private int age;  // access modifiers: public, private, protected, internal, protected internal
        private string name;  

        public string Name // property is a member that provides a flexible mechanism to read, write, or compute the value of a private field
        {
            get { return name; } // read
            set { name = value; } // write
        }

        public string Tall { get; set; } // Auto-Implement Property

        public static int count =0;  // Adding static word means that the variable, property, or method belongss to the class itself not to the instances, and can be accessed directly usingf the class name without an object
        public Person(){  // Constructor method has exactly the same name as its class, is public, and does not have any return type
            Console.WriteLine("Class Constructor");
            count++;
        }

        ~Person(){  // Destrctor method has exactly the same name as its class prefixed with ~ 
            Console.WriteLine("Classs Destructor");
        }

        public void SayHi(){
            Console.WriteLine("Hi - Method inside Class");
        }


        // Class Inheritance
        class Animal // Base classs (Parent)
        {
            protected int Legs {get;set;} // protected access modifier can be accessed in the derived classes
            public int Age {get;set;}
        }

        class Dog:Animal // Derived class (Child)
        {
            public Dog(){
                Legs = 4;
            }
            public void Bark(){
                Console.WriteLine("Woof");
            }
        }


        // Polymorphism (Override methods in derived classes)
        class Shape
        {
            public virtual void Draw(){
                Console.WriteLine("Base Draw");
            }
        }

        class Circle:Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Draw");
            }
        }
    }
}
