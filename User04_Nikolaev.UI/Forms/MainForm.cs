using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
                var user = CurrentUser.User;
                buttonAdd.Enabled = false;
                switch (user.RoleId)
                {
                    case 1:
                        labelUser.Text = "Окно клиента";
                        requests = db.Requests.Where(x => x.ClientId == user.Id).ToList();
                        buttonAdd.Enabled = true;
                        break;
                    case 2:
                        labelUser.Text = "Окно мастера";
                        requests = db.Requests.Where(x => x.WorkerId == user.Id).ToList();
                        break;
                    case 3:
                        labelUser.Text = "Окно оператора";
                        requests = db.Requests.ToList();
                        break;
                    default:
                        labelUser.Text = "Окно менеджера";
                        requests = db.Requests.ToList();
                        break;
                }
                foreach(var request in requests)
                {
                    AddView(request);
                }
                UpdateStatic();
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
            requestView.onUpdateStatus += RequestView_onUpdateStatus;
            requestView.Parent = flowLayoutPanel1;
        }

        private void RequestView_onUpdateStatus()
        {
            UpdateStatic();
        }
        private void UpdateStatic()
        {
            var countStatus = 0;
            var avgTime = 0d;
            var count = 0;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is RequestControll requestControll)
                {
                    count++;
                    var request = requestControll.Request;
                    if (request.StatusId == 3)
                    {
                        countStatus++;
                    }
                    if (request.CompletionDate != null)
                    {
                        TimeSpan ts = ((DateTime)request.CompletionDate).Subtract(request.CreatedAt);
                        avgTime += ts.TotalSeconds;
                        labelTimeAvg.Text = (avgTime / count).ToString();
                    }
                }
            }
            labelCountStatusEnd.Text = countStatus.ToString();
        }
    }

}
