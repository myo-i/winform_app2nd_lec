using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Winform.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        IMeasureRepository _measureRepository;
        MeasureEntity _measure;
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
        }
        // Entityが入る
        public string AreaIdText { get; set; }
        public string MeasureDateText { get; set; }
        public string MeasureValueText { get; set; }

        public void Search()
        {
            _measure = _measureRepository.GetLatest();
        }
    }
}
