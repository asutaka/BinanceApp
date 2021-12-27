using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceApp.Common
{
    public static class ExtensionMethod
    {
        public static long DateToInt(this DateTime value)
        {
            return long.Parse(value.ToString("yyyyMMddHHssmm"));
        }
    }
}
