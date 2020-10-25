using ProjLib;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace UI.Menus
{
    /// <summary>
    /// welcome menu
    /// </summary>
    public class MainMenu : IMenu
    {
        public void start(){
            string input; //switch statement
            do{
            System.Console.WriteLine("Welcome Customer");
            // options
            System.Console.WriteLine("[0] Place Order");
            System.Console.WriteLine("[1] View Order History");
            System.Console.WriteLine("[3] View Location inv");
            System.Console.WriteLine("[4] Exit");
            input = System.Console.ReadLine();
            switch(input){
                 case "0":
          
                        //heroBL.AddHero(newProduct);
                        //System.Console.WriteLine($"Product {newProduct.Name} was created with a superpower of {Hero.superPowers.Pop()}");
                        GetStuff();
                        break;
                 case "4":
                        System.Console.WriteLine("Goodbye friend.");
                        break;
            }
            }while(!input.Equals("4"));
           

            

        }

    public Product GetStuff(){
            Product Product = new Product();
            System.Console.WriteLine("enter Pillow: ");
            Product.name = System.Console.ReadLine();
            System.Console.WriteLine("Enter to order Pillow");
            Product.Order(System.Console.ReadLine());
            System.Console.WriteLine("Product Ordered");
            return Product;
        }
       
    }
}