////Bài 1
//namespace Sony
//{
//    public class Laptops
//    {
//        public Laptops()
//        {
//            Console.WriteLine("Manufactures Laptops of different configuarations");
//        }
//        public class Player
//        {
//            public Player()
//            {
//                Console.WriteLine("CD as well as DVD players are manufactures");
//            }
//        }
//    }
//}
//namespace Dell
//{
//    class Laptops
//    {
//        static void Main(string[] args)
//        {
//            Sony.Laptops objSonyLaptop = new Sony.Laptops();
//        }
//    }
//}


//bài2
using System;
using Play = Sony.Player.DvdPlayer;

namespace Sony
{
    namespace Player
    {
        class CdPlayer
        {
            public CdPlayer()
            {
                Console.WriteLine("CD-R as well as CD-RW are available");
            }
        }
        public class DvdPlayer
        {
            public DvdPlayer()
            {
                Console.WriteLine("DVD-R as well as DVD-RW are available");
            }
        }
    }
}
namespace Samsung
{
    class Player
    {
        static void Main(string[] args)
        {
            Play objPlayer = new Play();
        }
    }
}