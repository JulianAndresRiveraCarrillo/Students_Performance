using System.Collections.Generic;

namespace Student_Performance.Model
{
	class Node
	{
        public string Name { get; }

        public string Edge { get; }

        public Attribute NodeAttribute { get; }

        public List<Node> ChildNodes { get; }

        public int TableIndex { get; }

        public bool IsLeaf { get; }

        public Node(string name, int tableIndex, Attribute nodeAttribute, string edge)
        {
            Name = name;
            TableIndex = tableIndex;
            NodeAttribute = nodeAttribute;
            ChildNodes = new List<Node>();
            Edge = edge;
        }

        public Node(bool isleaf, string name, string edge)
        {
            IsLeaf = isleaf;
            Name = name;
            Edge = edge;
        }
    }
}
