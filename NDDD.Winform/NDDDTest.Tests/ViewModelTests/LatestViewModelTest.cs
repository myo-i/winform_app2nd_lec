using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
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
            var entity = new MeasureEntity(
                1,
                Convert.ToDateTime("2022/12/12 12:34:56"),
                12.341f);
            var measureMock = new Mock<IMeasureRepository>();
            measureMock.Setup(x => x.GetLatest()).Returns(entity);
            var vm = new LatestViewModel(measureMock.Object);
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
