using System;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region default constructor
           /* HerosDB obj=new HerosDB();
            Console.WriteLine($"{obj.id}{obj.name}");
            
            #endregion
            #region Paramterized constructor
            HerosDB.obj1=new Hero(2, Marco);
            //Console.WriteLine($"{obj1.id}{obj1.name}"); //cannot access var if they are not public
            Console.WriteLine(obj1.Id); //read property value
            obj1.Id=3;
            Console.Write()
            #endregion
            */
            Hero obj=new Hero();
            /*
            Console.Write("Please enter your heros id: ");
            obj.Id=Int32.ReadLine();
            obj.Name=Console.Write("Please enter your super hero name: ");
            obj.name=Console.Parse(Console.ReadLine());
            Console.Write("Enter the first power: ");
            obj.SuperPowers[0]
            Console.ReadLine();
            Console.Write($"{obj.Id}{obj.Name}{obj.superPowers[0]}");
            */
            obj.ja[0]=new int[2]; //1st column
            obj.ja[1]=new int[3];//2nd column
            obj.ja[2]=new int[1];//3rd column
            obj.ja[0,0]=10;
            obj.ja[1,2]=15;
            Console.Write(obj.ja.Rank); //dimension of the array
            Console.Write(obj.ja.Length); // elements of the array
        }
    }
}


