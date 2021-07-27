using System;
//using UI;
//using Graph;

namespace lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.Image UImage = new UI.Image();
            Console.WriteLine(UImage.Description);
            Graph.Image GImage = new Graph.Image();
            Console.WriteLine(GImage.Description);

            Equals(2, 4);
        }
    }
}
namespace UI
{
    class Image
    {
        public string Description = "UI.image";
    }
}
namespace Graph
{
    class Image
    {
        public string Description = "Graph.image";
    }
}
