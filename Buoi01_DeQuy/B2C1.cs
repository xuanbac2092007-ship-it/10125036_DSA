
namespace BTTH1
{
    static class B2C1
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                string kq = "";

                if (i % 3 == 0)
                    kq += "Fizz";

                if (i % 5 == 0)
                    kq += "Buzz";

                if (kq == "")
                    kq = i.ToString();

                Console.WriteLine(kq);
            }
        }
    }
}
