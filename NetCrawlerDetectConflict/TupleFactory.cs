using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCrawlerDetectConflict
{
    public static class TupleFactory
    {
        public static (int first, int second) Build()
        {
            var rng = new Random();
            return (rng.Next(), rng.Next());
        }

    }
}
