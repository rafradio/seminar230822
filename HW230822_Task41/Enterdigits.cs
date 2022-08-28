using System;

namespace EnterDigits
{
    class Program41
    {
        public int numberOfEntersStart = 15;
        public int numberOfEntersEnd = 25;
        static void Main(string[] args) 
        {
            Console.Clear();
            Console.WriteLine("Программа на ввод чисел \nРандомно ограничено количество вводов \nВы можете выйти набрав end");
            InitialSettings init = new InitialSettings();
            Console.Clear();
            Console.WriteLine($"Вы ввели следующее: [{String.Join(", ", init.arrayDigit)}]");
            Console.WriteLine($"Больше нуля вами было введено: {init.counter} чисел");
        }
    }
}