using NDDD.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NDDD.Winform.Views
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif

            UserIdLabel.Text = Shared.LoginId;
        }
    }
}
