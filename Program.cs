using Color = System.Drawing.Color;

namespace Polar_Coord_System
{
    internal class Program
    {
        private const int FrameAmount = 500;
        private const int Width = 12800 / 4;
        private const int Height = 7200 / 4;
        private const int PointsAmount = 100000;
        private const int PointsSize = 125;
        private const float RotationAmount = 2;
        private static readonly Color PointsColor = Color.FromArgb(2, 255, 255, 255);

        private const string FilePath = "Res";

        private static void Main()
        {
            for (int t = 1; t < FrameAmount; t++)
            {
                Canvas canvas = new(Width, Height);
                for (int i = 1; i <= PointsAmount; i++)
                {
                    Point point = new(i/4 + t * 5,
                        (i/2 * (180 / (float)Math.PI)) + t * (FrameAmount / 360 * RotationAmount));
                    canvas.DrawPoint(point, PointsColor, PointsSize);
                }
                canvas.Save($"{FilePath}/Frame{t}.png");
                Console.WriteLine($"Frame {t} rendered!");
            }

            Console.WriteLine($"The end. Path: {Path.GetFullPath(FilePath)}");
            Console.ReadKey();
        }
    }
}
