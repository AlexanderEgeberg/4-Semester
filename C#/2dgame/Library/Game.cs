using System;

namespace GameFramework
{
    public class Game
    {
        //world instnace
        public world game_world;

        //game constructior with world size
        public Game(int width, int height)
        {
            game_world = new world(width, height);
            //snake PG
        }

        //starts the game
        public void Start()
        {

            //initiliaze boolean
            bool gameRunning = true;

            //draw the gameboard
            game_world.PrintPlayground();


            //while gameRunning is true the game will continue to run
            while (gameRunning)
            {
                //Console.WriteLine("Point = " + game_world.Point);

                //Get user input
                InputType movement = ReadNextEvent();


                //Event based on user move, if the playermovement stops the game it will set to false.
                gameRunning = game_world.PlayerAction(movement);

                //if the game is still running, then redraw the board with updated graphics.
                if (gameRunning)
                {
                    //draw world
                    game_world.PrintPlayground();
                }

            }

            Console.WriteLine();
            Console.WriteLine("Game over");

        }



        //Reads user input and returns enum value
        private InputType ReadNextEvent()
        {
            InputType ev = InputType.FORWARD;

            Console.Write("Type next movement 'a,w,s,d' : ");
            bool ok = false;
            while (!ok)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                char c = info.KeyChar;
                switch (c)
                {
                    case 'a':
                        ev = InputType.LEFT;
                        ok = true;
                        break;
                    case 'd':
                        ev = InputType.RIGHT;
                        ok = true;
                        break;
                    case 's':
                        ev = InputType.BACK;
                        ok = true;
                        break;
                    case 'w':
                        ev = InputType.FORWARD;
                        ok = true;
                        break;
                }
            }

            return ev;
        }

    }
}
