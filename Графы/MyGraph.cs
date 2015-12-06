using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Графы
{
    class MyGraph
    {
        private int indexNode;
        private Random r;
        public List<Node> Nodes { get; private set; }
        public MyGraph()
        {
            indexNode = 0;
            Nodes = new List<Node>();
            r = new Random();
        }
        public void InitNodes(List<Node> nodes)
        {
            Nodes = new List<Node>(nodes);
        }
        public void AddNode(Point location)
        {
            Nodes.Add(new Node(indexNode, location));
            indexNode++;
        }
        public void AddEdge(Point? start, Point? end)
        {
            int one = Nodes.FindIndex(x => x.Location == start);
            int two = Nodes.FindIndex(x => x.Location == end);
            int weight = r.Next(1,55);
            Nodes[one].AddEdge(new Edge(Nodes[two], Nodes[one], weight));
            Nodes[two].AddEdge(new Edge(Nodes[one], Nodes[two], weight));
        }
        public void Depth()
        {

        }
    }
    class Node
    {
        public Point Location { get; private set; }
        public Color Color { get; set; }
        public int Key { get; set; }
        public bool Visit { get; set; }
        public List<Edge> edges { get; set; }
        public Node(int key, Point location)
        {
            Color = Color.Yellow;
            edges = new List<Edge>();
            Key = key;
            Location = location;
            Visit = false;
        }
        public void AddEdge(Edge edge)
        {
            edges.Add(edge);
        }
    }
    class Edge
    {
        public Node End { get; set; }
        public Node Start { get; set; }
        public int Weight { get; set; }
        public Color Color { get; set; }
        public bool Draw { get; set; }
        public Edge(Node end, Node start, int weight)
        {
            End = end;
            Start = start;
            Weight = weight;
            Color = System.Drawing.Color.Black;
            Draw = true;
        }
    }
}
