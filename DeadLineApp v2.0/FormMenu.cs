using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadLineApp_v2._0
{
    public partial class FormMenu : Form
    {
        FormDeadLine frm = new FormDeadLine();
        public FormMenu()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            labelDay.Text = DateTime.Now.DayOfWeek.ToString();
            labelDate.Text = DateTime.Now.Date.ToLongDateString();
            labelUntil.Text = "Времени до ближайшего дедлайна\n   " + valueClass.TimeUntil+"\n        "+"Название Этапа: "+valueClass.Name+".\n              "+" Дедлайн: "+valueClass.DeadlineName;
            labelUntil.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUntil.Hide();
        }

    }
}
