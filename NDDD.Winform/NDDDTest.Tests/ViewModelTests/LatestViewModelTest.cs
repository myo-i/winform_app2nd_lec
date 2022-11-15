using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDDD.Winform.ViewModels;
using System;

namespace NDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vm = new LatestViewModel();
            // エリアID
            // 計測日時
            // 計測値

            vm.Search();
            vm.AreaIdText.Is("0001");
            vm.MeasureDateText.Is("2022/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34℃");
        }
    }
}
