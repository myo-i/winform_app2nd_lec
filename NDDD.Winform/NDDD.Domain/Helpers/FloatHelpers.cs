using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Helpers
{
    public static class FloatHelpers
    {
        // 引数のthisは拡張メソッド
        // RoundString(value, decimalPoint)ではなく、
        // value.RoundString(decimalPoint)で関数を呼び出す
        public static string RoundString(this float value,
            int decimalPoint) 
        {
            // decimalPoint == 3の時、1.2→1.200, 1.23456→1.234となる
            value = Convert.ToSingle(Math.Round(value, decimalPoint));
            return value.ToString(decimalPoint == 0?
                string.Empty : "." + 
                string.Concat(Enumerable.Repeat("0", decimalPoint)));
        }
    }
}
