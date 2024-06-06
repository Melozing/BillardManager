using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillardManager.View
{
    public partial class FormWaiting : Form
    {
        public Action Action { get; set; }

        public FormWaiting(Action action)
        {
            InitializeComponent();

            if (action == null)
            {
                throw new ArgumentNullException();
            }
            Action = action;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Action).ContinueWith(t =>
            {
                this.Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
