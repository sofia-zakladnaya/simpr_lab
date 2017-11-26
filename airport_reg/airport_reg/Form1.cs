using System;
using System.Windows.Forms;
using System.Drawing;
//using System.Collections.Generic;

namespace airport_reg
{
    public partial class RegForm : Form
    {
        MyHookClass simpr;
        public Schedule schedule;
        int tik;
        public RegForm()
        {
            InitializeComponent();
            simpr = new MyHookClass(this.Handle, this);
            //генерация списка рейсов
            schedule = new Schedule(Airport.FlightNum);
            //Выводим список на форму
            TableUpdate();
          
            //Устанавливаем интервал в 20 секунд
            schTimer.Interval = 20000;
            //Запускаем таймер            
            Log("Имитация началась...");
            //Открываем регистрацию на первый рейс
            schedule.FlightList[0].status = FlightStatus.RegistrationOpen;
            schTimer.Start();

        }
        
        //Вывод сведений о билете
        public void PrintTicketInfo(Ticket ticket)
        {
            tbTicketInfo.Clear();
            tbTicketInfo.Text += ("Номер билета: " + ticket.Number.ToString()+ Environment.NewLine);
            tbTicketInfo.Text += ("Номер рейса: " + ticket.FlightNumber.ToString() + Environment.NewLine);            
            tbTicketInfo.Text += ("Перевозка багажа: " + ticket.CheckBaggage()  + Environment.NewLine);
            tbTicketInfo.Text += ("Перевозка животных: " + ticket.CheckPets() + Environment.NewLine);
        }

        //Запись в лог
        public void Log(string message)
        {
            tbLog.Text += message+Environment.NewLine;
        }

        //Обновление таблицы
        public void TableUpdate()
        {
            dgSchedule.DataSource = null;
            dgSchedule.DataSource = schedule.FlightList;
            dgSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dgSchedule.Columns[0].HeaderText = "№";
            dgSchedule.Columns[1].HeaderText = "Тип";
            dgSchedule.Columns[2].HeaderText = "Назначение";
            dgSchedule.Columns[3].HeaderText = "Статус";
        }
        //Тик таймера
        private void schTimer_Tick(object sender, System.EventArgs e)
        {
            //Все рейсы прошли
            if (schedule.IsFinished())
            {
                schTimer.Stop();
                //TODO: отрисовка
                return;
            }

            //Переключаем статусы рейсов
            schedule.Switch();
            
            //обновляем табло
            TableUpdate();
                                 
        }

    
    }
}
