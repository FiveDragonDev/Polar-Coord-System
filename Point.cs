namespace Polar_Coord_System
{
    public class Point
    {
        public float Distance { get; private set; }
        public float Angle { get; private set; }

        public Point(float distance, float angle)
        {
            Distance = distance;
            Angle = angle;
        }

        public override string ToString() => $"({Distance}, {Angle} Deg)";
    }
}
