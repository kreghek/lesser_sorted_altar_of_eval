﻿namespace Geom
{
    public class Segment
    {
        public Vector2 Start { get; set; }
        public Vector2 End { get; set; }

        public Segment(float x1, float y1, float x2, float y2)
        {
            Start = new Vector2(x1, y1);
            End = new Vector2(x2, y2);
        }
    }
}
