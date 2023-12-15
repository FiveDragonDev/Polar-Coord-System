using System.Drawing;

namespace Polar_Coord_System
{
    internal class Program
    {
        private const int FrameAmount = 100;
        private const int Width = 12800 / 4;
        private const int Height = 7200 / 4;
        private const int PointsAmount = 10000 / 4;

        private const string FilePath = "Res";

        private static void Main()
        {
            for (int t = 1; t < FrameAmount; t++)
            {
                Canvas canvas = new(Width, Height);
                for (int i = 1; i <= PointsAmount; i++)
                {
                    Point point = new(i, (i * (180 / (float)Math.PI)) + t * 3.6f);
                    canvas.DrawPoint(point, Color.Gold);
                }
                canvas.Save($"{FilePath}/Frame{t}.png");
                Console.WriteLine($"Frame {t} rendered!");
            }

            Console.WriteLine($"The end. Path: {Path.GetFullPath(FilePath)}");
            Console.ReadKey();
        }
    }
}
