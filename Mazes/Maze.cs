using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mazes
{
    public class Maze
    {
        public List<Room> Rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
       
        public Room GetRoom (int roomNumber)
        {
            return Rooms.Single(r => r.RoomNumber == roomNumber);
        }

    }
}
