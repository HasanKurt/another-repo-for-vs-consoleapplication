using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPerson = new Person();

            myPerson.sayHello();

            Console.ReadLine();
        }
    }

    public class Person
    {
        /// <summary>
        /// This method write something to the standard output.
        /// </summary>
        public virtual void sayHello() => Console.WriteLine("Hello from Person!");
        //This is a comment, made within new-branch
        // This comment is changed.
        // new try
    }

    public class Developer: Person
    {
        public override void sayHello()
        {
            Console.WriteLine("hello from developer - changes made within new-branch");
        }


    }

    interface IMyInterface
    {
        void sayHello();
    }
}
