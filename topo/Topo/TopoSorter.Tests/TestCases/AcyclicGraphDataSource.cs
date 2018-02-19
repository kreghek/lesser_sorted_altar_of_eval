using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Topo;

namespace TopoSorter.Tests
{
    public class AcyclicGraphDataSource
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(CreateSmallFullConnectedGraph());
                yield return new TestCaseData(CreateBigLineGraph());
                yield return new TestCaseData(CreateGraphWithOutlaws());
                yield return new TestCaseData(CreateGraphWithMultiparents());
                yield return new TestCaseData(CreateDisjointedGraph());
            }

        }


        /// <summary>
        /// Создаёт маленький полностью соединённый граф.
        /// </summary>
        /// <returns>Объект графа.</returns>
        private static Graph CreateSmallFullConnectedGraph()
        {
            var graph = new Graph();

            var node1 = new Node() { Value = "1" };
            var node2 = new Node() { Value = "2" };
            var node3 = new Node() { Value = "3" };
            var node4 = new Node() { Value = "4" };

            node1.Next = new[] { node2, node3 };
            node3.Next = new[] { node4 };

            graph.V = new[] { node1, node2, node3, node4 };

            return graph;
        }

        /// <summary>
        /// Создаёт большой линейный граф (1 -> 2, 2 -> 3...).
        /// </summary>
        /// <returns>Объект графа.</returns>
        private static Graph CreateBigLineGraph()
        {
            var graph = new Graph();

            var nodes = new List<Node>();
            Node lastNode = null;
            for (var i = 1; i <= 100; i++)
            {
                var node = new Node() { Value = i.ToString() };

                if (lastNode != null)
                {
                    lastNode.Next = new[] { node };
                }

                nodes.Add(node);
                lastNode = node;
            }

            graph.V = nodes.ToArray();

            return graph;
        }

        /// <summary>
        /// Создаёт граф с вершинами без потомков.
        /// </summary>
        /// <returns>Объект графа.</returns>
        private static Graph CreateGraphWithOutlaws()
        {
            var graph = new Graph();

            var node1 = new Node() { Value = "1" };
            var node2 = new Node() { Value = "2" };
            var node3 = new Node() { Value = "3" };
            var node4 = new Node() { Value = "4" };
            var outlaw1 = new Node() { Value = "outlaw-1" };
            var outlaw2 = new Node() { Value = "outlaw-2" };

            node1.Next = new[] { node2, node3 };
            node3.Next = new[] { node4 };

            graph.V = new[] { node1, node2, node3, node4, outlaw1, outlaw2 };

            return graph;
        }

        /// <summary>
        /// Создаёт граф, где на одну вершину ссылается несколько родителей.
        /// </summary>
        /// <returns>Объект графа.</returns>
        private static Graph CreateGraphWithMultiparents()
        {
            var graph = new Graph();

            var node1 = new Node() { Value = "1" };
            var node2 = new Node() { Value = "2" };
            var node3 = new Node() { Value = "3" };
            var node4 = new Node() { Value = "4" };
            var godfather = new Node() { Value = "godfather" };

            node1.Next = new[] { node2, node3 };
            node3.Next = new[] { node4 };

            graph.V = new[] { node1, node2, node3, node4, godfather };

            return graph;
        }

        /// <summary>
        /// Создаёт граф, где все вершины изолированы.
        /// </summary>
        /// <returns>Объект графа.</returns>
        private static Graph CreateDisjointedGraph()
        {
            const int count = 100;

            var graph = new Graph() {
                V = new Node[count]
            };

            for (var i = 0; i < count; i++)
            {
                var node = new Node() { Value = (i+1).ToString() };
                graph.V[i] = node;
            }

            return graph;
        }
    }
}
