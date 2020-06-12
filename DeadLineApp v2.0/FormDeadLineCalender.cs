using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace DeadLineApp_v2._0
{
    public partial class FormDeadLine : Form
    {
        SpeechSynthesizer speech;
        //Массив для разделения даты на дни,часы,минуты
        string[] mas;

        //Переменные для хранения данных о выделенном этапе
        int year = 2001;
        int month = 02;
        int day = 25;
        int hours = 10;
        int minutes = 10;

        //Переменная для хранения добавляемой даты
        DateTime datetime;

        //Переменная для передачи даты в компонент textBoxDateEdit
        DateTime date = new DateTime();

        //Список хранения Часов этапов Дедлайна
        public List<string> Hours = new List<string>();

        //Список хранения Минут этапов Дедлайна
        public List<string> Minutes = new List<string>();

        //Список хранения Дат этапов Дедлайна
        public List<string> Dates = new List<string>();

        //Список хранения Названий этапов Дедлайна
        public List<string> Names = new List<string>();

        //Список хранения Названий Дедлайнов
        public List<string> DeadlineNames = new List<string>();

        //Переменная для хранения индекса,выделенного этапа
        public int i = 0;

        private FormSecond frm2;

        //Переменные для хранения даты и времени ближайшего этапа
        public int xDay = 32;
        public int xMonth = 13;
        public int xYear = 4000;
        public int xHours = 24;
        public int xMinutes = 61;
        public FormDeadLine()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }


        /*При нажатии на кнопку открывается окно FormSecond откуда данные передаются в статический класс valueClass и добавляются в списки хранения часов,минут,дат и названий.*/
        private void buttonWindowAdd_Click(object sender, EventArgs e)
        {
            frm2 = new FormSecond();
            frm2.ShowDialog();
            try
            {
                //Проверка на ввод
                if (frm2.textBoxDate.Text != "" && frm2.comboBoxHours.Text != "" && frm2.comboBoxMinutes.Text != "" && frm2.textBoxNameOfStep.Text != "")
                {
                    Dates.Add(valueClass.Date);//Добавление даты в список Дат
                    Hours.Add(valueClass.Hours);//Добавление часов в список Часов
                    Minutes.Add(valueClass.Minutes);//Добавление минут в список Минут
                    mas = Dates[i].Replace('.', ' ').Split();
                    datetime = new DateTime(Convert.ToInt32(mas[2]), Convert.ToInt32(mas[1]), Convert.ToInt32(mas[0]));
                    string[] DateB = valueClass.Date.Replace('.', ' ').Split();
                    int DayB = Convert.ToInt32(DateB[0]);
                    int MonthB = Convert.ToInt32(DateB[1]);
                    int YearB = Convert.ToInt32(DateB[2]);
                    //Добавление выделенной даты в компонент monthCalendarDeadLine
                    monthCalendarDeadLine.AddBoldedDate(new DateTime(YearB, MonthB, DayB));
                    monthCalendarDeadLine.UpdateBoldedDates();
                    listBoxDeadLine.Items.Add(frm2.textBoxNameOfStep.Text);
                    Names.Add(frm2.textBoxNameOfStep.Text);
                    DeadlineNames.Add(frm2.textBoxDeadlineName.Text);
                    frm2.Close();
                    //Поиск ближайшего этапа дедлайна
                    for (int i = 0; i < Dates.Count; i++)
                    {
                        try
                        {
                            string[] MinDate = Dates[i].Replace('.', ' ').Split();
                            int minDay = Convert.ToInt32(MinDate[0]);
                            int minMonth = Convert.ToInt32(MinDate[1]);
                            int minYear = Convert.ToInt32(MinDate[1]);
                            if (minYear < xYear)
                            {
                                xDay = minDay;
                                xMonth = minMonth;
                                xYear = minYear;
                                xHours = Convert.ToInt32(Hours[i]);
                                xMinutes = Convert.ToInt32(Minutes[i]);
                                valueClass.minIndex = i;
                                valueClass.Name = Names[i];
                                valueClass.DeadlineName = DeadlineNames[i];
                                listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                            }
                            if (minYear == xYear)
                            {
                                if (minMonth < xMonth)
                                {
                                    xDay = minDay;
                                    xMonth = minMonth;
                                    valueClass.minIndex = i;
                                    valueClass.Name = Names[i];
                                    valueClass.DeadlineName = DeadlineNames[i];
                                    listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                }
                            }
                            if (minYear == xYear)
                            {
                                if (minMonth == xMonth)
                                {
                                    if (minDay < xDay)
                                    {
                                        xDay = minDay;
                                        xMonth = minMonth;
                                        xYear = minYear;
                                        valueClass.minIndex = i;
                                        valueClass.Name = Names[i];
                                        valueClass.DeadlineName = DeadlineNames[i];
                                        listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                    }
                                }
                            }
                            if (minYear == xYear)
                            {
                                if (minMonth == xMonth)
                                {
                                    if (minDay == xDay)
                                    {
                                        if (Convert.ToInt32(Hours[i]) < xHours)
                                        {
                                            xHours = Convert.ToInt32(Hours[i]);
                                            xMinutes = Convert.ToInt32(Minutes[i]);
                                            valueClass.minIndex = i;
                                            valueClass.Name = Names[i];
                                            valueClass.DeadlineName = DeadlineNames[i];
                                            listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                        }
                                    }
                                }
                            }
                            if (minYear == xYear)
                            {
                                if (minMonth == xMonth)
                                {
                                    if (minDay == xDay)
                                    {
                                        if (Convert.ToInt32(Hours[i]) == xHours)
                                        {
                                            if (Convert.ToInt32(Minutes[i]) < xMinutes)
                                            {
                                                xMinutes = Convert.ToInt32(Minutes[i]);
                                                valueClass.minIndex = i;
                                                valueClass.Name = Names[i];
                                                valueClass.DeadlineName = DeadlineNames[i];
                                                listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                            }
                                        }
                                    }
                                }
                            }
                            valueClass.minIndex++;
                        }
                        catch { }
                    }
                }
            }
            //catch при вводе неправильной даты
            catch
            {
                MessageBox.Show("Введите дату правильно!");
                Dates.RemoveAt(i);
                Hours.RemoveAt(i);
                Minutes.RemoveAt(i);
                frm2.Close();
            }
        }

        //При запуске формы в листбокс добавляются названия которые были сохранены в xml файл. И в monthCalendarDeadLine выделяются даты
        private void FormDeadLine_Load(object sender, EventArgs e)
        {
            foreach (string el in Names)
            {
                listBoxDeadLine.Items.Add(el);
            }
            monthCalendarDeadLine.TrailingForeColor = System.Drawing.Color.Red;
            monthCalendarDeadLine.TitleBackColor = Color.FromArgb(36, 59, 85);
            monthCalendarDeadLine.TitleForeColor = Color.White;
            timerProtect.Enabled = true;
            timerDeadLine.Enabled = true;
            labelTIme.Hide();
            dateTimePickerDateDeadLine.Hide();
            labelInfoStep.Hide();
            labelNameEdit.Hide();
            labelDateEdit.Hide();
            labelTimeEdit.Hide();
            labelEd.Hide();
            textBoxDateEdit.Hide();
            comboBoxHoursEdit.Hide();
            comboBoxMinutesEdit.Hide();
            textBoxNameEdit.Hide();
            buttonEdit.Hide();
            buttonDelete.Hide();
            textBoxDeadlineNameEdit.Hide();
            labelDeadlineEdit.Hide();
            labelTIme.BackColor = Color.Transparent;
            labelTIme.ForeColor = Color.Snow;
            comboBoxHoursEdit.Items.AddRange(new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBoxMinutesEdit.Items.AddRange(new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24","25",
                "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40",
                "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56","57","58","59",});
            foreach (string item in Dates)
            {
                string[] DateB = item.Replace('.', ' ').Split();
                int DayB = Convert.ToInt32(DateB[0]);
                int MonthB = Convert.ToInt32(DateB[1]);
                int YearB = Convert.ToInt32(DateB[2]);
                monthCalendarDeadLine.AddBoldedDate(new DateTime(YearB, MonthB, DayB));
            }
            monthCalendarDeadLine.UpdateBoldedDates();
            
        }

        //Таймер для звукового оповещения и отображения времени, которое осталось до этапа
        private void timerDeadLine_Tick(object sender, EventArgs e)
        {
            //Проверка пуст ли листбокс
            if (listBoxDeadLine.Items.Count > 0)
            {
                mas = Dates[i].Replace('.', ' ').Split();
                year = Convert.ToInt32(mas[2]);
                month = Convert.ToInt32(mas[1]);
                day = Convert.ToInt32(mas[0]);
                hours = Convert.ToInt32(Hours[i]);
                minutes = Convert.ToInt32(Minutes[i]);
            }
            string dayText;
            string hourText;
            string minuteText;
            DateTime b = new DateTime(year: year, month: month, day: day, hour: hours, minute: minutes, second: 0);
            TimeSpan kek = b - DateTime.Now;//Интервал времени до этапа Дедлайна
            //Условия для смены окончания слов
            if (kek.Days % 10 == 1 && kek.Days != 11)
                dayText = "День";
            else if (kek.Days % 10 < 5 && kek.Days % 10 >= 2 && kek.Days / 10 != 1)
                dayText = "Дня";
            else dayText = "Дней";

            if (kek.Hours % 10 == 1 && kek.Hours != 11)
                hourText = "Час";
            else if (kek.Hours % 10 < 5 && kek.Hours % 10 >= 2 && kek.Hours / 10 != 1)
                hourText = "Часа";
            else hourText = "Часов";

            if (kek.Minutes % 10 == 1 && kek.Minutes != 11)
                minuteText = "Минута";
            else if (kek.Minutes % 10 < 5 && kek.Minutes % 10 >= 2 && kek.Minutes / 10 != 1)
                minuteText = "Минуты";
            else minuteText = "Минут";

            //Отображение времени в labelTIme
            String.Format("{0:00}:{1:00}:{2:00}:{3:00}", kek.Days, kek.Hours, kek.Minutes, kek.Seconds);
            labelTIme.Text = "Осталось: " + String.Format("{0:00}" + " " + dayText + " " + "{1:00}" + " " + hourText + " " + "{2:00}" + " " + minuteText, kek.Days, kek.Hours, kek.Minutes);
            valueClass.TimeUntil = labelTIme.Text;

            //Если листбокс пуст
            if (listBoxDeadLine.Items.Count == 0)
            {
                valueClass.TimeUntil = "Осталось: Этап не найден";
                valueClass.Name ="Этап не найден";
                valueClass.DeadlineName = "Дедлайн не найден";
            }
            
            try
            {
                //Звуковые оповещения, которые настраиваются в вкладке  Options
                if (valueClass.timeNotification != "Ничего")
                {

                    string[] time = valueClass.timeNotification.Replace(':', ' ').Split();
                    int nHours = Convert.ToInt32(time[0]);
                    int nMinutes = Convert.ToInt32(time[1]);

                    //Условие проверки на равенство поставленного времени в настройках с текущим
                    if (DateTime.Now.Hour == nHours && DateTime.Now.Minute == nMinutes)
                    {
                        //Воспроизведение речи
                        speech.SpeakAsync("Проверьте свои дедлайны! Работа ждет!");
                        speech.Resume();
                        Thread.Sleep(3000);
                        speech.Pause();
                    }
                }
            }

            catch { }

            //Проверка вышло ли время этапа Дедлайна, или нет
            if (kek.Days == 0 && kek.Hours == 0 && kek.Minutes == 0 && kek.Seconds == 0||kek.Days < 0 || kek.Hours < 0 || kek.Minutes < 0 || kek.Seconds < 0)
            {
                try
                {
                    string[] DateB = Dates[i].Replace('.', ' ').Split();
                    int DayB = Convert.ToInt32(DateB[0]);
                    int MonthB = Convert.ToInt32(DateB[1]);
                    int YearB = Convert.ToInt32(DateB[2]);
                    monthCalendarDeadLine.RemoveBoldedDate(new DateTime(YearB, MonthB, DayB));//Удаление выделенной даты из компонента monthCalendarDeadLine
                    //Проверка включено ли звуковое уведомление об окончании этапа
                    if (valueClass.flag==true)
                    {
                        //Воспроизведение речи
                        speech.SpeakAsync("Время этапа " + Names[i] + " из Дедлайна " +DeadlineNames[i]+" вышло! ");
                        speech.Resume();
                        Thread.Sleep(5000);
                        speech.Pause();
                    }

                    //Удаление данных об этапе из списков
                    Dates.RemoveAt(i);
                    Hours.RemoveAt(i);
                    Minutes.RemoveAt(i);
                    Names.RemoveAt(i);
                    DeadlineNames.RemoveAt(i);
                    listBoxDeadLine.Items.RemoveAt(i);

                    //Обновление выделенных дат в компоненте monthDeadLineCalendar
                    foreach (string item in Dates)
                    {
                        string[] DateG = item.Replace('.', ' ').Split();
                        int DayG = Convert.ToInt32(DateG[0]);
                        int MonthG = Convert.ToInt32(DateG[1]);
                        int YearG = Convert.ToInt32(DateG[2]);
                        monthCalendarDeadLine.AddBoldedDate(new DateTime(YearG, MonthG, DayG));
                    }

                    labelTIme.Hide();
                    labelInfoStep.Hide();
                    labelNameEdit.Hide();
                    labelDateEdit.Hide();
                    labelTimeEdit.Hide();
                    labelEd.Hide();
                    textBoxDateEdit.Hide();
                    comboBoxHoursEdit.Hide();
                    comboBoxMinutesEdit.Hide();
                    textBoxNameEdit.Hide();
                    buttonEdit.Hide();
                    buttonDelete.Hide();
                    dateTimePickerDateDeadLine.Hide();
                    textBoxDeadlineNameEdit.Hide();
                    labelDeadlineEdit.Hide();
                    monthCalendarDeadLine.UpdateBoldedDates();
                }
                catch { }
                xDay = 32;
                xMonth = 13;
                xYear = 4000;
                xHours = 24;
                xMinutes = 61;

                //Поиск ближайшего этапа Дедлайна и выделение его
                for (int i = 0; i < Dates.Count; i++)
                {
                    try
                    {
                        string[] MinDate = Dates[i].Replace('.', ' ').Split();
                        int minDay = Convert.ToInt32(MinDate[0]);
                        int minMonth = Convert.ToInt32(MinDate[1]);
                        int minYear = Convert.ToInt32(MinDate[1]);
                        if (minYear < xYear)
                        {
                            xDay = minDay;
                            xMonth = minMonth;
                            xYear = minYear;
                            xHours = Convert.ToInt32(Hours[i]);
                            xMinutes = Convert.ToInt32(Minutes[i]);
                            valueClass.minIndex = i;
                            listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth < xMonth)
                            {
                                xDay = minDay;
                                xMonth = minMonth;
                                valueClass.minIndex = i;
                                listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay < xDay)
                                {
                                    xDay = minDay;
                                    xMonth = minMonth;
                                    xYear = minYear;
                                    valueClass.minIndex = i;
                                    listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                }
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay == xDay)
                                {
                                    if (Convert.ToInt32(Hours[i]) < xHours)
                                    {
                                        xHours = Convert.ToInt32(Hours[i]);
                                        xMinutes = Convert.ToInt32(Minutes[i]);
                                        valueClass.minIndex = i;
                                        listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                    }
                                }
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay == xDay)
                                {
                                    if (Convert.ToInt32(Hours[i]) == xHours)
                                    {
                                        if (Convert.ToInt32(Minutes[i]) < xMinutes)
                                        {
                                            xMinutes = Convert.ToInt32(Minutes[i]);
                                            valueClass.minIndex = i;
                                            listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                        }
                                    }
                                }
                            }
                        }

                    }
                    catch { }
                }
                //Если листбокс не пуст записываем названия Дедлайна и этапа Дедлайна в переменные статического класса
                if (listBoxDeadLine.Items.Count != 0)
                {
                    valueClass.Name = Names[valueClass.minIndex];
                    valueClass.DeadlineName = DeadlineNames[valueClass.minIndex];
                }
                valueClass.minIndex++;
            }
        }

        //Событие изменения индекса в листбоксе
        private void listBoxDeadLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                i = listBoxDeadLine.SelectedIndex;//В переменную записываем индекс выделенного этапа
                mas = Dates[i].Replace('.', ' ').Split();
                year = Convert.ToInt32(mas[2]);
                month = Convert.ToInt32(mas[1]);
                day = Convert.ToInt32(mas[0]);
                hours = Convert.ToInt32(Hours[i]);
                minutes = Convert.ToInt32(Minutes[i]);
                labelTIme.Show();
                
                //Отображение данных о выделенном этапе в текстбоксах и комбобоксах
                comboBoxHoursEdit.Text = String.Format("{0:00}", hours);
                comboBoxMinutesEdit.Text = String.Format("{0:00}", minutes);
                textBoxNameEdit.Text = listBoxDeadLine.SelectedItem.ToString();
                textBoxDeadlineNameEdit.Text = DeadlineNames[i];
                textBoxDateEdit.Text = day.ToString() + "." + month.ToString() + "." + year.ToString();

                labelInfoStep.Show();
                labelNameEdit.Show();
                labelDateEdit.Show();
                labelTimeEdit.Show();
                labelEd.Show();
                textBoxDateEdit.Show();
                comboBoxHoursEdit.Show();
                comboBoxMinutesEdit.Show();
                textBoxNameEdit.Show();
                buttonEdit.Show();
                buttonDelete.Show();
                textBoxDeadlineNameEdit.Show();
                labelDeadlineEdit.Show();
                dateTimePickerDateDeadLine.Show();
            }
            catch
            {
                monthCalendarDeadLine.RemoveBoldedDate(datetime);
                monthCalendarDeadLine.UpdateBoldedDates();
                i++;
            }
        }

        //Событие клика на кнопку "Редактировать"
        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            //Изменение данных введенных в текстбоксы и комбобоксы
            Dates[i] = textBoxDateEdit.Text;
            Hours[i] = comboBoxHoursEdit.Text;
            Minutes[i] = comboBoxMinutesEdit.Text;
            monthCalendarDeadLine.RemoveAllBoldedDates();//Удаление всех выделенных дат в компоненте monthCalendar
            //Добавление дат из списка Dates для выделения в monthCalendar
            foreach (string item in Dates)
            {
                string[] DateB = item.Replace('.', ' ').Split();
                int DayB = Convert.ToInt32(DateB[0]);
                int MonthB = Convert.ToInt32(DateB[1]);
                int YearB = Convert.ToInt32(DateB[2]);
                monthCalendarDeadLine.AddBoldedDate(new DateTime(YearB, MonthB, DayB));
            }
            hours = Convert.ToInt32(Hours[i]);
            minutes = Convert.ToInt32(Minutes[i]);

            labelTIme.Show();
            monthCalendarDeadLine.UpdateBoldedDates();//Обновление выделенных дат
        }

        //Событие клика на кнопку "Удалить"
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            //Выделенная дата
            string[] DateB = Dates[i].Replace('.', ' ').Split();
            int DayB = Convert.ToInt32(DateB[0]);
            int MonthB = Convert.ToInt32(DateB[1]);
            int YearB = Convert.ToInt32(DateB[2]);

            //Удаление данных из списков и выделенной даты компонента monthDeadLineCalendar
            monthCalendarDeadLine.RemoveBoldedDate(new DateTime(YearB, MonthB, DayB));
            Dates.RemoveAt(i);
            Hours.RemoveAt(i);
            Minutes.RemoveAt(i);
            Names.RemoveAt(i);
            DeadlineNames.RemoveAt(i);
            listBoxDeadLine.Items.RemoveAt(i);
            //Добавление дат из списка Dates для выделения в monthCalendar
            foreach (string item in Dates)
            {
                string[] DateG = item.Replace('.', ' ').Split();
                int DayG = Convert.ToInt32(DateG[0]);
                int MonthG = Convert.ToInt32(DateG[1]);
                int YearG = Convert.ToInt32(DateG[2]);
                monthCalendarDeadLine.AddBoldedDate(new DateTime(YearG, MonthG, DayG));
            }

            labelTIme.Hide();
            labelInfoStep.Hide();
            labelNameEdit.Hide();
            labelDateEdit.Hide();
            labelTimeEdit.Hide();
            labelEd.Hide();
            textBoxDeadlineNameEdit.Hide();
            labelDeadlineEdit.Hide();
            textBoxDateEdit.Hide();
            comboBoxHoursEdit.Hide();
            comboBoxMinutesEdit.Hide();
            textBoxNameEdit.Hide();
            buttonEdit.Hide();
            buttonDelete.Hide();
            dateTimePickerDateDeadLine.Hide();         
            monthCalendarDeadLine.UpdateBoldedDates();
            //Если листбокс не пуст
            if(listBoxDeadLine.Items.Count>0)
            {
                //Поиск ближайшего этапа  Дедлайна
                for (int i = 0; i < Dates.Count; i++)
                {
                    try
                    {
                        string[] MinDate = Dates[i].Replace('.', ' ').Split();
                        int minDay = Convert.ToInt32(MinDate[0]);
                        int minMonth = Convert.ToInt32(MinDate[1]);
                        int minYear = Convert.ToInt32(MinDate[1]);
                        if (minYear < xYear)
                        {
                            xDay = minDay;
                            xMonth = minMonth;
                            xYear = minYear;
                            xHours = Convert.ToInt32(Hours[i]);
                            xMinutes = Convert.ToInt32(Minutes[i]);
                            valueClass.minIndex = i;
                            listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth < xMonth)
                            {
                                xDay = minDay;
                                xMonth = minMonth;
                                valueClass.minIndex = i;
                                listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay < xDay)
                                {
                                    xDay = minDay;
                                    xMonth = minMonth;
                                    xYear = minYear;
                                    valueClass.minIndex = i;
                                    listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                }
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay == xDay)
                                {
                                    if (Convert.ToInt32(Hours[i]) < xHours)
                                    {
                                        xHours = Convert.ToInt32(Hours[i]);
                                        xMinutes = Convert.ToInt32(Minutes[i]);
                                        valueClass.minIndex = i;
                                        listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                    }
                                }
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay == xDay)
                                {
                                    if (Convert.ToInt32(Hours[i]) == xHours)
                                    {
                                        if (Convert.ToInt32(Minutes[i]) < xMinutes)
                                        {
                                            xMinutes = Convert.ToInt32(Minutes[i]);
                                            valueClass.minIndex = i;
                                            listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                        }
                                    }
                                }
                            }
                        }
                        valueClass.minIndex++;
                    }
                    catch { }
                }
            }
            //Если листбокс пуст то записываем в переменные статического класса значения
            else
            {   
                valueClass.Name = "Этап не найден";
                valueClass.DeadlineName = "Дедлайн не найден";
            }
        }

        //Выбор даты из dateTimePicker в textBoxDateEdit
            private void dateTimePickerDateDeadLine_ValueChanged(object sender, EventArgs e)
            {
                date = dateTimePickerDateDeadLine.Value.Date;
                textBoxDateEdit.Text = date.ToShortDateString();
            }

        //Таймер который каждые 5 минут выделяет ближайший этап в листбоксе
            private void timerAlert_Tick(object sender, EventArgs e)
            {
                bool flag = true;
                if (flag)
                {
                    xDay = 32;
                    xMonth = 13;
                    xYear = 4000;
                    xHours = 24;
                    xMinutes = 61;
                    flag = false;
                }
                for (int i = 0; i < Dates.Count; i++)
                {
                    try
                    {
                        string[] MinDate = Dates[i].Replace('.', ' ').Split();
                        int minDay = Convert.ToInt32(MinDate[0]);
                        int minMonth = Convert.ToInt32(MinDate[1]);
                        int minYear = Convert.ToInt32(MinDate[1]);
                        if (minYear < xYear)
                        {
                            xDay = minDay;
                            xMonth = minMonth;
                            xYear = minYear;
                            xHours = Convert.ToInt32(Hours[i]);
                            xMinutes = Convert.ToInt32(Minutes[i]);
                            valueClass.minIndex = i;
                            listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth < xMonth)
                            {
                                xDay = minDay;
                                xMonth = minMonth;
                                valueClass.minIndex = i;
                                listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay < xDay)
                                {
                                    xDay = minDay;
                                    xMonth = minMonth;
                                    xYear = minYear;
                                    valueClass.minIndex = i;
                                    listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                }
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay == xDay)
                                {
                                    if (Convert.ToInt32(Hours[i]) < xHours)
                                    {
                                        xHours = Convert.ToInt32(Hours[i]);
                                        xMinutes = Convert.ToInt32(Minutes[i]);
                                        valueClass.minIndex = i;
                                        listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                    }
                                }
                            }
                        }
                        if (minYear == xYear)
                        {
                            if (minMonth == xMonth)
                            {
                                if (minDay == xDay)
                                {
                                    if (Convert.ToInt32(Hours[i]) == xHours)
                                    {
                                        if (Convert.ToInt32(Minutes[i]) < xMinutes)
                                        {
                                            xMinutes = Convert.ToInt32(Minutes[i]);
                                            valueClass.minIndex = i;
                                            listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                        }
                                    }
                                }
                            }
                        }
                        valueClass.minIndex++;
                    }
                    catch { }
                }
            }
        }
    }

