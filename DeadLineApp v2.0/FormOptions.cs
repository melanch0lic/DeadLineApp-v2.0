using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadLineApp_v2._0
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
           radioButtonTurnOn.PerformClick();
           comboBoxAlert.Items.AddRange(new string[] { "Ничего", "9:00", "9:30", "10:00","10:30","11:00","11:30","12:00","12:30","13:00","13:30","14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", });
        }

        private void radioButtonTurnOn_Click(object sender, EventArgs e)
        {
            valueClass.flag = true;
        }

        private void radioButtonTurnOff_Click(object sender, EventArgs e)
        {
            valueClass.flag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueClass.timeNotification = comboBoxAlert.Text;
        }

    }
}
