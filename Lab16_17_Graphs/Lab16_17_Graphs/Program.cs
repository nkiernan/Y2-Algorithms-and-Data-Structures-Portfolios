using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_17_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphNode<char> current;  //current location
            GraphNode<char> to;
            Graph<char> myGraph = new Graph<char>();
            List<char> visited = new List<char>();

            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');
            myGraph.AddNode('E');
            myGraph.AddNode('F');
            myGraph.AddNode('G');
            myGraph.AddNode('H');
            myGraph.AddNode('I');
            myGraph.AddNode('J');
            myGraph.AddNode('K');

            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');
            myGraph.AddEdge('B', 'D');
            myGraph.AddEdge('B', 'E');
            myGraph.AddEdge('D', 'H');
            myGraph.AddEdge('E', 'I');
            myGraph.AddEdge('E', 'J');
            myGraph.AddEdge('C', 'F');
            myGraph.AddEdge('C', 'G');
            myGraph.AddEdge('F', 'K');

            current = myGraph.GetNodeByID('A');
            to = myGraph.GetNodeByID('B');

            Console.WriteLine("Is myGraph empty? Answer: {0}", myGraph.IsEmptyGraph());
            Console.WriteLine("Does myGraph contain {0}? Answer: {1}", current.ID, myGraph.ContainsGraph(current));
            Console.WriteLine("Are node {0} and {1} adjacent? Answer: {2}", current.ID, to.ID, myGraph.IsAdjacent(current, to));
            Console.WriteLine("Are node {0} and {1} adjacent? Answer: {2}", to.ID, current.ID, myGraph.IsAdjacent(to, current));

            myGraph.DepthFirstTraverse('A', ref visited);

            Console.Write("\nDepth First: ");
            for (int i = 0; i < visited.Count(); i++)
            {
                Console.Write(visited.ElementAt(i) + " "); //A, B, D, H, E, I, J, C, F, K, G
            }

            visited.Clear();

            myGraph.BreadthFirstTraverse('A', ref visited);

            Console.Write("\nBreadth First: ");
            for (int i = 0; i < visited.Count(); i++)
            {
                Console.Write(visited.ElementAt(i) + " "); //A, B, C, D, E, F, G, H, I, J, K
            }
            Console.ReadKey();
        }
    }
}