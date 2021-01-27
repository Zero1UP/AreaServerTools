using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaServerTools.Extensions
{
    public static class ByteExtensions
    {
        public static List<int> FindPattern (this byte[] buffer,byte[] pattern,int startIndex)
        {
            List<int> positions = new List<int>();
            int i = Array.IndexOf<byte>(buffer, pattern[0], startIndex);
            while (i >= 0 && i <= buffer.Length - pattern.Length)
            {
                byte[] segment = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, i, segment, 0, pattern.Length);
                if (segment.SequenceEqual<byte>(pattern))
                    positions.Add(i);
                i = Array.IndexOf<byte>(buffer, pattern[0], i + 1);
            }
            return positions;
        }

        public static byte[] PatchData (this byte[] sourceData, byte[]data,int startingIndex)
        {

            for (var i = 0; i < sourceData.Length; i++)
            {
                if (i >= data.Length)
                {
                    break;
                }

                sourceData[startingIndex + i] = data[i];
            }

            return sourceData;
        }
    }
}
