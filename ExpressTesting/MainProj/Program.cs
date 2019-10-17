using InteropServicesTest;
using MyGenerics;
using System;

namespace MainProj
{
    public class Program
    {
        enum ToTest { Interop };

        public static void Main()
        {
            ToTest testing = ToTest.Interop;

            switch (testing)
            {
                case ToTest.Interop: run(new InteropTest()); break;
            }

            Console.ReadLine();
        }

        public static void run(ITesting testing) => testing.Test();
    }
}
