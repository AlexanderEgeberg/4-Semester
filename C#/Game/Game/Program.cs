using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Channels;
using GameFramework;
using GameFramework.Decorator;
using GameFramework.Entities;
using GameFramework.Enum;
using GameFramework.Factory;
using GameFramework.Factory.Entities.Creatures;
using GameFramework.Factory.Entities.Decorator;
using GameFramework.Factory.Entities.Objects;

namespace GameFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DeathObserver deathObserver = new DeathObserver();

            //parameters game size, read from XML file
            List<int> configDataInt = conf.ReadConfiguration();

                
            //list of creature entites in the game
            List<ICreature> creatures = new List<ICreature>()
            {
                //CreatureFactory.GetCreature(CreatureType.Player, new Position(0,0),50,"Alex","P"),
                //CreatureFactory.GetCreature(CreatureType.Zombie, 2,2 , 10, "Zombie","Z"),
            };

            List<IWorldObject> objects = new List<IWorldObject>()
            {
                WorldObjectFactory.GetWorldObject(WorldObjectType.Food, new Position(0, 5), true, "Sandwich", false, 15, false, "S")
               //WorldObjectFactory.GetWorldObject(WorldObjectType.Food,rnd.Next(0, configDataInt[0]), rnd.Next(0, configDataInt[1]), true, "Apple", true,10,false,"A"),
                //WorldObjectFactory.GetWorldObject(WorldObjectType.Food,rnd.Next(0, configDataInt[0]), rnd.Next(0, configDataInt[1]), true, "Sandwich",false, 15,false, "S"),
            };


            //Create controls
            IControls controls = new Controls();

            //SOLID - O: open for extension, but closed for modification
            //To add more keys you create a new Key class and add it to IKey keys list
            //Extension through keys list
            //controls was quite a simple class and making it SOLID took way more time,
            //but it's much cleaner code if it had been a big class it would probably be easier for future expansion
            List<IKey> keys = new List<IKey>()
            {
                new LeftKey(),
                new RightKey()
            };

            //could add to config
            string[,] grid =
            {
                {"*","*","*","*","#","*","#","*","*","*","*"},
                {"*","*","*","*","#","*","#","*","*","*","*"},
                {"#","#","#","#","#","*","#","*","*","*","*"},
                {"K","*","Z","*","*","*","#","*","*","*","*"},
                {"#","#","#","#","#","*","#","*","*","*","*"},
                {"*","*","*","*","#","*","#","*","*","*","*"},
                {"*","*","*","*","#","*","#","*","*","*","*"},
                {"*","*","*","*","#","*","#","*","*","*","*"},
                {"#","#","#","#","#","*","#","*","*","*","*"},
                {"S","*","*","*","F","*","#","*","*","*","*"},
                {"#","#","#","#","#","B","#","*","*","*","*"},

            };

            void CreateWorld()
            {
                objects.Clear();
                creatures.Clear();

                int rows = grid.GetLength(0);
                int cols = grid.GetLength(1);

                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < cols; x++)
                    {

                        string element = grid[y, x];

                        switch (element)
                        {
                            //case "P":
                            //    creatures.Add(CreatureFactory.GetCreature(CreatureType.Player, new Position(y, x), 1, "Alex", "P"));
                            //    break;
                            case "Z":
                                creatures.Add(CreatureFactory.GetCreature(CreatureType.Zombie, new Position(y, x), 10, "Zombie", "Z",5,0));
                                break;
                            case "#":

                                objects.Add(WorldObjectFactory.GetWorldObject(WorldObjectType.Food, new Position(y, x), false, "Wall", true, 0, true, "#"));
                                break;
                            case "F":

                                objects.Add(WorldObjectFactory.GetWorldObject(WorldObjectType.Wall, new Position(y, x), false, "Wall", true, 0, false, "#"));
                                break;
                            case "S":

                                objects.Add(WorldObjectFactory.GetWorldObject(WorldObjectType.Food, new Position(y, x), true, "Sandwich", false, 15, false, "S"));
                                break;
                            case "B":

                                objects.Add(WorldObjectFactory.GetWorldObject(WorldObjectType.Book, new Position(y, x), true, "Poisoned apple", false, 5, false, element));
                                break;
                            case "K":

                                objects.Add(WorldObjectFactory.GetWorldObject(WorldObjectType.Key, new Position(y, x), true, "Key", false, 0, false, "K"));
                                break;
                            default:
                                //Console.WriteLine($"{t2[0]}{t2[1]}");
                                break;
                        }
                    }

                }
            }

            //start the game
            //StartGame();

           void StartGame()
           {
               CreateWorld();
               IPlayer player = new Mage(new Position(0, 5),"Alex", "H",5,1,10);

               //Why does decorating player as archmage here work fine, but if I do it inside the game it doesn't work?
               player = new Archmage(new Position(0, 5), "Alex", "X", 5, 0, 5, player);

                //create a game with World dimensions, creatures, and items
                World world = new World(configDataInt[0], configDataInt[1], creatures, player, objects);

               Game puzzle = new Game(world, creatures, player, objects, controls,deathObserver,keys);
               puzzle.Start();

               Console.WriteLine("Would you like to try again Y/N");
               var input = Console.ReadLine();
               if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                { 
                    Console.Clear();
                    StartGame();
                }
           }
        }
    }
}
