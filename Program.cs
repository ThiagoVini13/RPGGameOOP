using System;
using ConsoleApplicationVSCode.scr.entities;

namespace ConsoleApplicationVSCode
{
    class Program{

        static void Main(string[] args)
        {

            Knight arus = new Knight("Arus", 23, "Knight"); //Arus = classe usada no using //Hero - identificador, nome dado a classe no codigo //new Arus(); instância criada para com que o código consgia usar a classe que foi referenciada no using 
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine(wizard.Attack(1));
         }
    }
   
}