using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User04_Nikolaev.Context;
using User04_Nikolaev.Context.Currentuser;

namespace User04_Nikolaev.UI.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (var db= new RepairServiceContext())
            {
                var user = db.Users.FirstOrDefault(x=>x.Login == textBoxLogin.Text && 
                    x.Password == textBoxPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CurrentUser.User = user;
                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
        }
    }
}
