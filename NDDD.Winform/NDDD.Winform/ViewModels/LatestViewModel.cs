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
        public string AreaIdText
        {
            get
            {
                if (_measure == null) return string.Empty;

                // PadLeftで4桁左に0埋め
                return _measure?.AreaId.ToString().PadLeft(4, '0');
            }
        }
        public string MeasureDateText 
        {
            get
            {
                if (_measure == null) return string.Empty;

                return _measure?.MeasureDate.ToString("yyyy/MM/dd HH:mm:ss");
            }
        }
        public string MeasureValueText 
        {
            get 
            {
                if (_measure == null) return string.Empty;
                return Math.Round(_measure.MeasureValue, 2) + "℃"; 
            }
        }

        public void Search()
        {
            _measure = _measureRepository.GetLatest();
        }
    }
}
