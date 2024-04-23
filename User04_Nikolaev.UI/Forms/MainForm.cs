using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User04_Nikolaev.Context;
using User04_Nikolaev.Context.Currentuser;
using User04_Nikolaev.Context.Models;

namespace User04_Nikolaev.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                List<Request> requests;
                switch (CurrentUser.User.RoleId)
                {
                    case 1:
                        labelUser.Text = "Окно клиента";
                        requests = db.Requests.Where(x => x.ClientId == CurrentUser.User.Id).ToList();
                        break;
                    case 2:
                        labelUser.Text = "Окно мастера";
                        requests = db.Requests.Where(x => x.Id == 2).ToList();
                        break;
                    case 3:
                        labelUser.Text = "Окно оператора";
                        break;
                    case 4:
                        labelUser.Text = "Окно менеджера";
                        break;
                }
                requests = db.Requests
                    .ToList();
                foreach(var request in requests)
                {
                    AddView(request);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                var request = new Request()
                {
                    ModelEquipment = "Модель",
                    ClientId = CurrentUser.User.Id,
                    ResentDefect = "Сломалась дверь!"
                };
                db.Requests.Add(request);
                db.SaveChanges();

                request = db.Requests.FirstOrDefault(x=>x.Id == db.Requests.Max(y=>y.Id));
                AddView(request);
            }
           
        }
        private void AddView(Request request)
        {
            var requestView = new RequestControll(request);
            requestView.Parent = flowLayoutPanel1;
        }
    }
}
