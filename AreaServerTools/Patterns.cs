using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaServerTools
{
    public static class Patterns
    {
        public static byte[] IPAddressSearchPattern = new byte[] {  0x43, 0x54, 0x61, 0x73, 0x6B, 0x47, 0x61, 0x6D, 
                                                                    0x65, 0x43, 0x74, 0x72, 0x6C, 0x00, 0x00, 0x00 };
        public static byte[] TamperCheck1SearchPattern = new byte[] {   0x01, 0x00, 0x00, 0x00, 0xC7, 0x47, 0x2C ,0x01, 
                                                                        0x00, 0x00, 0x00, 0x8B, 0x0D, 0x98 ,0x37, 0x6A,
                                                                        0x00 };

        public static byte[] TamperCheck2SearchPattern = new byte[] {   0xC4, 0x08, 0x33, 0xC0, 0x8B, 0x4C, 0x24, 0x10, 
                                                                        0x8A, 0x14, 0x01, 0x8A, 0x4C, 0x04, 0x74, 0x3A,
                                                                        0xD1 };
    }
}
