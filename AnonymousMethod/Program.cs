using System;
using static AnonyomusMethodDemo.Anonyomus;

namespace AnonyomusMethodDemo
{
    public delegate void DelegateSquare(int n);
    class Anonyomus
    {

        internal void Anon(int x)
        {
            DelegateSquare delAnon = delegate (int a)
            {
                Console.Write(x * x);
            };
            delAnon(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Anonyomus anonyomus = new Anonyomus();
            anonyomus.Anon(5);
            Console.ReadKey();
        }
    }
}