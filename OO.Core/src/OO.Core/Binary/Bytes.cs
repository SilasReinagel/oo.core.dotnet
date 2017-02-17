using OO.Core.Binary;

namespace OO.Core.Types
{
    public abstract class Bytes : Value<byte[]>
    {
        public static implicit operator Bytes(byte[] bytes)
        {
            return new ByteArray(bytes);
        }
    }
}
