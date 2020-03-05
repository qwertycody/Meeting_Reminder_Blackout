using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingReminderBlackout
{
    public partial class MeetingReminderWindow : Form
    {
        public Boolean weDoneYet = false;

        public MeetingReminderWindow(Screen s)
        {
            InitializeComponent();
        }

        private void MeetingReminderButton_Click(object sender, EventArgs e)
        {
            weDoneYet = true;

            this.Close();
        }
    }
}
