using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Tasks
{
    internal class Hotel
    {
        public string Name { get; set; }
        Room[] rooms;
        public Hotel(string name)
        {
            Name = name;
            rooms = new Room[0];
        }
        public void AddRoom(Room room)
        {
            if(CheckRoom(room))
            {
                Console.WriteLine("Artiq bele bir otaq var");
            }
            else
            {

                Array.Resize(ref rooms, rooms.Length + 1);
                rooms[rooms.Length - 1] = room;
            }
        }
        public bool CheckRoom(Room room)
        {
            bool result=false;
            foreach (var item in rooms)
            {
                if(item.Id == room.Id)
                {
                    return true;
                }
            }
            return result;
        }
        public void MakeReservation(string roomId)
        {
            foreach (var item in rooms)
            {
                if(item.Id==roomId &&item.IsAvailable)
                {
                    if(item.IsAvailable)
                    {
                        item.IsAvailable = false;
                        Console.WriteLine("Otaq rezervasya olundu");
                    }
                    else
                    {
                        Console.WriteLine("Otaq doludur");
                    }
                }
                else
                {
                    Console.WriteLine("Bele bir otagimiz yoxdur");
                }
            }
        }

    }
}
