using NDDD.Domain;
using NDDD.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NDDD.Winform.Views
{
    public partial class BaseForm : Form
    {
        private static log4net.ILog _logger =
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif

            UserIdLabel.Text = Shared.LoginId;
        }

        protected void ExceptionDiv(Exception ex)
        {
            _logger.Error(ex.Message, ex);
            MessageBoxIcon icon = MessageBoxIcon.Error;
            // captionはメッセージボックスのタイトル
            string caption = "エラー";

            // exの値が変換できれば値が入り、変換できなければ値がnullになる
            // 恐らく、ExceptionBaseを継承した例外であれば値が入り、それ以外であればnullになる
            var exceptionBase = ex as ExceptionBase;
            if (exceptionBase != null)
            {
                if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Info)
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

        private void BaseForm_Load(object sender, EventArgs e)
        {
            _logger.Error("open:" + this.Name);
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Error("close:" + this.Name);
        }
    }
}
