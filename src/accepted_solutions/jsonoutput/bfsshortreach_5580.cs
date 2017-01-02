/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/bfsshortreach
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breadthfirstsearch
{
    class Program
    {

        class node
        {
            public int weight = -1;
            public List<int> edges = new List<int>();
            public bfs bfsData = new bfs();
        }

        class bfs
        {
            public int predecessor = -1;
            public int distance = -1;
        }


        static void Main(string[] args)
        {

            /*********************************************************/
            bool debug = false;
            string inputFile = "input1.txt";
            /*********************************************************/
            List<string> lines = new List<string>();
            int currentLine = 0;
            if (!debug)
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
                //Dictionary<int,bfs> bfsList = new Dictionary<int,bfs>();
                Queue<int> theQ = new Queue<int>();

                for(int i = 0; i < numberNodes; i++)
                {
                    nodes[i] = new node();
                    nodes[i].weight = 6;
                }

                for (int i = 0; i < numberEdges; i++)
                {
                    int[] currentInput = Array.ConvertAll(lines[currentLine++].Split(' '), int.Parse);

                    int left = 0; 
                    int right = 0;

                    left= currentInput[0] - 1;
                    right= currentInput[1] - 1;
                    nodes[right].edges.Add(left);
                    nodes[left].edges.Add(right);
                }


                int sourceNode = Convert.ToInt32(lines[currentLine++])-1;
                nodes[sourceNode].bfsData.distance = 0;
                theQ.Enqueue(sourceNode);

                while (theQ.Count() > 0)
                {
                    int currentIndex = theQ.Dequeue();

                    for (int i = 0; i < nodes[currentIndex].edges.Count(); i++)
                    {
                        int edgeNode = nodes[currentIndex].edges[i];

                        if (nodes[edgeNode].bfsData.distance == -1)
                        {
                            nodes[edgeNode].bfsData.distance = nodes[currentIndex].bfsData.distance + nodes[edgeNode].weight;
                            theQ.Enqueue(edgeNode);
                        }
                    }
                }

                List<string> output = new List<string>();
                for (int i = 0; i < numberNodes; i++)
                {
                    if (nodes[i] != null)
                    {
                        if (nodes[i].bfsData.distance != 0)
                        {
                            output.Add(nodes[i].bfsData.distance.ToString());
                        }
                    }
                    else
                    {
                        output.Add("-1");
                    }
                }


                Console.WriteLine(string.Join(" ", output.ToArray()));


            }
            if (debug)
            {
                Console.ReadKey();
            }
        }
    }
}