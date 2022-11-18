using NDDD.Domain;
using System;
using System.Windows.Forms;

namespace NDDD.Winform.Views
{
    public partial class LoginView : BaseForm
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Shared.LoginId = LoginTextBox.Text;
        }
    }
}
