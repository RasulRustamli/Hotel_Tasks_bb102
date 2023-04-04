namespace Hotel_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("AB", 123, 4);
            Room room2 = new Room("AB", 123, 4);
            Hotel hotel = new Hotel("Bdu");
            hotel.AddRoom(room);
            hotel.AddRoom(room2);


        }
    }
}