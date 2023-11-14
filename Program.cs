using System.Diagnostics;

namespace Tower_Of_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Disks:
            List<int> disks = new List<int>() { 8,7,6,5,4,3,2,1};

            // Initiating towers:
            Stack<int> towerOne = new Stack<int>(); 
            Stack<int> towerTwo = new Stack<int>();
            Stack<int> towerThree = new Stack<int>();

            // Feeding first tower:
            foreach (int i in disks)
            {
                towerOne.Push(i);
            }

            Console.WriteLine("Tower One: " + string.Join(", ", towerOne.ToArray()));


            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Disk operations:
            Methods(towerOne, towerTwo, towerThree);

            Console.WriteLine("Tower Three: " + string.Join(", ", towerThree.ToArray()));
            Console.WriteLine($"Solved for: {sw.ElapsedMilliseconds}ms");
        }

        private static void Methods(Stack<int> towerOne, Stack<int> towerTwo, Stack<int> towerThree)
        {
            FirstToThird(towerOne, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToThird(towerOne, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);
           
            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            ThirdToSecond(towerThree, towerTwo, 0);

            ThirdToFirst(towerThree, towerOne, 0);

            SecondToFirst(towerTwo, towerOne, 0);

            SecondToThird(towerTwo, towerThree, 0);

            FirstToSecond(towerOne, towerTwo, 0);

            FirstToThird(towerOne, towerThree, 0);

            SecondToThird(towerTwo, towerThree, 0);
        }

        private static void ThirdToFirst(Stack<int> towerThree, Stack<int> towerOne, int stop)
        {
            for (int i = 0; i <= towerThree.Count; i++)
            {
                towerOne.Push(towerThree.Pop());
                if (i == stop)
                {
                    //Console.WriteLine("Tower One: " + string.Join(", ", towerOne.ToArray()));
                    break;
                }
            }
        }

        private static void SecondToThird(Stack<int> towerTwo, Stack<int> towerThree, int stop)
        {
            for (int i = 0; i <= towerTwo.Count; i++)
            {
                towerThree.Push(towerTwo.Pop());
                if (i == stop)
                {
                    //Console.WriteLine("Tower Three: " + string.Join(", ", towerThree.ToArray()));
                    break;
                }
            }
        }

        private static void SecondToFirst(Stack<int> towerTwo, Stack<int> towerOne, int stop)
        {
            for (int i = 0; i <= towerTwo.Count; i++)
            {
                towerOne.Push(towerTwo.Pop());
                if (i == stop)
                {
                    //Console.WriteLine("Tower One: " + string.Join(", ", towerOne.ToArray()));
                    break;
                }
            }
        }

        private static void FirstToSecond(Stack<int> towerOne, Stack<int> towerTwo, int stop)
        {
            for (int i = 0; i <= towerOne.Count; i++)
            {
                towerTwo.Push(towerOne.Pop());
                if (i == stop)
                {
                    //Console.WriteLine("Tower Two: " + string.Join(", ", towerTwo.ToArray()));
                    break;
                }
            }
        }

        private static void ThirdToSecond(Stack<int> towerThree, Stack<int> towerTwo, int stop)
        {
            for(int i = 0; i <= towerThree.Count; i++)
            {
                towerTwo.Push(towerThree.Pop());
                if(i == stop)
                {
                    //Console.WriteLine("Tower Two: " + string.Join(", ",towerTwo.ToArray()));
                    break;
                }
            }
        }

        private static void FirstToThird(Stack<int> towerOne, Stack<int> towerThree, int stop)
        {
            for (int i = 0; i <= towerOne.Count; i++)
            {
                towerThree.Push(towerOne.Pop());
                if (i == stop)
                {
                    //Console.WriteLine("Tower Three: " + string.Join(", ", towerThree.ToArray()));
                    break;
                }
            }
        }
    }
}
