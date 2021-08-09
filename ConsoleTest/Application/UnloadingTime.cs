using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class UnloadingTime
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public UnloadingTime(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }
    }

    public static class UnloadingTrucks
    {
        public static bool CanUnloadAll(IEnumerable<UnloadingTime> unloadingTimes)
        {
            var trucksTimeUnload = unloadingTimes.OrderBy(a => a.Start);

            using (var iter = trucksTimeUnload.GetEnumerator())
            {
                UnloadingTime previous = default;

                while (iter.MoveNext())
                {
                    if (previous == null)
                    {
                        previous = iter.Current;
                        continue;
                    }

                    if (iter.Current.Start < previous.End)
                        return false;

                    previous = iter.Current;
                }

            }
            return true;
        }
    }
}
