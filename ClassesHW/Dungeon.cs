using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHW
{
    public class Dungeon
    {
        public Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[3];

            rooms[0] = new Room(new Unit(), new Weapon("sword"));
            rooms[1] = new Room(new Unit("orc"), new Weapon("axe", 5, 50));
            rooms[2] = new Room(new Unit("elf", 10, 60), new Weapon("bow"));
        }

        public void ShowRooms()
        {
            foreach (var room in rooms)
            {
                Console.WriteLine($"Unit of room {room.Unit.Name}");
                Console.WriteLine($"Weapon of room {room.Weapon.Name}");
                Console.WriteLine("—");
            }   
        }
    }
}
