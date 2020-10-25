namespace HerosUI.Menu

<summary>
<s/summary>

public class MainMenu:Menu{
    public void Start(){
        do{
        System.Console.WriteLine("Welcome");
        System.Console.WriteLine("(0)create a hero");
        
        }while(!System.Console.ReadLine().Equals('0'));
        Hero new hero=getHeroDetails();
        System.Console.WriteLine($"Hero{newHero.Name} wascreated with a superpoer of {newHero.SuperPower.Pop()"})
    }

    public Hero GetHerodetails(){
        Hero hero = new Hero();
        System.Console.WriteLine("Enter Hero Name: ");
        hero.Name = System.Console.ReadLine();
        System.Console.WriteLine("Enter super power");
        hero.AddSuperPower(System.Console.ReadLine());
        return hero;
    }
}