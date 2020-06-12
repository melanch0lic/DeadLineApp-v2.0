using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using FontAwesome.Sharp;

namespace DeadLineApp_v2._0
{
    public partial class FormMain : Form
    {
        //Поля
        FormDeadLine frm = new FormDeadLine();
        FormOptions frmOpt = new FormOptions();
        FormHelp frmHelp = new FormHelp();
        FormMenu frmMenu = new FormMenu();
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentChildForm;
        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            gradientPanelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //Структуры
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(36, 59, 85);
            public static Color color6 = Color.FromArgb(20, 30, 48);
        }
        
        //Округление углов Окна приложения
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
        //Функция активации кнопки, изменения анимации и иконки
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrenChildForm.IconChar = currentBtn.IconChar;
                iconCurrenChildForm.IconColor = color;

            }
        }
        //Функция при переключении кнопки
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //Функция открытия дочерней формы
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            gradientPanelDesktop.Controls.Add(childForm);
            gradientPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleofChildForm.Text = currentBtn.Text;
        }

        //Событие клика на кнопку Main Menu
        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            Research();
            if (frm.Names.Count > 0)
            {
                valueClass.Name = frm.listBoxDeadLine.SelectedItem.ToString();
                valueClass.DeadlineName = frm.DeadlineNames[valueClass.minIndex-1];
            }
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(frmMenu);
        }
        //Функция поиска ближайшего этапа Дедлайна и выделение его в листбоксе
        private void Research()
        {
            bool flag = true;
            if (flag)
            {
                frm.xDay = 32;
                frm.xMonth = 13;
                frm.xYear = 4000;
                frm.xHours = 24;
                frm.xMinutes = 61;
            }
            for (int i = 0; i < frm.Dates.Count; i++)
            {
                try
                {
                    string[] MinDate = frm.Dates[i].Replace('.', ' ').Split();
                    int minDay = Convert.ToInt32(MinDate[0]);
                    int minMonth = Convert.ToInt32(MinDate[1]);
                    int minYear = Convert.ToInt32(MinDate[1]);
                    if (minYear < frm.xYear)
                    {
                        frm.xDay = minDay;
                        frm.xMonth = minMonth;
                        frm.xYear = minYear;
                        frm.xHours = Convert.ToInt32(frm.Hours[i]);
                        frm.xMinutes = Convert.ToInt32(frm.Minutes[i]);
                        valueClass.minIndex = i;
                        frm.listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                    }
                    if (minYear == frm.xYear)
                    {
                        if (minMonth < frm.xMonth)
                        {
                            frm.xDay = minDay;
                            frm.xMonth = minMonth;
                            valueClass.minIndex = i;
                            frm.listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                        }
                    }
                    if (minYear == frm.xYear)
                    {
                        if (minMonth == frm.xMonth)
                        {
                            if (minDay < frm.xDay)
                            {
                                frm.xDay = minDay;
                                frm.xMonth = minMonth;
                                frm.xYear = minYear;
                                valueClass.minIndex = i;
                                frm.listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                            }
                        }
                    }
                    if (minYear == frm.xYear)
                    {
                        if (minMonth == frm.xMonth)
                        {
                            if (minDay == frm.xDay)
                            {
                                if (Convert.ToInt32(frm.Hours[i]) < frm.xHours)
                                {
                                    frm.xHours = Convert.ToInt32(frm.Hours[i]);
                                    frm.xMinutes = Convert.ToInt32(frm.Minutes[i]);
                                    valueClass.minIndex = i;
                                    frm.listBoxDeadLine.SelectedIndex = valueClass.minIndex;
                                }
                            }
                        }
                    }
                    if (minYear == frm.xYear)
                    {
                        if (minMonth == frm.xMonth)
                        {
                            if (minDay == frm.xDay)
                            {
                                if (Convert.ToInt32(frm.Hours[i]) == frm.xHours)
                                {
                                    if (Convert.ToInt32(frm.Minutes[i]) < frm.xMinutes)
                                    {
                                        frm.xMinutes = Convert.ToInt32(frm.Minutes[i]);
                                        valueClass.minIndex = i;
                                        frm.listBoxDeadLine.SelectedIndex = valueClass.minIndex;
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
        //Событие клика на вкладку DeadLineCalendar
        private void iconButtonCalendar_Click(object sender, EventArgs e)
        {
            Research();
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(frm);
        }

        //Событие клика на вкладку Help
        private void iconButtonHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(frmHelp);
        }

        //Событие клика на вкладку Options
        private void iconButtonOptions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(frmOpt);
        }
        
        //Событие при наведении на вкладку(Цвет меняется)
        private void iconButtonMenu_MouseEnter(object sender, EventArgs e)
        {
            iconButtonMenu.BackColor = Color.FromArgb(36, 59, 85);
        }

        //Событие если курсор не наведен на кнопку
        private void iconButtonMenu_MouseLeave(object sender, EventArgs e)
        {
            iconButtonMenu.BackColor = Color.Transparent;
        }

        //Событие при наведении на вкладку(Цвет меняется)
        private void iconButtonCalendar_MouseEnter(object sender, EventArgs e)
        {
            iconButtonCalendar.BackColor = Color.FromArgb(36, 59, 85);
        }

        //Событие если курсор не наведен на кнопку
        private void iconButtonCalendar_MouseLeave(object sender, EventArgs e)
        {
            iconButtonCalendar.BackColor = Color.Transparent;
        }

        //Событие при наведении на вкладку(Цвет меняется)
        private void iconButtonHelp_MouseEnter(object sender, EventArgs e)
        {
            iconButtonHelp.BackColor = Color.FromArgb(36, 59, 85);
        }

        //Событие если курсор не наведен на кнопку
        private void iconButtonHelp_MouseLeave(object sender, EventArgs e)
        {
            iconButtonHelp.BackColor = Color.Transparent;
        }

        //Событие при наведении на вкладку(Цвет меняется)
        private void iconButtonOptions_MouseEnter(object sender, EventArgs e)
        {
            iconButtonOptions.BackColor = Color.FromArgb(36, 59, 85);
        }

        //Событие если курсор не наведен на кнопку
        private void iconButtonOptions_MouseLeave(object sender, EventArgs e)
        {
            iconButtonOptions.BackColor = Color.Transparent;
        }
        //Перетаскивание формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void gradientPanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Событие клика на крестик
        private void iconButtonExit_Click_1(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                Research();
            }
            catch { }
        }
        //Событие клика на кнопку свернуть
        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {      
           WindowState = FormWindowState.Minimized;
           this.ShowInTaskbar = true;
        }

        private void gradientPanelMenu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                gradientPanelMenu.Size= new System.Drawing.Size(220,669); 
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            notifyIconDeadLine.ContextMenuStrip = contextMenuStripNotify;
            this.Region = new Region(
                 RoundedRect(
                     new Rectangle(0, 0, this.Width, this.Height)
                     , 10
                 )
             );//Округление углов окна приложения
            //Десериализация
            try
            {
                SerializeDeserialize.Deserialize(frm.Hours, "Hours.xml");
                SerializeDeserialize.Deserialize(frm.Minutes, "Minutes.xml");
                SerializeDeserialize.Deserialize(frm.Dates, "Dates.xml");
                SerializeDeserialize.Deserialize(frm.Names, "Names.xml");
                SerializeDeserialize.Deserialize(frm.DeadlineNames, "DeadlineNames.xml");
            }
            catch { }
            iconButtonCalendar.PerformClick();//Клик на кнопку 
            iconButtonMenu.PerformClick();//Клик на кнопку 
        }
        //Событие клика на кнопку "Выход" в тулстрипе трея
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Очистка файлов перед сериализацией 
            StreamWriter Writer1 = new StreamWriter("Hours.xml", false, Encoding.UTF8);
            Writer1.WriteLine("");
            Writer1.Close();
            StreamWriter Writer2 = new StreamWriter("Minutes.xml", false, Encoding.UTF8);
            Writer2.WriteLine("");
            Writer2.Close();
            StreamWriter Writer3 = new StreamWriter("Dates.xml", false, Encoding.UTF8);
            Writer3.WriteLine("");
            Writer3.Close();
            StreamWriter Writer4 = new StreamWriter("Names.xml", false, Encoding.UTF8);
            Writer4.WriteLine("");
            Writer4.Close();
            StreamWriter Writer5 = new StreamWriter("DeadlineNames.xml", false, Encoding.UTF8);
            Writer5.WriteLine("");
            Writer5.Close();
            //Сериализация
            SerializeDeserialize.SerializeObject(frm.Hours, "Hours.xml");
            SerializeDeserialize.SerializeObject(frm.Minutes, "Minutes.xml");
            SerializeDeserialize.SerializeObject(frm.Dates, "Dates.xml");
            SerializeDeserialize.SerializeObject(frm.Names, "Names.xml");
            SerializeDeserialize.SerializeObject(frm.DeadlineNames, "DeadlineNames.xml");
            Application.Exit();//Закрытие приложения
        }

        //Событие клика на иконку в трее
        private void notifyIconDeadLine_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                Research();

            }
        }
        //Событие клика на кнопку "Помощь" в тулстрипе трея
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconButtonHelp.PerformClick();
        }
    }
}
