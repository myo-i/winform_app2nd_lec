using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Logics
{
    public static class MeasureAnalysis
    {
        // 例えば直近値を分析するなどの細かいロジックを追加する場合は
        // staticなクラスとメソッドで定義して分離したほうがわかりやすい時もある
        public static float Execute(
            float value1,
            float value2,
            float value3,
            float value4,
            float value5)
        {
            return 999f;
        }
    }
}
