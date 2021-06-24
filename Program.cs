using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a user can make multiple delegates in single program
//we can make more than 1 delegate
namespace MultipleDelegates
{
    //3 delegates created
    public delegate void Calc(int a, int b);
    //1 more delegate
    public delegate void Show();
    //1 more delegate
    public delegate void Dis(int n);



    class Program
    {
        //using Show delegate
        //1 method
        public static void Smeth()         //using same signature i.e. delegate had no parameters so method will also have no parameters
        {
            Console.WriteLine("hello");
        }


        //using Calc delegate

        //1 method
        public static void Add(int a, int b)     //make method and delegate have same signature
        {
            int c = a + b;
            Console.WriteLine("{0}", c);
        }

        //using Dis delegate
        //1 method
        public static void Dmeth(int n)         //using same signature i.e. delegate had n as  parameter so method will also have n as parameter
        {
            int s = n * n;
            Console.WriteLine("{0}", s);
        }

        static void Main()
        {
            //make object of Show delegate
            Show ss = new Show(Smeth);
            ss.Invoke(); //calling  


            //make object of Dis delegate
            Dis dd = new Dis(Dmeth);
            dd.Invoke(5);

            Console.ReadLine();
            
        }
    }


}