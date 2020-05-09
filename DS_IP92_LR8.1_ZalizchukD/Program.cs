using System;
using System.IO;

namespace DS_IP92_LR8._1_ZalizchukD
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "graph.txt";
            Graph graph = new Graph(file);
            
            graph.WeightOutput();
        }
    }

    class Graph
    {
        private int n, m;
        private int[,] weight;
        private int[,] distances;
        private int[,] history;
        private bool dijkstraFlag = true;
        private bool floydFlag = true;

        public Graph(string info)
        {
            StreamReader sr = new StreamReader(info);
            string[] temp;
            string line = sr.ReadLine();
            temp = line.Split(' ');
            n = Convert.ToInt32(temp[0]);
            m = Convert.ToInt32(temp[1]);
            weight = new int[n, n];

            int a, b; // Начальная и конечная вершина ребра
            for (int i = 0; i < m; i++)
            {
                line = sr.ReadLine();
                temp = line.Split(' ');
                a = Convert.ToInt32(temp[0]) - 1;
                b = Convert.ToInt32(temp[1]) - 1;
                weight[a, b] = Convert.ToInt32(temp[2]);
            }

            sr.Close();
        }

        public void WeightOutput()
        {
            for (int i = 0; i < weight.GetLength(0); i++)
            {
                for (int j = 0; j < weight.GetLength(1); j++)
                {
                    Console.Write("{0,4}", weight[i, j]);
                }
                Console.WriteLine();
            }
        }
        
    }
    
}