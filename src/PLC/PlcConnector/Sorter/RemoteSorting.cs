using System;

namespace Plc
{
    public partial class RemoteSorting
    {
        partial void PexConstructor(Vortex.Connector.IVortexObject _, string _1, string _2)
        {
            Sort.Initialize(SortMethod);
        }

        private void SortMethod()
        {
            var plain = CreatePlainerType();
            FlushOnlineToPlain(plain);
            Array.Sort(plain.MyArray);
            FlushPlainToOnline(plain);
        }
    }
}
