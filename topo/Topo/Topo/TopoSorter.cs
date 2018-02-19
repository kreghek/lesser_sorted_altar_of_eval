using System.Collections.Generic;

namespace Topo
{
    public class TopoSorter
    {
        public Node[] Sort(Graph g) {

            var time = 0;

            // Есть в учебнике, но нам не нужно,
            // т.к. выставляемые значения и так являются значениями по умолчанию.
            //foreach (var u in g.V) {
            //    u.Color = NodeColor.White;
            //    u.Pi = null;
            //}

            var result = new List<Node>();

            foreach (var u in g.V)
            {
                if (u.Color == NodeColor.White) {
                    Visit(g, u, result, ref time);
                }
            }

            return result.ToArray();
        }

        private void Visit(Graph g, Node u, List<Node> result, ref int time)
        {
            time++;
            u.D = time;
            u.Color = NodeColor.Gray;

            if (u.Next != null)
            {
                foreach (var v in u.Next)
                {
                    if (v.Color == NodeColor.White)
                    {
                        v.Pi = u;
                        Visit(g, v, result, ref time);
                    }
                }
            }

            u.Color = NodeColor.Black;
            time++;
            u.F = time;
            result.Insert(0, u);
        }
    }
}
