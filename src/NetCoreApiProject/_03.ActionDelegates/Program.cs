using System;

namespace _03.ActionDelegates
{
    class Program
    {
        //func,action,predicate

        static void Main(string[] args)
        {
            Action action = new Action(SelamVer);
            action.Invoke();

            Action<string> action2 = new Action<string>(SelamVer2);
            action2.Invoke("Ali");

            //2.action delege calistirma sekli
            Action<string> action3 = new Action<string>(obj =>
            {
                Console.WriteLine("Action3 " + obj);
                Console.WriteLine("Action3 " + obj + " Naber");
            });
            action3.Invoke("Ali");

            Action action4 = new Action(() =>
            {
                Console.WriteLine("ali veli");
            });
            action4.Invoke();

            Console.ReadKey();
        }

        private static void SelamVer2(string obj)
        {
            Console.WriteLine(obj + " Selam");
        }

        private static void SelamVer()
        {
            Console.WriteLine("Selam Verdim");
        }
    }
}
