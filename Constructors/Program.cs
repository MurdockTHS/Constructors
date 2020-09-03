using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human("Sissy", "Wagner", "blue", 23);
            sissy.IntroduceMyself();

            Human angel = new Human("Angel", "Acosta", "brown", 23);
            angel.IntroduceMyself();
        }
    }
}
