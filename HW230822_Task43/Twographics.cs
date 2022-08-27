using System;

namespace TwoGraphics
{
    class Program43
    {
        public int graphMinNum = -100;
        public int graphMaxNum = 100;
        public int stepIteration = 10;
        public string[] intiParam = new string[4] {"b1", "k1", "b2", "k2"}; 
        static void Main(string[] args) 
        {
            Console.Clear();
            Console.WriteLine("Задача на построение двух линейных графиков: y = k1 * x + b1.");
            Console.WriteLine("Вам нужно будет ввести k1, b1, k2, b2 для двух линейных графиков.\n");
            InitialSettings initGraph1 = new InitialSettings(0);
            InitialSettings initGraph2 = new InitialSettings(2);
            Console.WriteLine($"Вы ввели b1 {initGraph1.b1}, k1 {initGraph1.k1}");
            Console.WriteLine($"Вы ввели b2 {initGraph2.b1}, k2 {initGraph2.k1}");

            GraphSettig graph1 = new GraphSettig(initGraph1);
            GraphSettig graph2 = new GraphSettig(initGraph2);

            FindCrossing cross = new FindCrossing(graph1, graph2);
        }
    }
}