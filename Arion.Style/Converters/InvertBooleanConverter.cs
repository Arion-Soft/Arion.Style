using Arion.Style.Converters;

namespace Arion.Theme.Converters
{
    internal class InvertBooleanConverter : BooleanConverter<bool>
    {
        public InvertBooleanConverter()
            : base(false, true)
        {
        }
    }
}
