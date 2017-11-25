using System.Windows.Forms;
using System.Collections.Generic;

namespace airport_reg
{
    public partial class RegForm : Form
    {
        MyHookClass simpr;
        public RegForm()
        {
            InitializeComponent();
            //генерация списка рейсов
            Schedule sch = new Schedule(10);
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

        }
    }
}
