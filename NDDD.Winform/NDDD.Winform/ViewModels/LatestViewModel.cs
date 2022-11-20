using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure;
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
        MeasureRepository _measureRepository;
        //MeasureEntity _measure;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        public LatestViewModel()
            : this(Factories.CreateMeasure())
        {
        }
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = new MeasureRepository(measureRepository);
        }
        // Entityが入る
        public string AreaIdText
        {
            get { return _areaIdText; } 
            set 
            { 
                SetProperty(ref _areaIdText, value);
            }
        }
        public string MeasureDateText 
        {
            get { return _measureDateText; }
            set
            {
                SetProperty(ref _measureDateText, value);
            }
        }
        public string MeasureValueText 
        {
            get { return _measureValueText; }
            set
            {
                SetProperty(ref _measureValueText, value);
            }
        }

        public void Search()
        {
            //_measure = _measureRepository.GetLatest();
            var measure = _measureRepository.GetLatest();
            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.DisplayValue;
            MeasureValueText = measure.MeasureValue.DisplayValue;
            //base.OnPropertyChanged();
        }
    }
}
