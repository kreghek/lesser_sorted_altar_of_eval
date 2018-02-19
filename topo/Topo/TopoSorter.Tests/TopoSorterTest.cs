using NUnit.Framework;
using TopoSorter.Tests;

namespace Topo.Tests
{
    [TestFixture]
    public class TopoSorterTest
    {
        /// <summary>
        /// 1. В системе есть произвольный граф, подлежащий топологической сортировке.
        /// 2. Выполняем сортировку.
        /// 3. Все вершины корректно отсортированы.
        /// </summary>
        [Test]
        [TestCaseSource(typeof(AcyclicGraphDataSource), "TestCases")]
        public void Sort_AnyValidGraph_NodesAreSorted(Graph graph)
        {
            // ARRANGE
            var sorter = new TopoSorter();



            // ACT

            var nodes = sorter.Sort(graph);



            // ASSERT
            for (var i = 0; i < nodes.Length; i++)
            {
                // проверка набора по определению.
                var u = nodes[i];

                if (u.Next != null)
                {
                    foreach (var v in u.Next)
                    {
                        var vInResult = FindNode(v, nodes, i);
                        Assert.IsNull(vInResult, $"Дочерняя вершина '{v.Value}' расположена раньше родительской '{u.Value}'.");
                    }
                }
            }
        }

        private Node FindNode(Node node, Node[] nodes, int finish)
        {
            for (var j = 0; j < finish; j++)
            {
                if (nodes[j] == node)
                    return node;
            }

            return null;
        }
    }
}
