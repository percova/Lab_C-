using System;
using System.Security.Cryptography;

namespace PhoneNet
{
    public class Graph
    {
        private int nodeNum;
        private double[,] adjacencyMatrix;

        public Graph(int nodeNum)
        {
            adjacencyMatrix = new double[nodeNum, nodeNum];
            this.nodeNum = nodeNum;
            Random rand = new Random();
            for (int i = 0; i < adjacencyMatrix.Length; i++)
            {
                for (int j = 0; j < adjacencyMatrix.Length; j++)
                {
                    adjacencyMatrix[i, j] = rand.Next();
                }
            }
        }

        public Graph(int nodeNum, double[,] adjacencyMatrix)
        {
            adjacencyMatrix = new double[nodeNum, nodeNum];
            this.nodeNum = nodeNum;
            this.adjacencyMatrix = adjacencyMatrix;
        }

        public void PrimsAlgo()
        {
            int[] nodeSequence = new int[nodeNum];
            double min = 0;

            for (int i = 0; i < nodeNum; i++)
            {
                for (int j = 0; j < nodeNum; j++)
                {
                    if (nodeSequence[j] != i && adjacencyMatrix[i,j] != 0 && adjacencyMatrix[i,j] < min)
                    {
                        min += adjacencyMatrix[i, j];
                        nodeSequence[i] = i + 1;
                    }
                }
            }
            
            Console.Write("1");
            for (int i = 0; i < nodeNum; i++)
            {
                Console.Write("->"  + nodeSequence[i] );
            }
            Console.WriteLine();
            Console.WriteLine(min);
        } 
    }
}