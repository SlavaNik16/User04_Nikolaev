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
    public partial class RequestControll : UserControl
    {
        public Request Request { get; set; }
        public RequestControll(Request request)
        {
            InitializeComponent();

            using (var db = new RepairServiceContext())
            {
                var role = CurrentUser.User.RoleId;
                groupBoxClient.Enabled = role == 1;
                groupBoxMaster.Enabled = role == 2;
                groupBoxOperator.Enabled = role == 3;

                comboBoxEquipmentType.DisplayMember = nameof(EquipmentType.Title);
                comboBoxEquipmentType.DataSource = db.EquipmentTypes.ToList();
                comboBoxEquipmentType.SelectedIndex = 0;

                comboBoxStatus.DisplayMember = nameof(Status.Title);
                comboBoxStatus.DataSource = db.Statuses.ToList();
                comboBoxStatus.SelectedIndex = 0;

                comboBoxMaster.DisplayMember = nameof(User.FIO);
                comboBoxMaster.DataSource = db.Users.Where(x => x.RoleId == 2).ToList();

                this.Request = db.Requests
                    .Include(x => x.Client)
                    .Include(x => x.Worker)
                    .Include(x => x.Status)
                    .Include(x => x.EquipmentType)
                    .FirstOrDefault(x=>x.Id == request.Id);
            }
            Init();
        }
        private void Init()
        {
            if (Request != null)
            {
                labelIdNumber.Text = Request.Id.ToString();
                labelCreatedAt.Text = Request.CreatedAt.ToString("dd-MM-yyyy");
                textBoxModel.Text = Request.ModelEquipment.ToString();
                textBoxRecent.Text = Request.ResentDefect.ToString();
                labelFIO.Text = Request.Client.FIO.ToString();
                labelPhone.Text = Request.Client.Phone.ToString();
                comboBoxStatus.SelectedItem = comboBoxStatus.Items.Cast<Status>().FirstOrDefault(x => x.Id == Request.StatusId);
                comboBoxEquipmentType.SelectedItem = comboBoxEquipmentType.Items.Cast<EquipmentType>().FirstOrDefault(x => x.Id == Request.EquipmentTypeId);
                if (Request.WorkerId != null)
                {
                    comboBoxMaster.SelectedItem = comboBoxMaster.Items.Cast<User>().FirstOrDefault(x => x.Id == Request.WorkerId);
                }
                if(Request.StatusId == 3)
                {
                    labelCompletedDate.Text = Request.CompletionDate?.ToString("dd-MM-yyyy");
                    this.BackColor = Color.Gray;
                }
                else
                {
                    labelCompletedDate.Text = "Отсутствует";
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
