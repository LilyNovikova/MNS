using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShN.Utils
{
    public static class Extentions
    {
        public static TSource Do<TSource>(this TSource source, Action<TSource> action)
            where TSource : class
        {
            if (source != default(TSource))
            {
                action(source);
            }
            return source;
        }
    }
}
