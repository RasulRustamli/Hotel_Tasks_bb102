using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Tasks
{
    internal class Room
    {
        public string Id{ get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Room(string name,double price,int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            Id = Name.Substring(0, 2) + "102";
        }
        public void ShowInfo()
        {
            Console.WriteLine($"RoomId:{Id} Name:{Name}  Price:{Price} " +
                $"Person:{PersonCapacity}");
        }

    }
}
