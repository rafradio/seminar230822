using System;

namespace TwoGraphics
{
    class InitialSettings : Program43
    {
        public int index;
        public double k1;
        public double b1;
        public int arrayIndex;

        public InitialSettings(int arrayIndex)
        {
            this.index = 0;
            this.arrayIndex = arrayIndex;
            this.InitEntering();
        }
        public void InitEntering()
        {
            Console.Write($"Введите пожалуйста {this.intiParam[this.arrayIndex]} (только число!): ");
            string enterUser = Console.ReadLine();
            if (Double.TryParse(enterUser, out double number))
            {
                switch (this.index)
                {
                    case 0:
                        this.b1 = number;
                        break;
                    case 1:
                        this.k1 = number;
                        break;
                }
                this.index++;
                this.arrayIndex++;
            }
            else
            {
                Console.WriteLine("Вы ввели не число! Пропробуте еще раз!");
            }
            if (this.index < 2) this.InitEntering();
            return;
        }
    }
    class GraphSettig : Program43
    {
        public double[,] arrayXY;
        public GraphSettig(InitialSettings settings)
        {
            this.arrayXY = new double[this.graphMaxNum - this.graphMinNum + 1, 2];
            this.GraphCreating(settings);
        }
        public void GraphCreating(InitialSettings settings)
        {
            for (int i = 0; i < this.arrayXY.GetLength(0); i++)
            {
                this.arrayXY[i, 0] = this.graphMinNum + i;
                this.arrayXY[i, 1] = this.arrayXY[i, 0] * settings.k1 + settings.b1;

            }
            return;

        }
    }
    class FindCrossing : Program43
    {
        public FindCrossing(GraphSettig graphFind1, GraphSettig graphFind2)
        {
            this.DoesItCross(graphFind1, graphFind2);
        }
        public void DoesItCross(GraphSettig graphFind1, GraphSettig graphFind2)
        {
            int length1 = graphFind1.arrayXY.GetLength(0) - 1;
            int length2 = graphFind2.arrayXY.GetLength(0) - 1;
            bool haveCross = false;
            
            if ((graphFind1.arrayXY[0, 1] - graphFind2.arrayXY[0, 1]) > 0 
                    && (graphFind1.arrayXY[length1, 1] - graphFind2.arrayXY[length2, 1]) < 0) haveCross = true;
            if ((graphFind1.arrayXY[0, 1] - graphFind2.arrayXY[0, 1]) < 0 
                    && (graphFind1.arrayXY[length1, 1] - graphFind2.arrayXY[length2, 1]) > 0) haveCross = true;
            if (haveCross) Console.WriteLine("Графики пересекаются");
            else Console.WriteLine("Графики не пересекаются");
        }

    }
}