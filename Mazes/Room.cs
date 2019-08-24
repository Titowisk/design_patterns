using System;
using System.Collections.Generic;
using System.Text;

namespace Mazes
{
    public class Room : MapSite
    {
        private MapSite[] _sides = new MapSite[4];
        private readonly Dictionary<string, int> DIRECTIONS = new Dictionary<string, int>()
        {
            {"north", 0 },
            {"east", 1 },
            {"south", 2 },
            {"west", 3 }

        };

        public int RoomNumber { get; set; }

        public Room (int roomNo)
        {
            RoomNumber = roomNo;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }

        public void SetSide (string direction, MapSite element)
        {
            _sides[DIRECTIONS[direction.ToLower()]] = element;
        }

        public MapSite GetSide (string direction)
        {
            return _sides[DIRECTIONS[direction.ToLower()]];
        }


    }
}
