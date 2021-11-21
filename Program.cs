using System;
using System.Linq;

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

            // <return type> name(type1 par1, type2 par2, … , typeN parN)
            // {
            //   List of statements
            // }

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

            Print(5);

            Person p1 = new Person();
            p1.SayHi();


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




            

            }
     

        static void Print(int x){   // Adding static if we are outside the Main method
            Console.WriteLine("{0} - Method",x);
        }
  
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

        public Person(){  // Constructor method has exactly the same name as its class, is public, and does not have any return type
            Console.WriteLine("Class Constructor");
        }

        public void SayHi(){
            Console.WriteLine("Hi - Method inside Class");
        }
    }
}
