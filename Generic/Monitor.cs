using System;
using System.Diagnostics;

namespace Generic
{
    public class Monitor
    {
        public static void Show()
        {
            Console.WriteLine("***********Monitor**************");
            {
                int iValue = 123456;
                long commonSecond = 0;
                long objectSecond = 0;
                long genericSecond = 0;

                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 100000000; i++)
                    {
                        ShowInt(iValue);
                    }
                    watch.Stop();
                    commonSecond = watch.ElapsedMilliseconds;
                }

                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 100000000; i++)
                    {
                        ShowOnject(iValue);
                    }
                    watch.Stop();
                    objectSecond = watch.ElapsedMilliseconds;
                }

                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    for (int i = 0; i < 100000000; i++)
                    {
                        Show<int>(iValue);
                    }
                    watch.Stop();
                    genericSecond = watch.ElapsedMilliseconds;
                }

                Console.WriteLine($"commonSecond={commonSecond},objectSecond={objectSecond},genericSecond={genericSecond}");

            }
        }

        private static void ShowInt(int iParameter)
        {
            // do nothing
        }

        private static void ShowOnject(object oParameter)
        {
            // do nothing
        }

        private static void Show<T>(T tParameter)
        {
            // do nothing
        }
    }
}