using System;
namespace OopCatExercise
{
    public abstract class Cat : ICat
	{
        public int AverageHeight { get; private set; }
        public string Setting { get; private set; }
        public bool IsAsleep { get; private set; }
        public Cat(int averageHeight, string setting ) =>
            (AverageHeight, Setting, IsAsleep) = (averageHeight, setting, false);

        public abstract string Eat();

        public void GoToSleep()
        {
            if (!IsAsleep)
            {
                IsAsleep = true;
                Console.WriteLine("Zzzzz...");
            }
        }

        public void WakeUp()
        {
            if (IsAsleep)
            {
                IsAsleep = false;
                Console.WriteLine("Yawn! It's too early for this");
            }
        }



	}
}
