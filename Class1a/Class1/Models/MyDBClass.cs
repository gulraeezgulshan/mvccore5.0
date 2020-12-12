using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1a.Models
{
    public class MyDBClass<T,P>
    {
        public T prop1 { get; set; }
        public P prop2 { get; set; }


        //public string prop1_string {get

    }

    public class NewClass
    {
        MyDBClass<string, int> obj1 = new MyDBClass<string, int>();
        MyDBClass<string, string> obj2 = new MyDBClass<string, string>();
        MyDBClass<int, int> obj3 = new MyDBClass<int, int>();

        public NewClass()
        {
            obj1.prop1 = "A";
            obj3.prop1 = 1;
        }

        public void myMethod()
        {
            B obj = new B(5);
        }
        
    }


    public class A
    {
        int val1;
        public A(int a)
        {
            this.val1 = a;
        }

    }

    public class B: A
    {
        public B(int a) : base(a)
        {

        }

    }

   
}
