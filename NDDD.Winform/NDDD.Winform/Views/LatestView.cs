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
                MessageBoxIcon icon = MessageBoxIcon.Error;
                // captionはメッセージボックスのタイトル
                string caption = "エラー";

                // exの値が変換できれば値が入り、変換できなければ値がnullになる
                // 恐らく、ExceptionBaseを継承した例外であれば値が入り、それ以外であればnullになる
                var exceptionBase = ex as ExceptionBase;
                if (exceptionBase != null)
                {
                    if(exceptionBase.Kind == ExceptionBase.ExceptionKind.Info)
                    {
                        icon = MessageBoxIcon.Information;
                        caption = "情報";
                    }
                    else if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Warning)
                    {
                        icon = MessageBoxIcon.Warning;
                        caption = "警告";

                    }
                }
                MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
            }
        }
    }
}
