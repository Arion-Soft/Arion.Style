using System;
using System.Collections.Generic;
using System.Linq;

namespace Arion.Theme.Test.Models
{
    public class EIconsGroup
    {
        public EIconsGroup(IEnumerable<string> kinds)
        {
            if (kinds is null) throw new ArgumentNullException(nameof(kinds));
            var allValues = kinds.ToList();
            if (!allValues.Any()) throw new ArgumentException($"{nameof(kinds)} must contain at least one value");
            Kind = allValues.First();
            Aliases = allValues
                .OrderBy(x => x, StringComparer.InvariantCultureIgnoreCase)
                .ToArray();
        }

        public string Kind { get; }
        public string[] Aliases { get; }
    }
}