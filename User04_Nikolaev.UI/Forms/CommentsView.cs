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
using User04_Nikolaev.Context.Models;

namespace User04_Nikolaev.UI.Forms
{
    public partial class CommentsView : Form
    {
        public CommentsView(Request request)
        {
            InitializeComponent();
            using (var db = new RepairServiceContext())
            {
                dataGridView1.DataSource = db.Comments.Where(x => x.RequestId == request.Id).Select(x => new
                {
                    WorkerFIO = x.Worker.FIO,
                    Comment = x.Message,
                }).ToList();
            }
        }
    }
}
