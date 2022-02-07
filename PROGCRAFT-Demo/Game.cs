using static PROGCRAFT_Demo.Utility;
using static System.Console;
using static PROGCRAFT_Demo.Utilities.LoadData;
using System;

namespace PROGCRAFT_Demo
{
    class Game
    {
        string choice;
        int value;
        Person Player = new Person();
        Person shopKeeper = new Person();
        int order = 0;
        public void Run()
        {

            SetUpGame();
            ShowWelcome();
            Pause();
            Print("This is what is in your inventory...");
            Print(ShowAllItemsInList(Player.Inventory));
            //Item redDye = new Item();
            //redDye.Name = "Red Dye";
            //redDye.Price = 3.50f;
            //Print($"{redDye.Name} is {redDye.Price.ToString("c")} per vial.");

            //Utility.Pause();
            Pause();

            Console.WriteLine($"Awesome! {Player.Name}, Lets get crafting! I'll spot ya 10 bucks to get you started!");
            Player.Money = 10;
            Utility.Pause();

            //Begin Trading

            int Amt = shopKeeper.Inventory.Count;


            //Player is presented with a list of items, asked to buy.

            Print("What are ya lookin' for? Type in what you wanna take a look at.");
            Print(LoadTextFromFile("../../data/traderInventory.txt"));
            choice = Console.ReadLine();
            value = Int32.Parse(choice);

            if (shopKeeper.Inventory.Contains(choice))
            {

            }


            
        }
        private void SetUpGame()
        {
            Player.Name = "Anonymous Player";
            Title = "Crafting System Demo";
        }
        private void ShowWelcome()
        {
            Print("What is Your name?");
            Player.Name = Console.ReadLine();
            //interpolation formatting
            Print($"Welcome {Player.Name}");
            //pull in welcome text from external file
            Print(LoadTextFromFile("../../data/welcome.txt"));

            //pull in instructions from external file and show them
            Print(LoadTextFromFile("../../data/instructions.txt"));

            Player.Inventory = LoadLinesFromFile("../../data/items.txt");
            shopKeeper.Inventory = LoadLinesFromFile("../../data/traderInventory.txt");



        }
    }
}
