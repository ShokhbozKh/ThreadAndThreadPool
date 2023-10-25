using System.Diagnostics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // thread va threadpool ni bitta method ustida qancha vaqt ishlaganini tekshirish

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();// sanash boshlanadi
            AtThread();
            stopwatch.Stop();// tuxtatiladi
            Console.WriteLine($"Thread vaqti:{stopwatch.ElapsedTicks}");
            stopwatch.Restart();// bu vaqtni 0 holatga qaytaradi

            Stopwatch stopwatch1 = new Stopwatch();// yangi object ochib qilinsa ham yoki eski objectni reset qilib ishlasa ham buladi
            stopwatch.Start();
            stopwatch1.Start();
            AtThreadPool();
            stopwatch1.Stop();
            stopwatch1.Stop();
            Console.WriteLine($"ThreadPool vaqti:{stopwatch1.ElapsedTicks}");
            Console.WriteLine(stopwatch.ElapsedTicks);

        }
        static void TajribaThread(object t) { }
        static void AtThread()
        {
            Thread thread = new Thread(TajribaThread);
            thread.Start();

        }
        static void AtThreadPool()
        {
            ThreadPool.QueueUserWorkItem(TajribaThread);

        }
       
        
    }
}