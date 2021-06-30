using System;
using System.Collections.Generic;
using System.Text;

namespace CardanoSharpDbSyncDapper.Extensions
{
    public static class ByteExtension
    {
        public static string GetHex(this byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "").ToLower();

        }
    }
}
