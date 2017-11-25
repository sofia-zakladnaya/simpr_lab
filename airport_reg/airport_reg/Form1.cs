using System;
using System.Windows.Forms;
using System.Drawing;
//using System.Collections.Generic;

namespace airport_reg
{
    public partial class RegForm : Form
    {
        MyHookClass simpr;
        Schedule sch;
        int tik;
        public RegForm()
        {
            InitializeComponent();
            //генерация списка рейсов
            sch = new Schedule(10);
            //Выводим список на форму
            BindingSource src = new BindingSource();
            
            dgSchedule.AutoGenerateColumns = true;
            src.DataSource = sch.FlightList;
            dgSchedule.DataSource = src;
            dgSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dgSchedule.Columns[0].HeaderText = "№";
            dgSchedule.Columns[1].HeaderText = "Тип";
            dgSchedule.Columns[2].HeaderText = "Назначение";
            dgSchedule.Columns[3].HeaderText = "Статус";
            //Стартовое изображение
            Draw(Application.StartupPath + "\\img\\start.png");
            //Устанавливаем интервал в 5 секунд
            schTimer.Interval = 5000;
            //Запускаем таймер
            tik = 0;
            textBox1.Text = "Имитация началась... ";
            schTimer.Start();

        }

        //Отрисовка картинки из файла
        public void Draw(string imgFile)
        {
            Bitmap img = new Bitmap(imgFile);
            pbCurPicture.Image = img;
        }

        //Тик таймера
        private void schTimer_Tick(object sender, System.EventArgs e)
        {
            //Все рейсы прошли
            if (sch.IsFinished())
            {
                schTimer.Stop();
                textBox1.Text += Environment.NewLine + "Имитация закончена";
                //TODO: отрисовка
                return;
            }

            //Переключаем статусы рейсов
            bool fl = false;
            for(int i=sch.Departures; i<sch.FlightList.Count; i++)
            {
                fl = false;
                switch (sch.FlightList[i].status)
                {
                    case FlightStatus.NoRegistration:
                        {
                            sch.FlightList[i].status = FlightStatus.RegistrationOpen;
                            fl = true;
                            break;
                        }
                    case FlightStatus.RegistrationOpen:
                        {
                            sch.FlightList[i].status = FlightStatus.RegistrationClose;
                            break;
                        }
                    case FlightStatus.RegistrationClose:
                        {
                            sch.FlightList[i].status = FlightStatus.Departed;
                            sch.Departures++;
                            break;
                        }
                   
                }
                //обновляем табло
                dgSchedule.DataSource = null;
                dgSchedule.DataSource = sch.FlightList;
                dgSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                dgSchedule.Columns[0].HeaderText = "№";
                dgSchedule.Columns[1].HeaderText = "Тип";
                dgSchedule.Columns[2].HeaderText = "Назначение";
                dgSchedule.Columns[3].HeaderText = "Статус";
                //Открыли новый рейс
                if (fl)
                {
                    break;
                }
              
            }
            ////Тест
            //if(tik>9)
            //{
            //    schTimer.Stop();
            //    return;
            //}

            //tik++;
            //tbTicketInfo.Text += "тик " + tik.ToString()+"\n";
        }

    
    }
}
