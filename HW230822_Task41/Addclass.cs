using System;

namespace EnterDigits
{
    class InitialSettings : Program41
    {
        public int index;
        public int counter;
        public int counterAll;
        public string[] arrayDigit;
        
        public InitialSettings()
        {
            this.index = new Random().Next(this.numberOfEntersStart, this.numberOfEntersEnd);
            this.counterAll = 0;
            this.counter = 0;
            this.UserEnterDigits();
        }
        public void UserEnterDigits()
        {
            Console.Write("Введите пожалуйста целое число: ");
            string enterUser = Console.ReadLine();
            this.counterAll++;
            Array.Resize(ref this.arrayDigit, this.counterAll);
            this.arrayDigit[this.counterAll - 1] = enterUser;
            if (int.TryParse(enterUser, out int number))
            {
                if (number > 0)
                {
                    this.counter++;
                }

            }
            if ((this.counterAll < this.index) && !(enterUser.ToLower() == "end"))
            {
                this.UserEnterDigits();
            }
            return;

        }

    }
}