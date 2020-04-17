using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace theJosephusProblem
{
    public class TheLastBattle
    {
        public int TheLastManStanding(int NumberOfPeople, int killInterval)
        {
            var range = Enumerable.Range(1, NumberOfPeople);
            var circle = range.ToList();
            var t = killInterval - 1;
            var r = killInterval;
            var finalPerson = 0;
            while (circle.Count > 1)
            {
                var result = circle.Take(t);
                circle.AddRange(result);
                circle.RemoveRange(0, r);
                circle.ForEach(Console.WriteLine);
            }
            foreach (var n in circle)
            {
               finalPerson = n;
            }
            //var lastPerson = Int32.Parse(finalPerson);
            return finalPerson;
        }
    }
}
