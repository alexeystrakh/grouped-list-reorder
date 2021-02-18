using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms.Internals;

namespace GrouppedListReorder.Helpers
{
    public static class EnumerableHelpers
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
        {
            if (source == null)
                return null;

            var result = new ObservableCollection<T>();
            source.ForEach(result.Add);
            return result;
        }
    }
}