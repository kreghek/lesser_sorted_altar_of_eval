using System;

namespace Geom
{
    public static class SegmentHelper
    {
        /// <summary>
        /// Проверяем пересечение двух отрезков.
        /// </summary>
        /// <param name="s1">Проверяемый отрезок.</param>
        /// <param name="s2">Проверяемый отрезок.</param>
        /// <returns>Возвращает true, если отрезки пересекаются. Иначе - false.</returns>
        public static bool Intersect(Segment s1, Segment s2)
        {
            var d1 = Direction(s2.Start, s2.End, s1.Start);
            var d2 = Direction(s2.Start, s2.End, s1.End);
            var d3 = Direction(s1.Start, s1.End, s2.Start);
            var d4 = Direction(s1.Start, s1.End, s2.End);

            if (((d1 > 0 && d2 < 0) || (d1 < 0 && d2 > 0)) &&
                ((d3 > 0 && d4 < 0) || (d3 < 0 && d4 > 0))) {
                return true;
            }

            if (d1 == 0 && OnSegment(s2.Start, s2.End, s1.Start))
            {
                return true;
            }

            if (d2 == 0 && OnSegment(s2.Start, s2.End, s1.End))
            {
                return true;
            }

            if (d3 == 0 && OnSegment(s1.Start, s1.End, s2.Start))
            {
                return true;
            }

            if (d4 == 0 && OnSegment(s1.Start, s1.End, s2.End))
            {
                return true;
            }

            return false;
        }

        private static float Direction(Vector2 pi, Vector2 pj, Vector2 pk)
        {
            return (pk - pi) * (pj - pi);
        }

        private static bool OnSegment(Vector2 pi, Vector2 pj, Vector2 pk)
        {
            return ((Math.Min(pi.X, pj.X) <= pk.X && pk.X <= Math.Max(pi.X, pj.X)) &&
                (Math.Min(pi.Y, pj.Y) <= pk.Y && pk.Y <= Math.Max(pi.Y, pj.Y)));
        }
    }
}
