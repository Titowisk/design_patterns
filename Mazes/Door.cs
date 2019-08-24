using System;
using System.Collections.Generic;
using System.Text;

namespace Mazes
{
    public class Door : MapSite
    {
        private Room Room1 { get; set; }
        private Room Room2 { get; set; }
        private bool IsOpen { get; set; }

        public Door(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
