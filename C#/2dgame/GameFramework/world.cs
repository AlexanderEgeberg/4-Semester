using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public class world
    {
        private int maxWidth;
        private int maxHeight;
        private readonly string horizontalLine = "";

        private player _player;

        private Position _item;

        private static Random rnd = new Random();
        private int points = 0;
        


        //constructor creates world
        public world(int width, int height)
        {
            maxWidth = width;
            maxHeight = height;

            //creates HL with length of world width
            for (int i = 0; i < width + 2; i++)
            {
                horizontalLine += "-";
            }

            //Creates player
            _player = new player(width/2,height/2);
            _item = new Position(rnd.Next(0, width), rnd.Next(0, width));
        }



        //Takes the user input and creates and action based on the move
        public bool PlayerAction(InputType move)
        {
            //Player moves based on input direction
            _player.Move(move);

            if (_player.BodyPosistion.Equals(_item))
            {
                points++;
                _item.Row = rnd.Next(maxWidth);
                _item.Col = rnd.Next(maxHeight);
            }


            //Returns false if game over
            return true;
        }

        //draw the gameboard
        public void PrintPlayground()
        {
            //reset
            Console.Clear();
            //game title
            Console.WriteLine($"Points {points} ");
            //draw top line
            Console.WriteLine(horizontalLine);
            //for each row uptill maxHeight start drawing
            for (int r = 0; r < maxHeight; r++)
            {
                
                Console.Write("|");
                //draw the row
                PrintRowString(r);
                Console.WriteLine($"|");
            }
            //draw bottom line
            Console.WriteLine(horizontalLine);
        }

        //Draw row function
        private void PrintRowString(int r)
        {
            //for each Row print the column entity
            for (int c = 0; c < maxWidth; c++)
            {
                //draws entity on row + column position
                PrintColRowChar(r,c);
            }
        }

        private void PrintColRowChar(int row, int col)
        {
            //gets position
            Position p = new Position(row, col);

            if (_player.BodyPosistion.Equals(p))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write('*');
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_item.Equals(p))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write('X');
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                //draw foreground colour
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(' ');
            }
;
        }
    }
}