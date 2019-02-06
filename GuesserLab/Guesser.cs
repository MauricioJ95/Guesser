using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesserLab
{
    class Guesser
    {
        public string Name { get; set; }
        public int CurrentCount { get; set; }
        public int MaxRandomNum { get; set; }   
        public int TimesRan { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public double Average { get; set; }
        public List<int> Count = new List<int> { };

        public void PrintStats()
        {
            this.Average = (Count.Sum() / TimesRan) * 1.0;
            Console.WriteLine($"{Name} ran {TimesRan} times.");
            Console.WriteLine($"Average: {this.Average}");
            Console.WriteLine($"Min: {this.Min}");
            Console.WriteLine($"Max: {this.Max}");
            Console.WriteLine();
        }
        public void Stats()
        {
            if (CurrentCount < Min)
            {
                Min = CurrentCount;
            }
            if (CurrentCount > Max)
            {
                Max = CurrentCount;
            }
            EachCounts.Add(CurrentCount);
            this.CurrentCount = 0;
        }
    }
}
