using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FP_PMS.Ex
{
    public static class reportLinqProgress
    {
        public static IEnumerable<T> WithProgressReporting<T>(this IEnumerable<T> sequence, Action<int> reportProgress)
    {
        if (sequence == null) { throw new ArgumentNullException("sequence"); }
     
        // make sure we can find out how many elements are in the sequence
        ICollection<T> collection = sequence as ICollection<T>;
        if (collection == null)
        {
            // buffer the entire sequence
            collection = new List<T>(sequence);
        }
 
        int total = collection.Count;
        return collection.WithProgressReporting(reportProgress);
    }
    }
}
