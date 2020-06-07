﻿using System;
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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            richTextBoxHelp.Text = ("Итак,при первом запуске программы, открывается вкладка Main Menu,\nв ней показывается текущее время и день недели,чтобы добавить Дедлайн\n нажмите на вкладку Deadline Calender.\nДля того чтобы добавить этап Дедлайна в список нажмите кнопку\n \"Открыть Окно Добавления\".\nПосле этого откроется окно в котором необходимо ввести название самого дедлайна,\nназвание его этапа, дату и время дедлайна и после этого, нажать кнопку \"Добавить Этап\",\nэтап добавится и дата выделится в календаре.\nПри клике на дату в списке будет выводиться обратный отсчет до этапа дедлайна\n и показываться информация об этапе.\nДату и время можно выбрать с помощью ползунков!\nТакже при клике на определенный этап появляется информация о нем,и кнопки,\n с помощью которых вы можете либо удалить этап,либо редактировать его время и дату.\n При этом название Дедлайна и название этапа изменить нельзя,так что,\n будьте внимательны при вводе данных!\nЕсли вы нажмете на вкладку Main Menu после добавления этапа Дедлайна,то в ней\n будет показываться время до ближайшего этапа Дедлайна и вся информация о нем!\nТакже в приложение встроены звуковые оповещения,которые вы можете настраивать\n во вкладке Options.\nПрограмма может работать в трее и чтобы её закрыть нужно нажать ПКМ на иконку в трее и \"Выход\",\nпри этом все раннее введенные данные сохраняются и приложение закрывается.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/197iNsYzVpuhStvQonLqJFI5Z9RzlQ6elUEpxz140Cms/edit?usp=sharing");
        }
    }
}
