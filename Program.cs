using System;
using dotnet_poo_rpg.src.Entities;

namespace dotnet_poo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus",2, "Knight");
            Wizard Jennica = new Wizard("Jennica",23, "White Wizard");

            //Console.WriteLine(Arus.ToString());
            
            Console.WriteLine(Jennica.Attack(4));
            Console.WriteLine(Jennica.Attack(8));
            
        }
    }
}
