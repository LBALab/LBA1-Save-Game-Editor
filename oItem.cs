using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBA.Items
{
    class Item
    {
        public const ushort TYPE_BITFLAG = 0;
        public const ushort TYPE_VALUE = 1;
        public string name;
        public uint memoryOffset;
        public ushort maxVal;
        public ushort minVal;
        public short firstObtainableChapter;
        public short mustHaveForChapter;
        public short mustLoseByChapter;
        public ushort size; //Number of bytes needed to store value
        public ushort type;
        public Position position = new Position();
        public ushort lbaVersion; //1 for LBA1, or 2 for LBA2

        public override string ToString()
        {
            return name;
        }
    }

    class Position
    {
        public ushort horizontal;
        public ushort vertical;
        public ushort height;
        public ushort facing;
    }
}
