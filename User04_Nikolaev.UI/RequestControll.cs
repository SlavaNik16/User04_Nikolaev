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
        public event Action onUpdateStatus;
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
                comboBoxEquipmentType.SelectedItem = comboBoxEquipmentType.Items.Cast<EquipmentType>().FirstOrDefault(x => x.Id == request.EquipmentTypeId);

                comboBoxStatus.DisplayMember = nameof(Status.Title);
                comboBoxStatus.DataSource = db.Statuses.ToList();
                comboBoxStatus.SelectedItem = comboBoxStatus.Items.Cast<Status>().FirstOrDefault(x => x.Id == request.StatusId);

                comboBoxMaster.DisplayMember = nameof(User.FIO);
                comboBoxMaster.DataSource = db.Users.Where(x => x.RoleId == 2).ToList();
                comboBoxMaster.SelectedItem = comboBoxMaster.Items.Cast<User>().FirstOrDefault(x => x.Id == request.WorkerId);
            }
            Init(request);
        }
        private void Init(Request request)
        {
            using (var db = new RepairServiceContext())
            {
                this.Request = db.Requests
                  .Include(x => x.Client)
                  .Include(x => x.Worker)
                  .Include(x => x.Status)
                  .Include(x => x.EquipmentType)
                  .FirstOrDefault(x => x.Id == request.Id);
                if (Request != null)
                {
                    labelIdNumber.Text = Request.Id.ToString();
                    labelCreatedAt.Text = Request.CreatedAt.ToString("dd-MM-yyyy");
                    textBoxModel.Text = Request.ModelEquipment.ToString();
                    textBoxRecent.Text = Request.ResentDefect.ToString();
                    labelFIO.Text = Request.Client.FIO.ToString();
                    labelPhone.Text = Request.Client.Phone.ToString();

                    if (Request.StatusId == 3)
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
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                var request = db.Requests.FirstOrDefault(x => x.Id == Request.Id);
                if(request != null)
                {
                    request.ModelEquipment = textBoxModel.Text;
                    request.EquipmentTypeId = ((EquipmentType)comboBoxEquipmentType.SelectedItem).Id;
                    request.StatusId = ((Status)comboBoxStatus.SelectedItem).Id;
                    request.ResentDefect = textBoxRecent.Text;
                    request.Zapchasty = textBoxZapchasti.Text;
                    if(comboBoxMaster.SelectedItem != null)
                    {
                        request.WorkerId = ((User)comboBoxMaster.SelectedItem).Id;
                        if(request.StatusId == 1)
                        {
                            request.StatusId = 2;
                            comboBoxStatus.SelectedItem = comboBoxStatus.Items.Cast<Status>().FirstOrDefault(x => x.Id == request.StatusId);
                        }
                    }
                    if (request.StatusId == 3)
                    {
                        request.CompletionDate = DateTime.Now;
                        labelCompletedDate.Text = request.CompletionDate?.ToString("dd-MM-yyyy");
                        this.BackColor = Color.Gray;
                        MessageBox.Show("Заявка готова к выдаче!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Данные успешно сохранены!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    db.SaveChanges();
                    Init(request);
                    onUpdateStatus?.Invoke();
                }
            }
        }
    }
}
