using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SethRudesill.IntegerPacker.Tests
{
    [TestClass]
    public class PackerTests
    {
        private UInt16 Left;
        private UInt16 Right;
        private UInt32 Result;

        [TestInitialize]
        public void Setup()
        {
            Left = 9;
            Right = 17;
            Result = Packer.Pack(Left, Right);
        }

        [TestMethod]
        public void Unsigned_32bit_Integer_Stores_Two_16bit_Integers()
        {
            var unpackedLeft = Packer.UnpackLeft(Result);
            var unpackedRight = Packer.UnpackRight(Result);

            Assert.AreEqual(Left, unpackedLeft);
            Assert.AreEqual(Right, unpackedRight);
        }
    }
}
