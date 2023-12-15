using System.Drawing;

namespace Polar_Coord_System
{
    public class Canvas
    {
        private readonly Bitmap _bitmap;
        private readonly Graphics _graphics;
        private readonly int _width;
        private readonly int _height;

        public Canvas(int width, int height)
        {
            _width = width;
            _height = height;
            _bitmap = new(width, height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.Black);
        }

        public void DrawPoint(Point point, Color color)
        {
            float x = _width / 2 + point.Distance * (float)Math.Cos(point.Angle);
            float y = _height / 2 + point.Distance * (float)Math.Sin(point.Angle);
            _graphics.FillEllipse(new SolidBrush(color), x, y, 5, 5);
        }

        public void Save(string fileName) => _bitmap.Save(fileName);
    }
}
