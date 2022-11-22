using NDDD.Domain.Exceptions;
using NDDD.Winform.ViewModels;
using System;
using System.Windows.Forms;

namespace NDDD.Winform.Views
{
    public partial class LatestView : BaseForm
    {
        LatestViewModel _viewModel = new LatestViewModel();
        public LatestView()
        {
            InitializeComponent();

            // １つ目どのプロパティにバインドするか
            // ２つ目バインドする元
            // ３つ目追従する値 "AreaIdText"でもいいがプロパティ名が変わると追従できないためnameofで
            AreaIdTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.AreaIdText));
            MeasureDateTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.MeasureDateText));
            MeasureValueTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.MeasureValueText));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _viewModel.Search();
            }
            catch(Exception ex)
            {
                ExceptionDiv(ex);
            }
        }
    }
}
