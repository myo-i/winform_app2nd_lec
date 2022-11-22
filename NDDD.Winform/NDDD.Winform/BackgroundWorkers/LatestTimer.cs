using NDDD.Domain.StaticValues;
using NDDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NDDD.Winform.BackgroundWorkers
{
    internal static class LatestTimer
    {
        // 別スレッドで動かすためにSystem.Threadingでインポート
        private static Timer _timer;

        private static bool _isWork = false;

        // Startで設定した第二引数ごとに呼び出される
        static LatestTimer()
        {
            _timer = new Timer(Callback);
        }

        // タイマーの開始
        internal static void Start()
        {
            // 0秒後から10秒間隔
            _timer.Change(0, 10000);
        }

        // タイマーの停止
        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        // Callbackとはタイマーが動いたときに行う処理
        private static void Callback(object o)
        {
            // 次から次へと処理が来ないようにタイマーを止める
            //_timer.Change(Timeout.Infinite, Timeout.Infinite);

            // _isWorkがtrueの場合は処理を止め、次から次へと処理が来ないようにする
            if (_isWork)
            {
                return;
            }

            try
            {
                _isWork = true;
                // 処理
                Measures.Create(Factories.CreateMeasure());
            }
            finally
            {
                // 止めたタイマーを再度実行
                //_timer.Change(10000, 10000);
                _isWork= false;
            }

        }
    }
}
