namespace Geom
{
    public class Vector2
    {
        public Vector2() { }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public static Vector2 operator +(Vector2 value1, Vector2 value2)
        {
            var v3 = new Vector2
            {
                X = value1.X + value2.X,
                Y = value1.Y + value2.Y
            };
            return value1;
        }


        public static Vector2 operator -(Vector2 value1, Vector2 value2)
        {
            var v3 = new Vector2
            {
                X = value1.X - value2.X,
                Y = value1.Y - value2.Y
            };
            return value1;
        }


        public static float operator *(Vector2 value1, Vector2 value2)
        {
            return value1.X * value2.Y - value2.X * value1.Y;
        }
    }
}
