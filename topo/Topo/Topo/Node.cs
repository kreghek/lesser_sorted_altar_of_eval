namespace Topo
{
    public class Node
    {
        public string Value { get; set; }
        public Node[] Next { get; set; }
        public NodeColor Color { get; set; }
        public Node Pi { get; set; }
        public int D { get; set; }
        public int F { get; set; }
    }
}
