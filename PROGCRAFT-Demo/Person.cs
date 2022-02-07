using System.Collections.Generic;

namespace PROGCRAFT_Demo
{
    public class Person
    {
        private string name;
        public string Name;
        public float Money;

        //public List<Item> Inventory = new List<Item> ();

      
        //object initialization
        public List<Item> Inventory = new List<Item>()
        {
            //new Item()
            //{ 
            //    Name = "Toadstool",
            //    Price = 1.29f,
            //    Quantity = 2
        
            //},
            //new Item()
            //{
            //    Name = "Feather",
            //    Description = "Deceptively normal looking feather",
            //    Quantity = 10
            //},
            //new Item()
            //{
            //    Name = "Seaweed",
            //    Quantity = 3
            //}
        
        };




        //toadstool, feather, seaweed, ichor, newt tail, drake blood, frog leg, water, mandrake root, phoenix feather, nector, cuttlefish tentacles, obsidian, paprika, honey, gamer tears, cricket wing, lotus, dragon egg, rose petals

        //potions
        //health, stamina, transformation, flying, love, mana, invisibility, underwater breathing, fire, defense, power up

        //declarative sentence - A player or person Crafts a potion
        public void Craft(Recipe recipe)
        {
            //could return a potion as a new item
            //or could add a potion to inventory

            //what are the steps needed? Could those be separate methods?

        }
       
    }
}