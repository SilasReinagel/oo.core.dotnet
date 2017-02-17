using OO.Core.Types;

namespace OO.Core.Binary
{
    internal sealed class ByteArray : Bytes
    {
        private readonly byte[] _bytes;

        public ByteArray(byte[] bytes)
        {
            _bytes = bytes;
        }

        public override byte[] Get()
        {
            return _bytes;
        }
    }
}
