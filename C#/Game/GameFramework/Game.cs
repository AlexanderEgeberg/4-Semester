using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using GameFramework.Entities;
using GameFramework.Factory.Entities.Creatures;
using GameFramework.Factory.Entities.Decorator;
using GameFramework.Factory.Entities.Objects;

namespace GameFramework
{
    public class Game
    {
        //World instnace
        private IWorld _game_world;
        private IControls _controls;
        private bool _gameRunning;

        private IPlayer _player;
        private static Random rnd = new Random();

        private List<ICreature> _creatures;
        private List<IWorldObject> _objects;
        private List<IKey> _keys;

        //game constructor with World size
        public Game(World world, List<ICreature> creatures, IPlayer player, List<IWorldObject> objects, IControls controls, IObserver deathObserver, List<IKey> keys)
        {

            // Why does setting _player = new archmage of type IPlayer not work
            //IPlayer test = new Archmage(new Position(0, 5), "Alex", "X", 5, 0, 5, player);
            //_player = test;

            //But if I set _player = player which is the exact same but gotten from constructor instead????
            _player = player;
            _game_world = world;
            _creatures = creatures;
            _objects = objects;
            _gameRunning = true;
            _controls = controls;
            _keys = keys;
            AttachObservers(deathObserver);
        }

        void AttachObservers(IObserver observer)
        {
            foreach (var creature in _creatures)
            {
                creature.Attach(observer);
            }
            _player.Attach(observer);
        }

        //starts the game
        public void Start()
        {
            var gameGraphics = new StringBuilder();
            TraceWorker.Write(TraceEventType.Start,1,"Game initial drawing");

            //while gameRunning is true the game will continue to run
            while (_gameRunning)
            {
                //draw the game board
                gameGraphics.Clear();
                _game_world.PrintPlayground(gameGraphics);

                if (_player != null)
                {
                    gameGraphics.Append($"\nHP: {_player.HP} ");
                    gameGraphics.AppendLine();
                }

                gameGraphics.Append("While on top of items press e to acquire it");
                gameGraphics.AppendLine();
                gameGraphics.Append("Type next movement 'a,w,s,d,e' : ");
                //Event based on user move, if the player movement stops the game it will set to false.
                Console.Write(gameGraphics);
                _gameRunning = GameAction(_controls.ReadNextEvent(_keys), gameGraphics);
                Console.WriteLine(_player);
                if (!_player.IsAlive())
                {
                    break;
                }
            }
            Console.WriteLine(_player.HasKey ? "\nYou obtained the key and won!" : "\nYou didn't obtain the key and lost :(");
            Console.WriteLine("Game has ended");
            TraceWorker.Write(TraceEventType.Stop,3, "Game has ended");
        }

        void GetRandomPosition(IWorldObject objWorldObject)
        {
            objWorldObject.Position.Row = rnd.Next(_game_world.MaxWidth);
            objWorldObject.Position.Col = rnd.Next(_game_world.MaxHeight);
        }

        //Takes the user input and creates and action based on the move
        private bool GameAction(InputKey move, StringBuilder sb)
        {

            //Player moves based on input direction
            _player?.Move(move);


            //  is the object that the player is on, if none returns null
            var obj = _objects.Find(x => x.Position.Equals(_player.Position));
            var creature = _creatures.Find(x => x.Position.Equals(_player.Position));

            //checks if player collides with a non passable World object or World walls
            if (obj != null && obj.Block || _player.Position.Col == -1 || _player.Position.Col == _game_world.MaxHeight || _player.Position.Row == -1 || _player.Position.Row == _game_world.MaxWidth)
            {
                //redo move
                switch (move)
                {
                    case InputKey.FORWARD:
                        _player.Move(InputKey.BACK);
                        break;
                    case InputKey.BACK:
                        _player.Move(InputKey.FORWARD);
                        break;
                    case InputKey.LEFT:
                        _player.Move(InputKey.RIGHT);
                        break;
                    case InputKey.RIGHT:
                        _player.Move(InputKey.LEFT);
                        break;
                }
            }
            
            //Return true if the player is on top of any object.
            if (obj != null &&  obj.Position.Equals(_player.Position))
            {
                if (move == InputKey.USE)
                {
                    obj.Use(_player, _objects, GetRandomPosition);
                }

            }


            //Supposedly if the player steps on a world object of the type book, they will be decorated as an Archmage, but doesn't work for some reason.
            //if (obj != null && obj is Book && obj.Position.Equals(_player.Position))
            //{
            //    //_player = new Archmage(new Position(0, 5), "Alex", "X", 5, 0, 5, _player);
            //}

            if (_player.HasKey)
            {
                //TODO decorate player with key make it so you win the game if the player holds the key while on another object
                //ends game
                return false;
            }
            if (creature != null && creature.Position.Equals(_player.Position))
            {
                if (_player.Fight(creature))
                {
                    _creatures.Remove(creature);
                }

            }
            //Returns false if game over
            return true;
        }
    }
}
