using Microsoft.SqlServer.Server;
using System.Configuration;

namespace NDDD.Domain
{
    public class Shared
    {
        // アプリケーション構成ファイルで設定したキー"IsFake"が"1"の時にtrue
        public static bool IsFake { get; } =
            ConfigurationManager.AppSettings["IsFake"] == "1";

        public static string FakePath { get; } =
            ConfigurationManager.AppSettings["FakePath"];

        public static string LoginId { get; set; } = string.Empty;
    }
}
