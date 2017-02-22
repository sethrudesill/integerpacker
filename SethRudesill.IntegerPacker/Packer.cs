using System;

namespace SethRudesill.IntegerPacker
{
    public static class Packer
    {
        public static UInt32 Pack(UInt16 left, UInt16 right)
        {
            return (UInt32) left << 16 | right;
        }

        public static UInt16 UnpackLeft(UInt32 pack)
        {
            return (UInt16)(pack >> 16);
        }

        public static UInt16 UnpackRight(UInt32 pack)
        {
            return (UInt16)(pack & ((1 << 16) - 1));
        }
    }
}
