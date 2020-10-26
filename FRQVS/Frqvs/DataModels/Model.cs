using System;
using System.Linq;

namespace Frqvs.DataModels
{
    public class Model
    {
        public override string ToString()
        {
            var properties = GetType().GetProperties();
            return properties.Aggregate(string.Empty,
                (result, next) => result += $"{next.Name}: {next.GetValue(this)} {Environment.NewLine}");
        }
    }
}
