/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/dijkstrashortreach
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijktras_search
{
    class Program
    {

        class node
        {
            public List<edge> edges = new List<edge>();
            public dijSearch searchData = new dijSearch();
            public bool visited = false;
            public int nodeId = 0;
        }

        class edge
        {
            public int edgeNumber;
            public int edgeWeight;
        }

        class dijSearch
        {
            public int predecessor = -1;
            public int distance = int.MaxValue;
        }


        static void Main(string[] args)
        {

            /*********************************************************/
            const int DEBUGHIGH = 3;
            const int DEBUGLOW = 2;
            int localdebug = DEBUGLOW;
            bool localinput = false;
            string inputFile = "input2.txt";
            /*********************************************************/
            List<string> lines = new List<string>();
            int currentLine = 0;
            if (!localinput)
            {
                string tmpLine = "";
                int lineIndex = 0;
                while ((tmpLine = Console.ReadLine()) != null)
                {
                    lines.Insert(lineIndex++, tmpLine);
                }
            }
            else
            {
                string[] tmpLines = System.IO.File.ReadAllLines(inputFile);
                lines = new List<string>(tmpLines);
            }
            /*********************************************************/

            int testCases = Convert.ToInt32(lines[currentLine++]);

            for (int x = 0; x < testCases; x++)
            {
                int[] firstInput = Array.ConvertAll(lines[currentLine++].Split(' '), int.Parse);
                int numberNodes = firstInput[0];
                int numberEdges = firstInput[1];
                node[] nodes = new node[numberNodes];
                List<node> theQ = new List<node>();

                for (int i = 0; i < numberNodes; i++)
                {
                    nodes[i] = new node();
                    nodes[i].nodeId = i;
                }

                for (int i = 0; i < numberEdges; i++)
                {
                    int[] currentInput = Array.ConvertAll(lines[currentLine++].Split(' '), int.Parse);
                    bool addEdge = true;
                    edge leftEdge = new edge();
                    edge rightEdge = new edge();
                    leftEdge.edgeNumber = currentInput[0] - 1;
                    leftEdge.edgeWeight = currentInput[2] ;
                    rightEdge.edgeNumber = currentInput[1] - 1;
                    rightEdge.edgeWeight = currentInput[2] ;


                    edge tmpEdge = null;
                    if (nodes[rightEdge.edgeNumber] != null) {
                        tmpEdge=nodes[rightEdge.edgeNumber].edges.Find(item => item.edgeNumber == leftEdge.edgeNumber);
                    }
                   
                    if (nodes[leftEdge.edgeNumber] != null)
                    {
                        tmpEdge = nodes[leftEdge.edgeNumber].edges.Find(item => item.edgeNumber == rightEdge.edgeNumber);
                    }
                    

                    if (tmpEdge != null && tmpEdge.edgeWeight< rightEdge.edgeWeight)
                    {
                            addEdge = false;
                    }

                    if (addEdge)
                    {
                        nodes[rightEdge.edgeNumber].edges.Add(leftEdge);
                        nodes[leftEdge.edgeNumber].edges.Add(rightEdge);
                    }
                }

                int sourceNode = Convert.ToInt32(lines[currentLine++]) - 1;

                nodes[sourceNode].searchData.distance = 0;
                theQ.Add(nodes[sourceNode]);



                while (theQ.Count() > 0)
                {


                    //get vertex with lowest calculated distance
                    node currentNode = theQ.Aggregate((item1,item2)=>item1.searchData.distance<item2.searchData.distance ? item1:item2 );
                    theQ.Remove(currentNode);


                    if (localdebug==DEBUGHIGH)
                    {
                        Console.WriteLine("SHOULD REMOVE: "+ currentNode.nodeId);
                    }
                    

                    for (int i = 0; i < currentNode.edges.Count(); i++)
                    {
                        int edgeNode = currentNode.edges[i].edgeNumber;
                        
                            if (localdebug == DEBUGHIGH)
                            {
                                Console.WriteLine("*******************");
                                Console.WriteLine("current:" + currentNode.nodeId + ", edgeNode:" + edgeNode);
                            }
                            if (nodes[edgeNode].searchData.distance < currentNode.searchData.distance + currentNode.edges[i].edgeWeight)
                            {
                                if (localdebug == DEBUGHIGH)
                                {
                                    Console.WriteLine(nodes[edgeNode].searchData.distance + " < " + (currentNode.searchData.distance + currentNode.edges[i].edgeWeight));
                                }
                            }
                            else
                            {
                                if (localdebug == DEBUGHIGH)
                                {
                                    Console.WriteLine(nodes[edgeNode].searchData.distance + " > " + (currentNode.searchData.distance + currentNode.edges[i].edgeWeight));
                                }

                                nodes[edgeNode].searchData.distance = currentNode.searchData.distance + currentNode.edges[i].edgeWeight;
                            }
                            if (!nodes[edgeNode].visited && !theQ.Contains(nodes[edgeNode]))
                            {
                                theQ.Add(nodes[edgeNode]);
                                if (localdebug == DEBUGHIGH)
                                {
                                    Console.WriteLine("Adding:" + edgeNode);
                                }
                            }
                    }


                    
                    currentNode.visited = true;
                    if (localdebug == DEBUGHIGH)
                    {
                        Console.WriteLine("Visited:" + currentNode.nodeId);
                        Console.ReadKey();
                    }

                }

                List<string> output = new List<string>();
                for (int i = 0; i < numberNodes; i++)
                {
                    if (nodes[i] != null)
                    {
                        if (nodes[i].searchData.distance != 0)
                        {
                            if (nodes[i].searchData.distance == int.MaxValue)
                            {
                                output.Add("-1");
                            }
                            else
                            {
                                output.Add(nodes[i].searchData.distance.ToString());
                            }
                        }
                    }
                    else
                    {
                        output.Add("-1");
                    }
                }
                if (localdebug == DEBUGHIGH)
                {
                    Console.ReadKey();
                }

                Console.WriteLine(string.Join(" ", output.ToArray()));


            }
            if (localdebug >= DEBUGLOW)
            {
                Console.ReadKey();
            }
        }
    }
}
