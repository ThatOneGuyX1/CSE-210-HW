using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        string x = "";

        while (x.ToLower()!= "quit")
        {
            x = menu.DisplayMenu();
            
            if (x.ToLower() == "breath")
            {
                Breather breath = new Breather();
                breath.SetDescription();
                breath.RunBreather();
            }

            else if (x.ToLower() == "reflect")
            {
                Reflect refelct = new Reflect();
                refelct.SetDescription();
                refelct.RunReflect();

            }

            else if (x.ToLower() == "list")
            {
                Lister list = new Lister();
                list.SetDescription();
                list.RunLister();
                
            }
        }
        
    }
}