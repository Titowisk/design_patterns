using System;

namespace Mazes
{
    class Program
    {
        static void Main(string[] args)
        {
            Maze mazeGame = new Maze();
            Room room1 = new Room(1);
            Room room2 = new Room(2);
            Door theDoor = new Door(room1, room2);

            mazeGame.AddRoom(room1);
            mazeGame.AddRoom(room2);

            room1.SetSide("north", new Wall());
            room1.SetSide("east", theDoor);
            room1.SetSide("south", new Wall());
            room1.SetSide("west", new Wall());

            room2.SetSide("north", new Wall());
            room2.SetSide("east", new Wall());
            room2.SetSide("south", new Wall());
            room2.SetSide("west", theDoor);

            Console.WriteLine( String.Format( "Objeto {0}", room1.GetSide("north") ) );
            Console.WriteLine( String.Format( "Objeto {0}", room1.GetSide("east") ) );
            Console.ReadLine();
        }
    }
}
