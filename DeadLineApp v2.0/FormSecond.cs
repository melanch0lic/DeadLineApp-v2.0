using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DeadLineApp_v2._0
{
    public partial class FormSecond : Form
    {
        DateTime date = new DateTime();
        public FormSecond()
        {
            InitializeComponent();
        }

        //Событие изменения значения в dateTimePickerDate
        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePickerDate.Value.Date;
            textBoxDate.Text = date.ToShortDateString();
        }

        //Событие клика на кнопку "Добавить Этап"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            valueClass.Date = textBoxDate.Text;
            valueClass.Hours = comboBoxHours.Text;
            valueClass.Minutes = comboBoxMinutes.Text;
            Close();
        }

        private void FormSecond_Load(object sender, EventArgs e)
        {
            //Округление Окна
            this.Region = new Region(
                RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height)
                    , 10
                )
            );
            //Добавление элементов в комбобоксы
            comboBoxHours.Items.AddRange(new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBoxMinutes.Items.AddRange(new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24","25",
                "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", 
                "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56","57","58","59",});
        }
        //Функция для округления углов окна 
        public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();

            // Верхний левый угол
            path.AddArc(arc, 180, 90);

            // Верхний правый угол
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Нижний правый угол
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Нижний левый угол
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
