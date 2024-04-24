using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User04_Nikolaev.Context.Currentuser;

namespace User04_Nikolaev.UI.Forms
{
    public partial class AddCommentForm : Form
    {
        public string Message { get; set; }
        public AddCommentForm()
        {
            InitializeComponent();
            labelFIO.Text = CurrentUser.User.FIO;
            buttonSave.Enabled = false;
        }

        private void textBoxRecent_TextChanged(object sender, EventArgs e)
        {
            Message = textBoxComment.Text;
            buttonSave.Enabled = !string.IsNullOrWhiteSpace(textBoxComment.Text);
        }
    }
}
